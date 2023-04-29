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
    public partial class ProductAddingForm : Form
    {
        public ProductAddingForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Depo adına karşılık gelen depo ID'sini bul
                string warehouseIDQuery = "SELECT WarehouseID FROM Warehouses WHERE WarehouseName = @warehouseName";
                using (SqlCommand warehouseIDCommand = new SqlCommand(warehouseIDQuery, connection))
                {
                    warehouseIDCommand.Parameters.AddWithValue("@warehouseName", cmbboxWarehouse.Text);
                    int warehouseID = (int)warehouseIDCommand.ExecuteScalar();

                    // Yeni bir ürün ekle
                    string insertQuery = "INSERT INTO Products (ProductName, ProductDescription, ProductPrice, ProductStockAmount) " +
                                         "VALUES (@name, @description, @price, @amount); SELECT SCOPE_IDENTITY()";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtProductName.Text);
                        command.Parameters.AddWithValue("@description", txtDescription.Text);
                        command.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                        command.Parameters.AddWithValue("@amount", Convert.ToInt32(txtStockAmount.Text));
                        int productID = Convert.ToInt32(command.ExecuteScalar());

                        // Depo ve ürün bağlantısını kur
                        string insertWarehouseProductQuery = "INSERT INTO WAREHOUSE_PRODUCTS (WarehouseID, ProductID, Quantity) " +
                                                              "VALUES (@warehouseID, @productID, @quantity)";
                        using (SqlCommand warehouseProductCommand = new SqlCommand(insertWarehouseProductQuery, connection))
                        {
                            warehouseProductCommand.Parameters.AddWithValue("@warehouseID", warehouseID);
                            warehouseProductCommand.Parameters.AddWithValue("@productID", productID);
                            warehouseProductCommand.Parameters.AddWithValue("@quantity", 0);
                            warehouseProductCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Product Added !");
                        NavigationForm navigationForm = new NavigationForm();
                        navigationForm.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
