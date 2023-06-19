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
    public partial class CustomerFactoriesList : Form
    {
        private int factoryID;
        public CustomerFactoriesList(int getFactoryID)
        {
            factoryID = getFactoryID;
            InitializeComponent();
        }
        //private void CustomerFactoriesListForm_Load(object sender, EventArgs e)
        //{
        //    string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        string query = "SELECT * FROM CUSTOMER_FACTORIES";

        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            SqlDataReader reader = command.ExecuteReader();

        //            DataTable dataTable = new DataTable();
        //            dataTable.Load(reader);

        //            gvCustomerFactories.DataSource = dataTable;
        //            gvCustomerFactories.Columns["CustomerPassword"].Visible = false;
        //            gvCustomerFactories.Columns["CustomerID"].Visible = false;


        //        }
        //    }
        //}

        private void btnBackNavForm_Click(object sender, EventArgs e)
        {

            NavigationForm navigationForm = new NavigationForm(factoryID);
            navigationForm.Show();
            this.Hide();

        }
        private void txtSearchFactoryName_TextChanged(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                //  SqlDataAdapter adapter = new SqlDataAdapter("SELECT w.WarehouseName, w.WarehouseLocation, f.FactoryName FROM Warehouses w INNER JOIN ManufacturingFactories f ON w.FactoryID = f.FactoryID WHERE f.FactoryName LIKE '%" + txtSearch.Text + "%'", connection);
                /// SqlDataAdapter adapter = new SqlDataAdapter("SELECT WarehouseName, WarehouseLocation, FactoryName FROM Warehouses INNER JOIN ManufacturingFactories ON Warehouses.FactoryID = ManufacturingFactories.FactoryID WHERE Warehouses.FactoryID = " + FactoryID + " AND FactoryName LIKE '%" + txtSearchFactoryName.Text + "%'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CUSTOMER_FACTORIES WHERE CustomerFactoryName LIKE '%" + txtCustomerFactoryName.Text + "%'", connection);

                adapter.Fill(dataTable);
                gvCustomerFactories.DataSource = dataTable;
                //dataGridViewWL.Columns["ManufactoringPassword"].Visible = false;
                //dataGridViewWL.Columns["FactoryID"].Visible = false;
                //dataGridViewWL.Columns["ContactPhone"].Visible = false;


                connection.Close();
            }

        }

        private void CustomerFactoriesList_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM CUSTOMER_FACTORIES";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    gvCustomerFactories.DataSource = dataTable;
                    gvCustomerFactories.Columns["CustomerFactoryPassword"].Visible = false;
                    gvCustomerFactories.Columns["CustomerFactoryID"].Visible = false;


                }
            }
        }
    }
}
