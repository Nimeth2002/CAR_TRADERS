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
    public partial class Manage_Cars : Form
    {
        public Manage_Cars()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Car Model is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                MessageBox.Show("Car Make is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show("Year is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price is required.");
                return;
            }
            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Cars (Model, Make,Year,Price) VALUES (@Model,  @Make, @Year, @Price)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Make", txtMake.Text);
                cmd.Parameters.AddWithValue("@Year", txtMake.Text);
                cmd.Parameters.AddWithValue("@Price", txtMake.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Details added Successfully!");
                    Cars_Grid_View loginForm = new Cars_Grid_View();
                    loginForm.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardID.Text))
            {
                MessageBox.Show("Please select a car to edit.");
                return;
            }

            
            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                
                string query = "UPDATE Cars SET Model = @Model, Make = @Make, Year = @Year, Price = @Price WHERE CarID = @CarID";
                SqlCommand cmd = new SqlCommand(query, con);

                
                cmd.Parameters.AddWithValue("@CarID", txtCardID.Text); 
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Make", txtMake.Text);
                cmd.Parameters.AddWithValue("@Year", txtYear.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Car Details updated successfully!");
                        Cars_Grid_View loginForm = new Cars_Grid_View();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("No car found with the specified ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void txtCardID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int carId;
            if (!int.TryParse(txtCardID.Text, out carId))
            {
                MessageBox.Show("Please enter a valid Car ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            var confirmResult = MessageBox.Show("Are you sure to delete this car?",
                                      "Confirm Delete",  
                                     MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            
            string query = "DELETE FROM Cars WHERE CarID = @CarID";


            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarID", carId);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Car details deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cars_Grid_View loginForm = new Cars_Grid_View();
                            loginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Car ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}