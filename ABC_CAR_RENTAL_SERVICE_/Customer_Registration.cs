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
using System.Net.Mail;


namespace ABC_CAR_RENTAL_SERVICE_
{
    public partial class Customer_Registration : Form
    {
        public Customer_Registration()
        {
            InitializeComponent();
            txtPasswordCustomer.PasswordChar = '*';

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPasswordCustomer.Text))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            if (txtPasswordCustomer.Text.Length < 6) 
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Customers (Name, Email, Password) VALUES (@Name, @Email,  @Password)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", txtPasswordCustomer.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}


