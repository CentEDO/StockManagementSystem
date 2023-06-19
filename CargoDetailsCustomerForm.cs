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
    public partial class CargoDetailsCustomerForm : Form
    {
        private int factoryId;

        public CargoDetailsCustomerForm(int getFactoryId)
        {
            factoryId = getFactoryId;
            InitializeComponent();
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
        private void CargoDetailsCustomerForm_Load(object sender, EventArgs e)
        {
              // ListView kontrolünün özelliklerini ayarla
            lvCargoDetails.CheckBoxes = true;
            lvCargoDetails.View = View.Details;
            lvCargoDetails.Columns.Add("ProductID", 120);
            lvCargoDetails.Columns.Add("CustomerFactoryID", 120);
            lvCargoDetails.Columns.Add("OrderID", 120);
            lvCargoDetails.Columns.Add("OrderQuantity", 120);
            lvCargoDetails.Columns.Add("OrderDate", 120);


            // Veritabanından verileri çekme
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerFactoryID,OrderID, ProductID, OrderQuantity, OrderDate, IsArrived FROM ORDERS";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string column1Value = reader["CustomerFactoryID"].ToString();
                    string column2Value = reader["ProductID"].ToString();
                    string column3Value = reader["OrderQuantity"].ToString();
                    string column4Value = reader["OrderDate"].ToString();
                    string column5Value = reader["OrderID"].ToString();
                    bool? IsArrived = reader.IsDBNull(reader.GetOrdinal("IsArrived")) ? (bool?)null : Convert.ToBoolean(reader["IsArrived"]);

                    ListViewItem item = new ListViewItem(column1Value);
                    item.SubItems.Add(column2Value);
                    item.SubItems.Add(column5Value);
                    item.SubItems.Add(column3Value);
                    item.SubItems.Add(column4Value);
                    if (IsArrived.HasValue)
                        item.Checked = IsArrived.Value;

                    lvCargoDetails.Items.Add(item);
                }

                reader.Close();
            }

            // ItemChecked olayını ListView kontrolüne ekleyin

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvCargoDetails.Items)
            {
                int orderID = int.Parse(item.SubItems[2].Text);
                bool IsArrived = item.Checked;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Orders SET IsArrived = @IsArrived WHERE OrderID = @OrderID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@IsArrived", IsArrived);
                        command.Parameters.AddWithValue("@OrderID", orderID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Güncelleme başarılı.");

                            // Reports tablosunu güncelle
                            DateTime actualDepartureDate = DateTime.Now;
                            DateTime actualArrivalDate = DateTime.Now;

                            string updateReportsQuery = "UPDATE Reports SET ActualDepartureDate = @ActualDepartureDate, ActualArrivalDate = @ActualArrivalDate WHERE OrderID = @OrderID";
                            SqlCommand updateReportsCommand = new SqlCommand(updateReportsQuery, connection);
                            updateReportsCommand.Parameters.AddWithValue("@ActualDepartureDate", actualDepartureDate);
                            updateReportsCommand.Parameters.AddWithValue("@ActualArrivalDate", actualArrivalDate);
                            updateReportsCommand.Parameters.AddWithValue("@OrderID", orderID);

                            int reportsRowsAffected = updateReportsCommand.ExecuteNonQuery();

                            if (reportsRowsAffected > 0)
                            {
                                MessageBox.Show("Reports tablosu güncellendi.");
                            }
                            else
                            {
                                MessageBox.Show("Reports tablosu güncellenirken bir hata oluştu.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnNavigationPage_Click(object sender, EventArgs e)
        {
            CustomerNavigationForm customerNavigationForm = new CustomerNavigationForm(factoryId);
            customerNavigationForm.Show();
            this.Hide();
        }
    }
    
}
