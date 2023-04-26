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
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM MANUFACTURING_FACTORIES WHERE FactoryEmail = @Email AND FactoryPassword = @Password; SELECT COUNT(*) FROM CUSTOMER_FACTORIES WHERE CustomerFactoryEmail = @Email AND CustomerFactoryPassword = @Password", con);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            int resultManufacturing = (int)cmd.ExecuteScalar();
            int resultCustomer = (int)cmd.ExecuteScalar();
            if (resultManufacturing > 0 || resultCustomer > 0)
            {
                MessageBox.Show("Giriş Başarılı!");
                // Giriş başarılı olduğunda yapılacak işlemleri buraya yazın
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!");
            }
            con.Close();
        }


    }
}
