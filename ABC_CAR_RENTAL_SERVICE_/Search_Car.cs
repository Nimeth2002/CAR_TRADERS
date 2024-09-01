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
    public partial class Search_Car : Form
    {
        public Search_Car()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string model = txtModelName.Text;
            

           
            string query = "SELECT Model,CarID,Make,Year,Price FROM Cars WHERE 1=1";

            if (!string.IsNullOrEmpty(model))
                query += " AND Model = @Model";
           

            
            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";

            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    if (!string.IsNullOrEmpty(model))
                    {
                        cmd.Parameters.Add("@Model", SqlDbType.VarChar).Value = model;
                    } 

                    con.Open();

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable results = new DataTable();
                    adapter.Fill(results);

                    if (results.Rows.Count == 0)
                    {
                        
                        MessageBox.Show("No cars found matching the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                       
                        SearchCar.DataSource = results; 
                    }
                }
            }
        }

        private void Search_Car_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_Car_Rental_ServiceDataSet3.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.aBC_Car_Rental_ServiceDataSet3.Cars);

        }
    }
}
