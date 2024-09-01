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
    public partial class Car_parts_Orders : Form
    {
        public Car_parts_Orders()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderCar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtEMAIL.Text))
            {
                MessageBox.Show("Email is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPHONENUMBER.Text))
            { 
                MessageBox.Show("Phone number is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCarPart.Text))
            {
                MessageBox.Show("Car Part is required.");
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
                string query = "INSERT INTO CAR_pART_Bill_Details (Email,PhoneNumber,PartName,BillDate) VALUES (@Email,@PhoneNumber,@PartName,@BillDate)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Email", txtEMAIL.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPHONENUMBER.Text);
                cmd.Parameters.AddWithValue("@PartName", txtCarPart.Text);
                cmd.Parameters.AddWithValue("@BillDate", txtDATE.Value);


                try
                {
                    cmd.ExecuteNonQuery();
                    string message = $"Order Placed Successfully !!!\n\nEmail: {txtEMAIL.Text}\nPhone number: {txtPHONENUMBER.Text}\nPart Name: {txtCarPart.Text}\nBill Date : {txtDATE.Text}";
                    MessageBox.Show(message, "Order Confirmation");

               
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred generating Bill: {ex.Message}"); 
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
