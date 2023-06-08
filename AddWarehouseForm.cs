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
    public partial class AddWarehouseForm : Form
    {
        private int factoryID;
        public AddWarehouseForm(int getFactoryID)
        {
            InitializeComponent();
            factoryID = getFactoryID;
            
        }


        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;");


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string getName = txtWarehouseName.Text;
            string getCountry = txtWarehouseAddress.Text;

            con.Open();
            SqlCommand command = new SqlCommand("INSERT into Warehouses(WarehouseName, FactoryID,  WarehouseLocation)" + "VALUES('" + getName + "', '" + factoryID + "','" + getCountry + "')", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully.");
        }
        private void btnBackNavigationForm_Click(object sender, EventArgs e)
        {
            NavigationForm  navigationForm= new NavigationForm(factoryID);
            navigationForm.Show();
            this.Hide();
        }

        
    }

}
