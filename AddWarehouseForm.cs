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
    public partial class AddWarehouseForm : Form
    {
        private int factoryID;
        public AddWarehouseForm(int getFactoryID)
        {
            factoryID = getFactoryID;
            InitializeComponent();
        }

        private void WarehouseAddForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT FactoryName FROM MANUFACTURING_FACTORIES WHERE MANUFACTURING_FACTORIES.FactoryID= " + factoryID;
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbboxFactoryName.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string factoryIDQuery = "SELECT FactoryID FROM MANUFACTURING_FACTORIES WHERE FactoryName = @factoryName";
                using (SqlCommand factoryIDCommand = new SqlCommand(factoryIDQuery, connection))
                {
                    factoryIDCommand.Parameters.AddWithValue("@factoryName", cmbboxFactoryName.Text);
                    int factoryID = Convert.ToInt32(factoryIDCommand.ExecuteScalar());

                    string insertQuery = "INSERT INTO WAREHOUSES (WarehouseName, WarehouseLocation, FactoryID) VALUES (@name, @location, @factoryID)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtWarehouseName.Text);
                        command.Parameters.AddWithValue("@location", txtWarehouseAddress.Text);
                        command.Parameters.AddWithValue("@factoryID", factoryID);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }


        private void btnBackNavigationForm_Click(object sender, EventArgs e)
        {
            NavigationForm  navigationForm= new NavigationForm(factoryID);
            navigationForm.Show();
            this.Hide();
        }

        private void AddWarehouseForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT FactoryName FROM MANUFACTURING_FACTORIES WHERE MANUFACTURING_FACTORIES.FactoryID=  " + factoryID;
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbboxFactoryName.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
        }

    }

}
