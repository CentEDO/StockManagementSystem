using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPMidterm
{
    public partial class NavigationForm : Form
    {
        private int FactoryID;
        public NavigationForm(int getFactoryID)
        {
            FactoryID = getFactoryID;
            InitializeComponent();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseList warehouseList = new WarehouseList(FactoryID);
            warehouseList.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductList ProductList = new ProductList(FactoryID);
            ProductList.Show();
            this.Hide();
        }

        private void btnManufacturerFactory_Click(object sender, EventArgs e)
        {
            ManufacturerFactoriesList manufacturerFactoriesList = new ManufacturerFactoriesList(FactoryID);
            manufacturerFactoriesList.Show();
            this.Hide();
        }

        private void btnCustomerFactories_Click(object sender, EventArgs e)
        {
            CustomerFactoriesList customerFactoriesList = new CustomerFactoriesList(FactoryID);
            customerFactoriesList.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            RecentOrdersForm recentOrdersForm = new RecentOrdersForm(FactoryID);
            recentOrdersForm.Show();
            this.Hide();
        }
    }
}
