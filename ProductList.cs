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
    public partial class ProductList : Form
    {
        private int factoryID;
        public ProductList(int getFactoryID)
        {
            factoryID = getFactoryID;
            InitializeComponent();
        }


        private void ProductList_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT Products.ProductID, Products.ProductName, Products.ProductStockAmount, Warehouses.WarehouseName AS WarehouseName
                                FROM Products
                                JOIN Warehouses ON Products.WarehouseID = Warehouses.WarehouseID
                                WHERE Products.ProductStockAmount > 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    gvProducts.DataSource = dataTable;
                    gvProducts.Columns["ProductID"].Visible = false;
                    //dataGridViewPL.Columns["WarehouseID"].Visible = false;
                }
            }
        }

        private void btnBackNavForm_Click(object sender, EventArgs e)
        {
            NavigationForm navigationForm = new NavigationForm(factoryID);
            navigationForm.Show();
            this.Hide();
        }
    }
}
