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
    public partial class OrderForm : Form
    {
        private int factoryID;  
        public OrderForm(int getFactoryId)
        {
            factoryID = getFactoryId;
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // Veritabanı bağlantısı için connection string'i tanımlayın
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                    connection.Open();
                    // get data for comboBoxMF from CustomerFactories table
                    string selectCustomerQuery = "SELECT FactoryName FROM MANUFACTURING_FACTORIES  ";
                    using (SqlCommand command1 = new SqlCommand(selectCustomerQuery, connection))
                    {
                        SqlDataReader reader = command1.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbboxManufacturerCompany.Items.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }
                    string selectWarehouseQuery = "SELECT WarehouseName FROM WAREHOUSES ";
                    using (SqlCommand cmd = new SqlCommand(selectWarehouseQuery, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbboxWarehouse.Items.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }

                    // get data for comboBoxWarehouse from Warehouses table
                    string selectProductsQuery = "SELECT ProductName FROM PRODUCTS";
                    using (SqlCommand cmd1 = new SqlCommand(selectProductsQuery, connection))
                    {
                        SqlDataReader reader = cmd1.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbboxProduct.Items.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }


                
                // SQL sorgusunu oluşturun
                string sqlQuery = @"SELECT R.OrderID, CF.CustomerFactoryName, P.ProductName, R.OrderDate, R.OrderQuantity 
                            FROM ORDERS R
                            INNER JOIN CUSTOMER_FACTORIES CF ON R.CustomerFactoryID = CF.CustomerFactoryID
                            INNER JOIN WAREHOUSE_PRODUCTS WP ON R.WarehouseProductID = WP.WarehouseProductID
                            INNER JOIN PRODUCTS P ON WP.ProductID = P.ProductID
                            WHERE CF.CustomerFactoryID = @CustomerFactoryID";

                // SqlCommand nesnesini oluşturun ve parametre ekleyin
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@CustomerFactoryID", factoryID);

                // SqlDataAdapter ve DataTable oluşturun
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                // Verileri dataAdapter ile doldurun
                dataAdapter.Fill(dataTable);

                // DataGridView'e DataTable'i bağlayın
                gvOrderList.DataSource = dataTable;
                gvOrderList.Columns["OrderID"].Visible = false;
            }
        }

        private DataTable GetOrdersData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "SELECT * FROM ORDERS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        private void DecreaseQuantityInStock()
        {
            int quantityToDecrease;
            int warehouseInventoryId;
            int productId;

            try
            {
                quantityToDecrease = Convert.ToInt32(mtxtbxQuantity.Text);
                warehouseInventoryId = (int)cmbboxWarehouse.SelectedValue;
                productId = (int)cmbboxProduct.SelectedValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE WAREHOUSE_PRODUCTS SET Quantity = Quantity - @QuantityToDecrease " +
                                         "WHERE WarehouseProductID = @WarehouseInventoryId";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@QuantityToDecrease", quantityToDecrease);
                    command.Parameters.AddWithValue("@WarehouseInventoryId", warehouseInventoryId);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            int quantity;
            int factoryId;
            int warehouseInventoryId;
            int productId;
            DateTime orderDate = DateTime.Now.Date;

            try
            {
                quantity = Convert.ToInt32(mtxtbxQuantity.Text);
                factoryId = (int)cmbboxManufacturerCompany.SelectedValue;
                warehouseInventoryId = (int)cmbboxWarehouse.SelectedValue;
                productId = (int)cmbboxProduct.SelectedValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if there is enough quantity in the WarehouseInventory
                    string checkQuantityQuery = "SELECT ProductStockAmount FROM WAREHOUSE_PRODUCTS WHERE WarehouseProductID = @WarehouseInventoryId";
                    SqlCommand checkQuantityCmd = new SqlCommand(checkQuantityQuery, conn);
                    checkQuantityCmd.Parameters.AddWithValue("@WarehouseInventoryId", warehouseInventoryId);
                    int quantityInStock = (int)checkQuantityCmd.ExecuteScalar();

                    if (quantity > quantityInStock)
                    {
                        MessageBox.Show("Insufficient quantity in stock. Cannot place the order.");
                        return;
                    }

                    // Add the order
                    string addOrderQuery = "INSERT INTO ORDERS (WarehouseProductID, CustomerFactoryID, OrderQuantity, OrderDate, OrderStatus) VALUES (@WarehouseProductID, @CustomerFactoryID, @OrderQuantity, @OrderDate, @OrderStatus)";
                    SqlCommand addOrderCmd = new SqlCommand(addOrderQuery, conn);
                    addOrderCmd.Parameters.AddWithValue("@WarehouseProductID", warehouseInventoryId);
                    addOrderCmd.Parameters.AddWithValue("@CustomerFactoryID", factoryId);
                    addOrderCmd.Parameters.AddWithValue("@OrderQuantity", quantity);
                    addOrderCmd.Parameters.AddWithValue("@OrderDate", orderDate);
                    addOrderCmd.Parameters.AddWithValue("@OrderStatus", "Pending");

                    int rowsInserted = addOrderCmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Order added successfully.");
                        DecreaseQuantityInStock();
                        gvOrderList.DataSource = GetOrdersData();
                    }
                    else
                    {
                        MessageBox.Show("Order could not be added.");
                    }

                    // Refresh the DataGridView or perform any other necessary updates
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}
