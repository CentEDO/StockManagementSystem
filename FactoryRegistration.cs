﻿using System;
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
    public partial class FactoryRegistration : Form
    {
        private int FactoryID;
        public FactoryRegistration(int getFactoryID)
        {
            FactoryID = getFactoryID;
            InitializeComponent();
        }
        public FactoryRegistration()
        {
            
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VPMidterm;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if (rdbtnManufacturer.Checked)
                {
                    string email = msktxtEmail.Text.Trim();
                    string selectQuery = "SELECT COUNT(*) FROM MANUFACTURING_FACTORIES WHERE FactoryEmail = @Email";
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@Email", email);
                        int emailCount = (int)selectCommand.ExecuteScalar();
                        if (emailCount > 0)
                        {
                            MessageBox.Show("This email is already registered! Please try again with a different email.");
                            return;
                        }
                    }
                    string insertQuery = "INSERT INTO MANUFACTURING_FACTORIES (FactoryName, FactoryLocation, FactoryEmail, FactoryPassword) " +
                                         "VALUES (@name, @location, @email, @password)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtboxFactoryName.Text);
                        command.Parameters.AddWithValue("@location", ddlCountries.Text);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration completed!");
                        NavigationForm navigationForm = new NavigationForm(FactoryID);
                        navigationForm.Show();
                        this.Hide();
                    }
                }
                if (rdnbtnCustomer.Checked)
                {
                    string email = msktxtEmail.Text.Trim();
                    string selectQuery = "SELECT COUNT(*) FROM CUSTOMER_FACTORIES WHERE CustomerFactoryEmail = @Email";
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@Email", email);
                        int emailCount = (int)selectCommand.ExecuteScalar();
                        if (emailCount > 0)
                        {
                            MessageBox.Show("This email is already registered! Please try again with a different email.");
                            return;
                        }
                    }
                    string insertQuery = "INSERT INTO CUSTOMER_FACTORIES (CustomerFactoryName, CustomerFactoryLocation, CustomerFactoryEmail, CustomerFactoryPassword) " +
                                         "VALUES (@name, @location, @email, @password)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtboxFactoryName.Text);
                        command.Parameters.AddWithValue("@location", ddlCountries.Text);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration completed!");
                        CustomerNavigationForm customerNavigationForm = new CustomerNavigationForm(FactoryID);
                        customerNavigationForm.Show();
                        this.Hide();
                    }
                }
            }
        }

    }
}
