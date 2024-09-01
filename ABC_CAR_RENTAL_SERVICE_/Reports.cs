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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtCarNamePart.Text))
            {
                MessageBox.Show("Car Name or Part  is required.");
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
            if (string.IsNullOrWhiteSpace(txtquantity.Text))
            {
                MessageBox.Show("Quantity is required.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Reports (CarModelNameorPart,Year,Price,QuantityAvailable) VALUES (@CarModelNameorPart, @Year,@Price,@QuantityAvailable)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CarModelNameorPart", txtCarNamePart.Text);
                cmd.Parameters.AddWithValue("@Year", txtYear.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@QuantityAvailable", txtquantity.Text);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Report Details added Successfully!");
                    //Car_Parts_Grid_View loginForm = new Car_Parts_Grid_View();
                    //loginForm.Show();
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