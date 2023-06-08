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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;");

        private void OrderProductForm_Load(object sender, EventArgs e)
        {


            connection.Open();
            // get data for comboBoxMF from CustomerFactories table
            string selectCustomerQuery = "SELECT FactoryName FROM MANUFACTURING_FACTORIES  ";
            using (SqlCommand command = new SqlCommand(selectCustomerQuery, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbboxManufacturerCompany.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            string selectWarehouseQuery = "SELECT WarehouseName FROM WAREHOUSES ";
            using (SqlCommand command = new SqlCommand(selectWarehouseQuery, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbboxWarehouse.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }

            // get data for comboBoxWarehouse from Warehouses table
            string selectProductsQuery = "SELECT ProductName FROM PRODUCTS";
            using (SqlCommand command = new SqlCommand(selectProductsQuery, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbboxProduct.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }



        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // get product and customer IDs from their names
                int productID, customerID;
                using (SqlCommand getProductID = new SqlCommand("SELECT ProductID FROM PRODUCTS WHERE ProductName = @productName", connection))
                {
                    getProductID.Parameters.AddWithValue("@productName", cmbboxProduct.Text);
                    var productIDResult = getProductID.ExecuteScalar();
                    if (productIDResult != null && productIDResult != DBNull.Value)
                    {
                        productID = Convert.ToInt32(productIDResult);
                    }
                    else
                    {
                        MessageBox.Show("Invalid product name.");
                        return;
                    }
                }

                using (SqlCommand getCustomerID = new SqlCommand("SELECT CustomerFactoryID FROM CUSTOMER_FACTORIES WHERE CustomerFactoryName = @customerName", connection))
                {
                    getCustomerID.Parameters.AddWithValue("@customerName", cmbboxManufacturerCompany.Text);
                    var customerIDResult = getCustomerID.ExecuteScalar();
                    if (customerIDResult != null && customerIDResult != DBNull.Value)
                    {
                        customerID = Convert.ToInt32(customerIDResult);
                    }
                    else
                    {
                        MessageBox.Show("Invalid customer name.");
                        return;
                    }
                }

                // insert new order
                string insertQuery = "INSERT INTO ORDERS (WarehouseProductID, CustomerFactoryID, OrderQuantity, OrderDate, OrderStatus) VALUES (@productID, @customerID, @quantity, @date, @status)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@productID", productID);
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@quantity", Convert.ToInt32(mtxtbxQuantity.Text));
                    command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    command.Parameters.AddWithValue("@status", "Pending");

                    command.ExecuteNonQuery();
                }

                string updateWarehouseQuery = "UPDATE WAREHOUSE_PRODUCTS SET ProductStockAmount = ProductStockAmount - @quantity WHERE WarehouseProductID = @productID";
                using (SqlCommand command = new SqlCommand(updateWarehouseQuery, connection))
                {
                    command.Parameters.AddWithValue("@productID", productID);
                    command.Parameters.AddWithValue("@quantity", Convert.ToInt32(mtxtbxQuantity.Text));
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Order added successfully!");

                // clear form
                cmbboxProduct.SelectedIndex = -1;
                cmbboxManufacturerCompany.SelectedIndex = -1;
                mtxtbxQuantity.Text = "";
            }
        }


        private void cmbboxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectWarehouseQuery = "SELECT WarehouseName FROM WAREHOUSES WHERE FactoryID = (SELECT FactoryID FROM MANUFACTURING_FACTORIES WHERE FactoryName = @factoryName)";
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Bağlantıyı aç

                using (SqlCommand command = new SqlCommand(selectWarehouseQuery, connection))
                {
                    command.Parameters.AddWithValue("@factoryName", cmbboxManufacturerCompany.SelectedItem.ToString());
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cmbboxWarehouse.Items.Add(reader.GetString(0));
                        }
                    }
                    reader.Close();
                }
            }


        }

        private void cmbboxManufacturerCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Önce seçilen müşteri fabrikasının adını alın
            string selectedCustomer = cmbboxManufacturerCompany.SelectedItem.ToString();

            // Ardından, bu müşteriye ait depoların adlarını getirin
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectWarehouseQuery = "SELECT WarehouseName FROM WAREHOUSES WHERE FactoryID = (SELECT FactoryID FROM MANUFACTURING_FACTORIES WHERE FactoryName = @factoryName)";
                using (SqlCommand command = new SqlCommand(selectWarehouseQuery, connection))
                {
                    command.Parameters.AddWithValue("@factoryName", selectedCustomer);
                    SqlDataReader reader = command.ExecuteReader();
                    cmbboxWarehouse.Items.Clear(); // ComboBox içeriğini temizle
                    while (reader.Read())
                    {
                        cmbboxWarehouse.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
        }
    }
}
