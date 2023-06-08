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
    //public partial class RecentOrdersForm : Form
    //{
    //    private int factoryID;

    //    public RecentOrdersForm(int getFactoryID)
    //    {
    //        InitializeComponent();
    //        factoryID = getFactoryID;
    //    }

    //    private void RecentOrdersForm_Load(object sender, EventArgs e)
    //    {
    //        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
    //        using (SqlConnection connection = new SqlConnection(connectionString))
    //        {
    //            connection.Open();

    //            string query = @"SELECT * FROM ORDERS WHERE CustomerFactoryID=@CustomerFactoryID";

    //            SqlCommand command = new SqlCommand(query, connection);
    //            command.Parameters.AddWithValue("@CustomerFactoryID", factoryID);

    //            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
    //            DataTable dataTable = new DataTable();
    //            dataAdapter.Fill(dataTable);

    //            gvRecentOrders.DataSource = dataTable;
    //        }
    //    }

    //}
    public partial class RecentOrdersForm : Form
    {
        private int factoryID;

        public RecentOrdersForm(int getFactoryID)
        {
            InitializeComponent();
            factoryID = getFactoryID;
        }

        private void RecentOrdersForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT Orders.OrderID, Products.ProductName, Warehouses.WarehouseName, Orders.OrderDate, Orders.OrderQuantity 
                            FROM ORDERS 
                            JOIN Products ON Orders.ProductID = Products.ProductID
                            JOIN Warehouses ON Products.WarehouseID = Warehouses.WarehouseID
                            WHERE CustomerFactoryID = @CustomerFactoryID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerFactoryID", factoryID);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                gvRecentOrders.DataSource = dataTable;
                gvRecentOrders.Columns["OrderID"].Visible = false;
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
