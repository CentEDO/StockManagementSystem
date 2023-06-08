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
    public partial class FactoryLogin : Form
    {
        public FactoryLogin()
        {
            
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string getEmail = msktxtEmail.Text;
            string getPassword = txtPassword.Text;

            try
            {
                connection.Open();
                String Manufacturing = "SELECT FactoryEmail, FactoryPassword FROM MANUFACTURING_FACTORIES WHERE FactoryEmail = '" + getEmail + "' AND FactoryPassword = '" + getPassword + "'";
                String Customer = "SELECT CustomerFactoryEmail, CustomerFactoryPassword FROM CUSTOMER_FACTORIES WHERE CustomerFactoryEmail = '" + getEmail + "' AND CustomerFactoryPassword = '" + getPassword + "'";
                SqlDataAdapter adapterManufacturing = new SqlDataAdapter(Manufacturing, connection);
                SqlDataAdapter adapterCustomer = new SqlDataAdapter(Customer, connection);
                DataTable datatableManufacturing = new DataTable();
                adapterManufacturing.Fill(datatableManufacturing);
                DataTable datatableCustomer = new DataTable();
                adapterCustomer.Fill(datatableCustomer);

                if (datatableManufacturing.Rows.Count > 0)
                {
                    int getFactoryID;
                    SqlCommand commandFactoryID = new SqlCommand("SELECT FactoryID from MANUFACTURING_FACTORIES where FactoryEmail = @getEmail", connection);
                    commandFactoryID.Parameters.AddWithValue("@getEmail", getEmail);
                    getFactoryID = (int)commandFactoryID.ExecuteScalar();


                    NavigationForm navigationForm = new NavigationForm(getFactoryID);
                    navigationForm.Show();
                    this.Hide();
                }
                else if (datatableCustomer.Rows.Count > 0)
                {
                    int getFactoryID;
                    SqlCommand commandFactoryID = new SqlCommand("SELECT CustomerFactoryID from CUSTOMER_FACTORIES where CustomerFactoryEmail = @getEmail", connection);
                    commandFactoryID.Parameters.AddWithValue("@getEmail", getEmail);
                    getFactoryID = (int)commandFactoryID.ExecuteScalar();


                    CustomerNavigationForm customerNavigationForm = new CustomerNavigationForm(getFactoryID);
                    customerNavigationForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No Match.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



    }
}
