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
    public partial class WarehouseList : Form
    {
        private int factoryID;
        public WarehouseList(int getFactoryID)
        {
            factoryID = getFactoryID;
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;");

        private void WarehouseList_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commandWarehouse = new SqlCommand("SELECT WarehouseName, WarehouseLocation FROM Warehouses where FactoryID = @getFactoryID", connection);
            commandWarehouse.Parameters.AddWithValue("@getFactoryID", factoryID);

            SqlDataReader readerWarehouses = commandWarehouse.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(readerWarehouses);

            gvWarehouses.DataSource = dataTable;
        }

        private void btnBackNavForm_Click(object sender, EventArgs e)
        {
            NavigationForm navigationForm = new NavigationForm(factoryID);
            navigationForm.Show();
            this.Hide();
        }
    }
}
