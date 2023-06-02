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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = msktxtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query;
            if (rdbtnManufacturer.Checked)
            {
                
                query = "SELECT COUNT(*) FROM MANUFACTURING_FACTORIES WHERE FactoryEmail = @Email AND FactoryPassword = @Password";
                
            }
            else if (rdbtnCustomer.Checked)
            {
                query = "SELECT COUNT(*) FROM CUSTOMER_FACTORIES WHERE CustomerFactoryEmail = @Email AND CustomerFactoryPassword = @Password";
            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapın!");
                return;
            }

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            int getFactoryID = (int)cmd.ExecuteScalar();

            int result = (int)cmd.ExecuteScalar();
            if (result > 0)
            {
                MessageBox.Show("Giriş Başarılı!");
                NavigationForm navigationForm = new NavigationForm(getFactoryID);
                navigationForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!");
            }

            con.Close();
        }



    }
}
