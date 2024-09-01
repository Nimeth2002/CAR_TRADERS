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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return; 
            }
            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    
                    string query = "SELECT Username, Password FROM Admin_Login WHERE Username = @Username AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    
                    cn.Open();

                    
                    SqlDataReader dr = cmd.ExecuteReader();

                    
                    if (dr.Read())
                    {
                        MessageBox.Show("Login Succeeded!");
                        Admin_Panel loginForm = new Admin_Panel();
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