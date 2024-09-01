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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manage_Cars loginForm = new Manage_Cars();
            loginForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manage_Car_Parts loginForm = new Manage_Car_Parts();
            loginForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Customer loginForm = new Manage_Customer();
            loginForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Orders_Dashboard loginForm = new Manage_Orders_Dashboard();
            loginForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports loginForm = new Reports();
            loginForm.Show();
        }
    }
}
