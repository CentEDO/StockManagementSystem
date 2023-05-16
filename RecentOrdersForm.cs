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
    public partial class RecentOrdersForm : Form
    {
        private int factoryID;

        public RecentOrdersForm()
        {
            InitializeComponent();
        }

        public RecentOrdersForm(int factoryID)
        {
            this.factoryID = factoryID;
        }

        private void RecentOrdersForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT R.RequestID, CF.CustomerFactoryName, P.ProductName, R.RequestDate, R.RequestQuantity
                         FROM ORDERS R
                         INNER JOIN CUSTOMER_FACTORIES CF ON R.CustomerFactoryID = CF.CustomerFactoryID
                         INNER JOIN PRODUCTS P ON R.WarehouseProductID = P.WarehouseProductID
                         WHERE CF.CustomerFactoryID = @CustomerFactoryID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerFactoryID", factoryID);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                gvRecentOrders.DataSource = dataTable;
                gvRecentOrders.Columns["RequestID"].Visible = false;
            }
        }

    }
}
