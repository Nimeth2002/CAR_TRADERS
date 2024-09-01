using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABC_CAR_RENTAL_SERVICE_
{
    public partial class Customer_Login : Form
    {
        public Customer_Login()
        {
            InitializeComponent();
            txtPasswordC.PasswordChar = '*';
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Customer_Registration loginForm = new Customer_Registration();
            loginForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsernameC.Text) || string.IsNullOrWhiteSpace(txtPasswordC.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return; 
            }
            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    
                    string query = "SELECT Name,Password FROM Customers WHERE Name = @Name AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    
                    cmd.Parameters.AddWithValue("@Name", txtUsernameC.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPasswordC.Text);

                    
                    cn.Open();

                    
                    SqlDataReader dr = cmd.ExecuteReader();

                    
                    if (dr.Read())
                    {
                        MessageBox.Show("Login Succeeded!");
                        Customer_Dashboard loginForm = new Customer_Dashboard();
                        loginForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password!");
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
