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
    public partial class ProductAddingForm : Form
    {
        private int factoryID;
        public ProductAddingForm(int getFactoryID)
        {
            factoryID = getFactoryID;
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;");

        



        private void ProductAddingForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commandName = new SqlCommand("SELECT WarehouseName FROM WAREHOUSES Where FactoryID = @factoryID", connection);
            commandName.Parameters.AddWithValue("@factoryID", factoryID);
            SqlDataAdapter adapter = new SqlDataAdapter(commandName);

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            cmbboxWarehouse.DisplayMember = "WarehouseName";
            cmbboxWarehouse.DataSource = datatable;
            connection.Close();
        }

        private void btnBackToNavForm_Click(object sender, EventArgs e)
        {
            NavigationForm navigationForm = new NavigationForm(factoryID);
            navigationForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string getName = txtProductName.Text;
            string getStockAmount = txtStockAmount.Text;
            string getWarehouseName = cmbboxWarehouse.Text;
            string getDesc = cmbboxWarehouse.Text;
            string getPrice = txtPrice.Text;

            connection.Open();
            SqlCommand commanWarehouseID = new SqlCommand("SELECT WarehouseID FROM Warehouses WHERE WarehouseName = @WarehouseName", connection);
            commanWarehouseID.Parameters.AddWithValue("@WarehouseName", getWarehouseName);
            int getWarehouseID = (int)commanWarehouseID.ExecuteScalar();

            SqlCommand commandSelect = new SqlCommand("SELECT COUNT(*) FROM Products WHERE ProductName = @Name AND WarehouseID = @WarehouseID", connection);
            commandSelect.Parameters.AddWithValue("@Name", getName);
            commandSelect.Parameters.AddWithValue("@WarehouseID", getWarehouseID);
            int count = (int)commandSelect.ExecuteScalar();

            if (count > 0)
            {
                SqlCommand commandUpdate = new SqlCommand("UPDATE Products SET ProductStockAmount = ProductStockAmount + @Amount WHERE ProductName = @Name AND WarehouseID = @WarehouseID", connection);
                commandUpdate.Parameters.AddWithValue("@Amount", getStockAmount);
                commandUpdate.Parameters.AddWithValue("@Name", getName);
                commandUpdate.Parameters.AddWithValue("@WarehouseID", getWarehouseID);
                commandUpdate.ExecuteNonQuery();
                MessageBox.Show("Updated successfully.");
            }
            else
            {
                SqlCommand commandInsert = new SqlCommand("INSERT into Products(ProductName,ProductPrice, FactoryID, ProductDescription, ProductStockAmount, WarehouseID)" + "VALUES('" + getName + "', '" + getPrice + "', '" + factoryID + "',  '" + getDesc + "','" + getStockAmount + "', '" + getWarehouseID + "')", connection);
                commandInsert.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Added successfully.");
            }
        }
    }
}
