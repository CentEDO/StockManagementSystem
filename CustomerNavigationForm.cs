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
        private int FactoryID;
        public CustomerNavigationForm(int getFactoryID)
        {
            FactoryID = getFactoryID;
            InitializeComponent();
        }

        private void btnManufacturerList_Click(object sender, EventArgs e)
        {
            ManufacturerFactoriesList manufacturerFactoriesList = new ManufacturerFactoriesList(FactoryID);
            manufacturerFactoriesList.Show();
            this.Hide();
        }

        private void btnGoOrderList_Click(object sender, EventArgs e)
        {
            RecentOrdersForm recentOrdersForm = new RecentOrdersForm(FactoryID);
            recentOrdersForm.Show();
            this.Hide();
        }

        private void btnGoOrder_Click(object sender, EventArgs e)
        {
            OrderProductForm orderProductForm = new OrderProductForm(FactoryID);
            orderProductForm.Show();
            this.Hide();
        }
    }
}
