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
        private int FactoryID;
        public WarehouseList(int getFactoryID)
        {
            FactoryID = getFactoryID;
            InitializeComponent();
        }
      

        private void WarehouseList_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT WAREHOUSES.WarehouseID, WAREHOUSES.WarehouseName, WAREHOUSES.WarehouseLocation, MANUFACTURING_FACTORIES.FactoryName, WAREHOUSES.FactoryID FROM WAREHOUSES INNER JOIN MANUFACTURING_FACTORIES ON WAREHOUSES.FactoryID = MANUFACTURING_FACTORIES.FactoryID WHERE MANUFACTURING_FACTORIES.FactoryID=  " + FactoryID;


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    gvWarehouses.DataSource = dataTable;
                    gvWarehouses.Columns["WarehouseID"].Visible = false;



                }
            }
        }

        private void btnBackNavForm_Click(object sender, EventArgs e)
        {
            NavigationForm navigationForm = new NavigationForm(FactoryID);
            navigationForm.Show();
            this.Hide();
        }
    }
}
