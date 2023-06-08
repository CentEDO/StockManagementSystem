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
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;");
        private void ProductList_Load(object sender, EventArgs e)
        {


            connection.Open();

            SqlCommand commandProduct = new SqlCommand("SELECT DISTINCT Products.ProductName, Products.ProductStockAmount, Warehouses.WarehouseName AS WarehouseName FROM Products JOIN Warehouses ON Products.WarehouseID = Warehouses.WarehouseID JOIN MANUFACTURING_FACTORIES ON Products.FactoryID = @getFactoryID", connection);
            commandProduct.Parameters.AddWithValue("@getFactoryID", factoryID);
            SqlDataReader readerProducts = commandProduct.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(readerProducts);
            gvProducts.DataSource = dataTable;
            readerProducts.Close();
            connection.Close();

        }


            
        private void btnBackNavForm_Click(object sender, EventArgs e)
        {
            NavigationForm navigationForm = new NavigationForm(factoryID);
            navigationForm.Show();
            this.Hide();
        }
    }
}
