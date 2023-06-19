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
    public partial class CargoDeliveryForm : Form
    {
        private int factoryId;
        public CargoDeliveryForm(int getFactoryId)
        {
            factoryId = getFactoryId;
            InitializeComponent();
        }

        private void btnNavigationPage_Click(object sender, EventArgs e)
        {
            NavigationForm navigationForm = new NavigationForm(factoryId);
            navigationForm.Show();
            this.Hide();
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";

        private void CargoDeliveryForm_Load(object sender, EventArgs e)
        {
            lvCargoDelivery.CheckBoxes = true;
            lvCargoDelivery.View = View.Details;
            lvCargoDelivery.Columns.Add("ProductID", 120);
            lvCargoDelivery.Columns.Add("CustomerID", 120);
            lvCargoDelivery.Columns.Add("OrderID", 120);
            lvCargoDelivery.Columns.Add("OrderQuantity", 120);
            lvCargoDelivery.Columns.Add("OrderDate", 120);
            lvCargoDelivery.Columns.Add("Name", 120);
            lvCargoDelivery.Columns.Add("ActualArrivalDate", 120);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT  REPORTS.Name, Reports.ActualArrivalDate, ORDERS.CustomerFactoryID,ORDERS.OrderID, ORDERS.ProductID, ORDERS.OrderQuantity, ORDERS.OrderDate, ORDERS.IsArrived FROM ORDERS JOIN Reports ON ORDERS.OrderID=Reports.OrderID ";
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
                    string column6Value = reader["Name"].ToString();
                    string column7Value = reader["ActualArrivalDate"].ToString();

                    bool? IsArrived = reader.IsDBNull(reader.GetOrdinal("IsArrived")) ? (bool?)null : Convert.ToBoolean(reader["IsArrived"]);

                    ListViewItem item = new ListViewItem(column1Value);
                    item.SubItems.Add(column2Value);
                    item.SubItems.Add(column5Value);
                    item.SubItems.Add(column3Value);
                    item.SubItems.Add(column4Value);
                    item.SubItems.Add(column6Value);
                    item.SubItems.Add(column7Value);

                    if (IsArrived.HasValue)
                        item.Checked = IsArrived.Value;

                    lvCargoDelivery.Items.Add(item);
                }

                reader.Close();
            }

            // ItemChecked olayını ListVie
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT  REPORTS.Name, Reports.ActualArrivalDate, ORDERS.CustomerFactoryID,ORDERS.OrderID, ORDERS.ProductID, ORDERS.OrderQuantity, ORDERS.OrderDate, ORDERS.IsArrived FROM ORDERS JOIN Reports ON ORDERS.OrderID=Reports.OrderID where Name LIKE @FilterText";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@FilterText", "%" + txtFilter.Text + "%");

                    SqlDataReader reader = command.ExecuteReader();

                    lvCargoDelivery.Items.Clear();

                    while (reader.Read())
                    {
                        string column1Value = reader["ProductID"].ToString();
                        string column2Value = reader["CustomerFactoryID"].ToString();
                        string column3Value = reader["OrderID"].ToString();
                        string column4Value = reader["OrderQuantity"].ToString();
                        string column5Value = reader["OrderDate"].ToString();
                        string column6Value = reader["Name"].ToString();
                        string column7Value = reader["ActualArrivalDate"].ToString();

                        ListViewItem item = new ListViewItem(column1Value);
                        item.SubItems.Add(column2Value);
                        item.SubItems.Add(column3Value);
                        item.SubItems.Add(column4Value);
                        item.SubItems.Add(column5Value);
                        item.SubItems.Add(column6Value);
                        item.SubItems.Add(column7Value);

                        lvCargoDelivery.Items.Add(item);
                    }

                    reader.Close();
                }

                connection.Close();
            }
        }


    }

}
