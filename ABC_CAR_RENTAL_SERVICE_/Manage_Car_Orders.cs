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
    public partial class Manage_Car_Orders : Form
    {
        public Manage_Car_Orders()
        {
            InitializeComponent();
        }

        private void Manage_Car_Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_Car_Rental_ServiceDataSet5.Car_Bill_Details' table. You can move, or remove it, as needed.
            this.car_Bill_DetailsTableAdapter.Fill(this.aBC_Car_Rental_ServiceDataSet5.Car_Bill_Details);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int BillID;
            if (!int.TryParse(txtBillID.Text, out BillID))
            {
                MessageBox.Show("Please enter a valid Bill ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var confirmResult = MessageBox.Show("Are you sure to delete this Order?",
                                      "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }


            string query = "DELETE FROM Car_Bill_Details WHERE BillID = @BillID";


            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("BillID", BillID);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Order details deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Car_Bills_Grid_View loginForm = new Car_Bills_Grid_View();
                            loginForm.Show();

                        }
                        else
                        {
                            MessageBox.Show("Bill ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {

            string ID = txtBillID.Text;

            string query = "SELECT BillID,Email,PhoneNumber,Car_Model_Name,BillDate FROM Car_Bill_Details WHERE 1=1";


            if (!string.IsNullOrEmpty(ID))
            {
                query += " AND BillID = @BillID";
            }


            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    if (!string.IsNullOrEmpty(ID))
                    {
                        cmd.Parameters.AddWithValue("@BillID", ID);
                    }

                    con.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable results = new DataTable();
                        adapter.Fill(results);

                        if (results.Rows.Count == 0)
                        {
                            MessageBox.Show("No Bill Details found matching the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            CaOrders.DataSource = results;
                        }
                    }
                }
            }
        }
    }
} 