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
    public partial class OrderDetailsForm : Form
    {
        private int factoryId;
        public OrderDetailsForm(int getFactoryId)
        {
            factoryId = getFactoryId;
            InitializeComponent();
        }



        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT OrderID FROM ORDERS";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerFactoryID", factoryId);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbOrderId.Items.Add(reader.GetInt32(0).ToString());
                    }
                    reader.Close();
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO Reports (OrderId, Name, EstimatedArriveDate, EstimatedDepartureDate, Volume, Weight, ActualArrivalDate, ActualDepartureDate, ParcelAmount) " +
                                 "VALUES (@OrderId, @Name,  @estimatedArriveDate, @estimatedDepartureDate, @volume, @weight, @actualArrivalDate, @actualDepartureDate, @parcelAmount)";

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", Convert.ToInt32(cmbOrderId.Text));
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@estimatedArriveDate", Convert.ToDateTime(dateEstArrDate.Text));
                    command.Parameters.AddWithValue("@estimatedDepartureDate", Convert.ToDateTime(dateEsDepDate.Text));
                    command.Parameters.AddWithValue("@volume", Convert.ToDecimal(numericVolume.Text));
                    command.Parameters.AddWithValue("@weight", Convert.ToDecimal(numericWeight.Text));
                    command.Parameters.AddWithValue("@actualArrivalDate", Convert.ToDateTime(dateActArrDate.Text));
                    command.Parameters.AddWithValue("@actualDepartureDate", Convert.ToDateTime(dateActDepDate.Text));
                    command.Parameters.AddWithValue("@parcelAmount", Convert.ToInt32(numericAmount.Text));

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Data Added.");

                // Diğer işlemler veya form geçişi
            }
        }

        private void btnNavigationPage_Click(object sender, EventArgs e)
        {
            NavigationForm navigationForm = new NavigationForm(factoryId);
            navigationForm.Show();
            this.Hide();
        }
    }

            
}
