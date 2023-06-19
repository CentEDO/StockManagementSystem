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
        private int factoryID;
        public NavigationForm(int getFactoryID)
        {
            factoryID = getFactoryID;
            InitializeComponent();
        }
        public NavigationForm()
        {
            InitializeComponent();
        }
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseList warehouseList = new WarehouseList(factoryID);
            warehouseList.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductList ProductList = new ProductList(factoryID);
            ProductList.Show();
            this.Hide();
        }

        

        private void btnCustomerFactories_Click(object sender, EventArgs e)
        {
            CustomerFactoriesList customerFactoriesList = new CustomerFactoriesList(factoryID);
            customerFactoriesList.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            RecentOrdersForm recentOrdersForm = new RecentOrdersForm(factoryID);
            recentOrdersForm.Show();
            this.Hide();
        }

        

        private void NavigationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            AddWarehouseForm addWarehouseForm = new AddWarehouseForm(factoryID);
            addWarehouseForm.Show();
            this.Hide();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductAddingForm productAddingForm = new ProductAddingForm(factoryID);
            productAddingForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            credit.Show();
            this.Hide();
        }

        private void btnOrderConfirmation_Click(object sender, EventArgs e)
        {
            ConfirmOrderForm confirmOrderForm = new ConfirmOrderForm(factoryID);
            confirmOrderForm.Show();
            this.Hide();
        }

        private void btnOrderConfirmation_Click_1(object sender, EventArgs e)
        {
            ConfirmOrderForm confirmOrderForm = new ConfirmOrderForm(factoryID);
            confirmOrderForm.Show();
            this.Hide();
        }
        
    }
}
