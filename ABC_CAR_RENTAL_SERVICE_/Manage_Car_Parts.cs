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
    public partial class Manage_Car_Parts : Form
    {
        public Manage_Car_Parts()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtPartName.Text))
            {
                MessageBox.Show("Part Name is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPartPrice.Text))
            {
                MessageBox.Show("Price is required.");
                return;
            }
            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO CarParts (PartName,Price) VALUES (@PartName,  @Price)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PartName", txtPartName.Text);
                cmd.Parameters.AddWithValue("@Price", txtPartPrice.Text);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Part Details added Successfully!");
                     Car_Parts_Grid_View loginForm = new Car_Parts_Grid_View();
                     loginForm.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPartID.Text))
            {
                MessageBox.Show("Please select a Part to edit.");
                return;
            }

            
            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
               
                string query = "UPDATE CarParts SET PartName = @PartName, Price = @Price WHERE PartID = @PartID";
                SqlCommand cmd = new SqlCommand(query, con);

                
                cmd.Parameters.AddWithValue("@PartID", txtPartID.Text); 
                cmd.Parameters.AddWithValue("@PartName", txtPartName.Text);
                cmd.Parameters.AddWithValue("@Price", txtPartPrice.Text);


                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Car Details updated successfully!");
                        Car_Parts_Grid_View loginForm = new Car_Parts_Grid_View();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("No part found with the specified ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            int PartID;
            if (!int.TryParse(txtPartID.Text, out PartID))
            {
                MessageBox.Show("Please enter a valid Part ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var confirmResult = MessageBox.Show("Are you sure to delete this Part?",
                                      "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            
            string query = "DELETE FROM CarParts WHERE PartID = @PartID";


            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PartID", PartID);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Part details deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Car_Parts_Grid_View loginForm = new Car_Parts_Grid_View();
                            loginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Part ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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