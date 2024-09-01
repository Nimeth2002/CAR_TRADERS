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
    public partial class Manage_Customer : Form
    {
        public Manage_Customer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCUSTOMERID.Text))
            {
                MessageBox.Show("Please select Customer ID to edit.");
                return;
            }

            
            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
               
                string query = "UPDATE Customers SET Name = @Name, Email = @Email WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, con);

              
                cmd.Parameters.AddWithValue("@CustomerID", txtCUSTOMERID.Text); 
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);


                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer Details updated successfully!");
                       Customer_Grid_View loginForm = new Customer_Grid_View();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("No Customer found with the specified ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int CustomerID;
            if (!int.TryParse(txtCUSTOMERID.Text, out CustomerID))
            {
                MessageBox.Show("Please enter a valid Customer ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var confirmResult = MessageBox.Show("Are you sure to delete this Customer?",
                                      "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";


            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("CustomerID", CustomerID);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Part details deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Customer_Grid_View loginForm = new Customer_Grid_View();
                            loginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Customer ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Manage_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_Car_Rental_ServiceDataSet12.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.aBC_Car_Rental_ServiceDataSet12.Customers);

        }
    }
}