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
    public partial class CustomerReportsListForm : Form
    {
        private int factoryId;
        public CustomerReportsListForm(int getFactoryId)
        {
            factoryId = getFactoryId;
            InitializeComponent();
        }

        private void CustomerReportsListForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ReportID, OrderID, EstimatedArriveDate, EstimatedDepartureDate, Volume, Weight, ActualArrivalDate, ActualDepartureDate, ParcelAmount,Name FROM Reports";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    gvReports.DataSource = dataTable;
                    gvReports.Columns["ReportID"].Visible = false;
                    gvReports.Columns["OrderID"].Visible = false;
                    gvReports.Columns["EstimatedArriveDate"].Visible = false;
                    gvReports.Columns["EstimatedDepartureDate"].Visible = false;
                }
            }
        }

        private void btnNavigationForm_Click(object sender, EventArgs e)
        {
            CustomerNavigationForm LandingPageCustomerForm = new CustomerNavigationForm(factoryId);
            LandingPageCustomerForm.Show();
            this.Hide();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Reports WHERE Name LIKE '%" + txtFilter.Text + "%'", connection);

                adapter.Fill(dataTable);
                gvReports.DataSource = dataTable;



                connection.Close();
            }
        }
    }
}
