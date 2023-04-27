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
    public partial class FactoryRegistration : Form
    {
        public FactoryRegistration()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if (rdbtnManufacturer.Checked)
                {
                    string insertQuery = "INSERT INTO MANUFACTURER_FACTORIES (CustomerFactoryName, CustomerFactoryLocation, CustomerFactoryEmail, CustomerFactoryPassword) " +
                                        "VALUES (@name, @location, @email, @password)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtboxFactoryName.Text);
                        command.Parameters.AddWithValue("@location", ddlCountries.Text);
                        command.Parameters.AddWithValue("@email", msktxtEmail.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration completed!");
                        NavigationForm navigationForm = new NavigationForm();
                        navigationForm.Show();
                        this.Hide();
                    }
                }
                if (rdnbtnCustomer.Checked)
                {
                    string insertQuery = "INSERT INTO CUSTOMER_FACTORIES (CustomerFactoryName, CustomerFactoryLocation, CustomerFactoryEmail, CustomerFactoryPassword) " +
                                        "VALUES (@name, @location, @email, @password)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtboxFactoryName.Text);
                        command.Parameters.AddWithValue("@location", ddlCountries.Text);
                        command.Parameters.AddWithValue("@email", msktxtEmail.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration completed!");
                        NavigationForm navigationForm = new NavigationForm();
                        navigationForm.Show();
                        this.Hide();
                    }
                    
                }
            }
        }
    }
}
