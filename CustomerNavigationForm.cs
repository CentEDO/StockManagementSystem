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
    public partial class CustomerNavigationForm : Form
    {
        private int factoryID;
        public CustomerNavigationForm(int getFactoryID)
        {
            factoryID = getFactoryID;
            InitializeComponent();
        }
        public CustomerNavigationForm()
        {
            InitializeComponent();
        }
        private void btnManufacturerList_Click(object sender, EventArgs e)
        {
            ManufacturerFactoriesList manufacturerFactoriesList = new ManufacturerFactoriesList(factoryID);
            manufacturerFactoriesList.Show();
            this.Hide();
        }

        private void btnGoOrderList_Click(object sender, EventArgs e)
        {
            RecentOrdersForm recentOrdersForm = new RecentOrdersForm(factoryID);
            recentOrdersForm.Show();
            this.Hide();
        }

        private void btnGoOrder_Click(object sender, EventArgs e)
        {
            OrderProductForm orderProductForm = new OrderProductForm(factoryID);
            orderProductForm.Show();
            this.Hide();
        }

        

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
