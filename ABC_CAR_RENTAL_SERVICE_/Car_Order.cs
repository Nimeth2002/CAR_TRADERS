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
    public partial class Car_Order : Form
    {
        public Car_Order()
        {
            InitializeComponent();
        }

        private void btnOrderCar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Phone number is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMoDEL.Text))
            {
                MessageBox.Show("Name/Model is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDATE.Text))
            {
                MessageBox.Show("Date is required.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Car_Bill_Details (Email, PhoneNumber,Car_Model_Name,BillDate) VALUES (@Email,  @PhoneNumber, @Car_Model_Name,@BillDate)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Car_Model_Name", txtMoDEL.Text);
                cmd.Parameters.AddWithValue("@Model", txtMoDEL.Text);
                cmd.Parameters.AddWithValue("@BillDate", txtDATE.Value);


                try
                {
                    cmd.ExecuteNonQuery();
                    string message = $"Order Placed Successfully !\n\nEmail: {txtEmail.Text}\nPhone number: {txtPhoneNumber.Text}\nModel/Name: {txtMoDEL.Text}\nDate : {txtDATE.Text}";
                    MessageBox.Show(message, "Order Confirmation");

                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred Generating Bill: {ex.Message}");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}