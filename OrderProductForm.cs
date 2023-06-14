using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPMidterm
{
    public partial class OrderProductForm : Form
    {
        private int factoryID;
        public OrderProductForm(int getFactoryID)
        {
            factoryID = getFactoryID;
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;");
        private Dictionary<int, string> factories = new Dictionary<int, string>();
        private void OrderProductForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand commandName = new SqlCommand("SELECT FactoryID, FactoryName FROM MANUFACTURING_FACTORIES", con);
            SqlDataReader readerName = commandName.ExecuteReader();
            while (readerName.Read())
            {
                factories.Add(readerName.GetInt32(0), readerName.GetString(1));
            }
            readerName.Close();
            cmbboxManufacturerCompany.DisplayMember = "Value";
            cmbboxManufacturerCompany.ValueMember = "Key";
            cmbboxManufacturerCompany.DataSource = new BindingSource(factories, null);


            con.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string selectedFactoryName = cmbboxManufacturerCompany.SelectedItem.ToString();
            int selectedFactoryID = (int)cmbboxManufacturerCompany.SelectedValue;
            int orderAmount = Convert.ToInt32(mtxtbxQuantity.Text);

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;"))
            {
                conn.Open();
                SqlCommand commandFactory = new SqlCommand("SELECT FactoryID from MANUFACTURING_FACTORIES where FactoryName = @FactoryName", conn);
                commandFactory.Parameters.AddWithValue("@FactoryName", selectedFactoryName);
                SqlDataReader readerID = commandFactory.ExecuteReader();
                if (readerID.Read())
                {
                    selectedFactoryID = readerID.GetInt32(0);
                }
                readerID.Close();

                SqlCommand commandProduct = new SqlCommand("SELECT Products.ProductName, Products.ProductStockAmount, MANUFACTURING_FACTORIES.FactoryEmail FROM Products JOIN MANUFACTURING_FACTORIES ON Products.FactoryID = MANUFACTURING_FACTORIES.FactoryID Where Products.FactoryID = @FactoryID", conn);
                commandProduct.Parameters.AddWithValue("@FactoryID", selectedFactoryID);

                SqlDataReader readerUpdate = commandProduct.ExecuteReader();

                if (readerUpdate.Read())
                {
                    int amountProduct = readerUpdate.GetInt32(1);

                    if (amountProduct >= orderAmount)
                    {
                        readerUpdate.Close();

                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            SqlCommand commandUpdate = new SqlCommand("UPDATE Products SET ProductStockAmount = ProductStockAmount - @Amount WHERE ProductID = @ProductID", conn, transaction);
                            string selectedProductName = cmbboxProduct.SelectedItem.ToString();
                            int productId = GetProductId(selectedProductName);

                            commandUpdate.Parameters.AddWithValue("@ProductID", productId);
                            commandUpdate.Parameters.AddWithValue("@Amount", orderAmount);
                            commandUpdate.ExecuteNonQuery(); 

                            DateTime orderDate = DateTime.Now;
                            SqlCommand commandOrders = new SqlCommand("INSERT into Orders(CustomerFactoryID, ProductID, OrderDate, OrderQuantity) VALUES(@CustomerFactoryID, @ProductID, @OrderDate, @OrderQuantity)", conn, transaction);
                            commandOrders.Parameters.AddWithValue("@CustomerFactoryID", factoryID);
                            commandOrders.Parameters.AddWithValue("@ProductID", productId);
                            commandOrders.Parameters.AddWithValue("@OrderDate", orderDate);
                            commandOrders.Parameters.AddWithValue("@OrderQuantity", orderAmount);
                            commandOrders.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("The order is successful.");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("An error occurred while updating the stock: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient stock quantity.");
                    }
                }
            }
        }

        private int GetProductId(string productName)
        {
            int productId = 0;

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;"))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT ProductID FROM Products WHERE ProductName = @ProductName", conn);
                command.Parameters.AddWithValue("@ProductName", productName);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    productId = reader.GetInt32(0);
                }
                reader.Close();
            }

            return productId;
        }

        private void cmbboxManufacturerCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFactoryName = cmbboxManufacturerCompany.SelectedItem.ToString();
            int selectedFactoryID = (int)cmbboxManufacturerCompany.SelectedValue;

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;"))
            {
                conn.Open();

                SqlCommand commandFactory = new SqlCommand("SELECT FactoryID FROM MANUFACTURING_FACTORIES WHERE FactoryName = @FactoryName", conn);
                commandFactory.Parameters.AddWithValue("@FactoryName", selectedFactoryName);
                SqlDataReader readerID = commandFactory.ExecuteReader();
                if (readerID.Read())
                {
                    selectedFactoryID = readerID.GetInt32(0);
                }
                readerID.Close();

                SqlCommand commandProduct = new SqlCommand("SELECT DISTINCT Products.ProductName, Products.ProductStockAmount, Warehouses.WarehouseName AS WarehouseName, Products.ProductID FROM Products JOIN Warehouses ON Products.WarehouseID = Warehouses.WarehouseID WHERE Products.FactoryID = @FactoryID", conn);
                commandProduct.Parameters.AddWithValue("@FactoryID", selectedFactoryID);

                SqlDataReader readerProducts = commandProduct.ExecuteReader();

                // ComboBox'ı temizle
                cmbboxWarehouse.Items.Clear();

                while (readerProducts.Read())
                {
                    string productName = readerProducts.GetString(0);
                    string warehouseName = readerProducts.GetString(2);
                    int productID = readerProducts.GetInt32(3);

                    // ComboBox'a sadece depo adını ekleyin
                    cmbboxWarehouse.Items.Add(warehouseName);
                }

                readerProducts.Close();
            }
        }

        private void cmbboxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen depo adını al
            string selectedWarehouseName = cmbboxWarehouse.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;"))
            {
                conn.Open();

                SqlCommand commandProduct = new SqlCommand("SELECT Products.ProductName, Products.ProductID FROM Products JOIN Warehouses ON Products.WarehouseID = Warehouses.WarehouseID WHERE Warehouses.WarehouseName = @WarehouseName", conn);
                commandProduct.Parameters.AddWithValue("@WarehouseName", selectedWarehouseName);

                SqlDataReader readerProducts = commandProduct.ExecuteReader();

                cmbboxProduct.Items.Clear();

                while (readerProducts.Read())
                {
                    string productName = readerProducts.GetString(0);
                    int productID = readerProducts.GetInt32(1);

                    // ComboBox'a ürünleri ekle
                    cmbboxProduct.Items.Add(productName);
                }

                readerProducts.Close();
            }
        }

        private void btnBackNavForm_Click(object sender, EventArgs e)
        {
            CustomerNavigationForm customerNavigationForm = new CustomerNavigationForm(factoryID);
            customerNavigationForm.Show();
            this.Hide();
        }
    }
}
