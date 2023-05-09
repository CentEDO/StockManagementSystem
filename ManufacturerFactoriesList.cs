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
    public partial class ManufacturerFactoriesList : Form
    {
        private int factoryID;

        public ManufacturerFactoriesList(int getFactoryID)
        {
            factoryID = getFactoryID;
            InitializeComponent();
        }
        private void btnBackNavForm_Click(object sender, EventArgs e)
        {
            CustomerNavigationForm customerNavigationForm = new CustomerNavigationForm(factoryID);
            customerNavigationForm.Show();
            this.Hide();
        }

        private void ManufacturerFactoriesList_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM MANUFACTURING_FACTORIES";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    gvManufacturerFactories.DataSource = dataTable;
                    gvManufacturerFactories.Columns["ManufactoringPassword"].Visible = false;
                    gvManufacturerFactories.Columns["FactoryID"].Visible = false;


                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                //  SqlDataAdapter adapter = new SqlDataAdapter("SELECT w.WarehouseName, w.WarehouseLocation, f.FactoryName FROM Warehouses w INNER JOIN ManufacturingFactories f ON w.FactoryID = f.FactoryID WHERE f.FactoryName LIKE '%" + txtSearch.Text + "%'", connection);
                /// SqlDataAdapter adapter = new SqlDataAdapter("SELECT WarehouseName, WarehouseLocation, FactoryName FROM Warehouses INNER JOIN ManufacturingFactories ON Warehouses.FactoryID = ManufacturingFactories.FactoryID WHERE Warehouses.FactoryID = " + FactoryID + " AND FactoryName LIKE '%" + txtSearchFactoryName.Text + "%'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM MANUFACTURING_FACTORIES WHERE FactoryName LIKE '%" + txtManufacturerName.Text + "%'", connection);

                adapter.Fill(dataTable);
                gvManufacturerFactories.DataSource = dataTable;
                //dataGridViewWL.Columns["ManufactoringPassword"].Visible = false;
                //dataGridViewWL.Columns["FactoryID"].Visible = false;
                //dataGridViewWL.Columns["ContactPhone"].Visible = false;


                connection.Close();
            }
        }

    }
}
