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

        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=True");
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdbtnManufacturer.Checked)
            {
                string getName = txtboxFactoryName.Text;
                string getEmail = msktxtEmail.Text;
                string getAddress = ddlCountries.Text;
                string getPassword = txtPassword.Text;
                int getFactoryID;

                connection.Open();
                SqlCommand command = new SqlCommand("INSERT into MANUFACTURING_FACTORIES(FactoryName, FactoryEmail, FactoryLocation, FactoryPassword)" + "VALUES('" + getName + "','" + getEmail + "', '" + getAddress + "', '" + getPassword + "')", connection);
                command.ExecuteNonQuery();
                SqlCommand commandID = new SqlCommand("Select FactoryID from MANUFACTURING_FACTORIES where FactoryEmail = @getEmail", connection);
                commandID.Parameters.AddWithValue("@getEmail", getEmail);
                getFactoryID = (int)commandID.ExecuteScalar();
                connection.Close();

                MessageBox.Show("Successfully.");
                NavigationForm navigationForm = new NavigationForm(getFactoryID);
                navigationForm.Show();
                this.Hide();
            }
            if (rdnbtnCustomer.Checked)
            {
                string getName = txtboxFactoryName.Text;
                string getEmail = msktxtEmail.Text;
                string getAddress = ddlCountries.Text;
                string getPassword = txtPassword.Text;
                int getFactoryID;

                connection.Open();
                SqlCommand command = new SqlCommand("INSERT into CUSTOMER_FACTORIES(CustomerFactoryName, CustomerFactoryEmail, CustomerFactoryLocation, CustomerFactoryPassword)" + "VALUES('" + getName + "', '" + getEmail + "', '" + getAddress + "', '" + getPassword + "')", connection);
                command.ExecuteNonQuery();
                SqlCommand commandID = new SqlCommand("Select CustomerFactoryID from CUSTOMER_FACTORIES where CustomerFactoryEmail = @getEmail", connection);
                commandID.Parameters.AddWithValue("@getEmail", getEmail);
                getFactoryID = (int)commandID.ExecuteScalar();
                connection.Close();

                MessageBox.Show("Successfully.");
                CustomerNavigationForm customerNavigationForm = new CustomerNavigationForm(getFactoryID);
                customerNavigationForm.Show();
                this.Hide();
            }
        }


    }

}

