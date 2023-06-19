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
    public partial class ConfirmOrderForm : Form
    {
        private int factoryId;
        public ConfirmOrderForm(int getFactoryId)
        {
            factoryId = getFactoryId;
            InitializeComponent();
        }
        string connectionString =@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = VPMidterm; Integrated Security = SSPI;";
        private void ConfirmOrderForm_Load(object sender, EventArgs e)
        {
            lvConfirmList.CheckBoxes = true;
            lvConfirmList.View = View.Details;
            lvConfirmList.Columns.Add("ProductID", 120);
            lvConfirmList.Columns.Add("CustomerFactoryID", 120);
            lvConfirmList.Columns.Add("OrderID", 120);
            lvConfirmList.Columns.Add("OrderQuantity", 120);
            lvConfirmList.Columns.Add("OrderDate", 120);


            // Veritabanından verileri çekme
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerFactoryID,OrderID, ProductID, OrderQuantity, OrderDate, IsOrderConfirmed FROM ORDERS";
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
                    bool? IsOrderConfirmed = reader.IsDBNull(reader.GetOrdinal("IsOrderConfirmed")) ? (bool?)null : Convert.ToBoolean(reader["IsOrderConfirmed"]);

                    ListViewItem item = new ListViewItem(column1Value);
                    item.SubItems.Add(column2Value);
                    item.SubItems.Add(column5Value);
                    item.SubItems.Add(column3Value);
                    item.SubItems.Add(column4Value);
                    if (IsOrderConfirmed.HasValue)
                        item.Checked = IsOrderConfirmed.Value;

                    lvConfirmList.Items.Add(item);
                }

                reader.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvConfirmList.Items)
            {
                int orderId = int.Parse(item.SubItems[2].Text);
                bool IsOrderConfirmed = item.Checked;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE ORDERS SET IsOrderConfirmed = @IsOrderConfirmed WHERE OrderID = @OrderID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@IsOrderConfirmed", IsOrderConfirmed);
                        command.Parameters.AddWithValue("@OrderID", orderId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("başarılı");
                            OrderDetailsForm orderDetailsForm = new OrderDetailsForm(factoryId);
                            orderDetailsForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("başarısız");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
