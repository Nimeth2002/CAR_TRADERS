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
    public partial class Search_Car_Parts : Form
    {
        public Search_Car_Parts()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Car_Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_Car_Rental_ServiceDataSet4.CarParts' table. You can move, or remove it, as needed.
            this.carPartsTableAdapter.Fill(this.aBC_Car_Rental_ServiceDataSet4.CarParts);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            string PartName = txtCARPARTS.Text;


           
            string query = "SELECT PartID, PartName ,Price FROM CarParts WHERE 1=1";

            
            if (!string.IsNullOrEmpty(PartName))
                query += " AND PartName = @PartName";

          
            string connectionString = @"Data Source=DESKTOP-K5LPK1E\SQLEXPRESS;Initial Catalog=ABC_Car_Rental_Service;Integrated Security=True";

            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    if (!string.IsNullOrEmpty(PartName))
                        cmd.Parameters.AddWithValue("@PartName", PartName);


                    
                    con.Open();

              
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable results = new DataTable();
                    adapter.Fill(results);

                    if (results.Rows.Count == 0)
                    {
                     
                        MessageBox.Show("No Part found matching the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        
                        SearchPart.DataSource = results;
                    }
                }
            }
        }
    }
}
    