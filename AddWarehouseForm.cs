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
        public AddWarehouseForm()
        {
            InitializeComponent();
        }

        private void AddWarehouseForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Midterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT FactoryName FROM ManufacturingFactories";
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
                string factoryIDQuery = "SELECT FactoryID FROM ManufacturingFactories WHERE FactoryName = @factoryName";
                using (SqlCommand factoryIDCommand = new SqlCommand(factoryIDQuery, connection))
                {
                    factoryIDCommand.Parameters.AddWithValue("@factoryName", cmbboxFactoryName.Text);
                    int factoryID = Convert.ToInt32(factoryIDCommand.ExecuteScalar());

                    string insertQuery = "INSERT INTO Warehouses (WarehouseName, WarehouseLocation,FactoryID ) VALUES (@name, @location,@factoryID)";
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
    }
    
}
