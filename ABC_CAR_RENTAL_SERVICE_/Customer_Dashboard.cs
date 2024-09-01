using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_CAR_RENTAL_SERVICE_
{
    public partial class Customer_Dashboard : Form
    {
        public Customer_Dashboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_Car loginForm = new Search_Car();
            loginForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search_Car_Parts loginForm = new Search_Car_Parts();
            loginForm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Car_Order loginForm = new Car_Order(); 
            loginForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car_parts_Orders loginForm = new Car_parts_Orders();
            loginForm.Show();
        }
    }
}
