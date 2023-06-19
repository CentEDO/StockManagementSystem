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
            CustomerNavigationForm navigationForm = new CustomerNavigationForm(factoryID);
            navigationForm.Show();
            this.Hide();
        }

        private void ManufacturerFactoriesList_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT FactoryName, FactoryLocation,FactoryEmail FROM MANUFACTURING_FACTORIES";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    gvManufacturerFactories.DataSource = dataTable;
                    


                }
            }
        }
        

    }
}
