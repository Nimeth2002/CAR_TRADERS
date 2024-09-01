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
    public partial class Manage_Orders_Dashboard : Form
    {
        public Manage_Orders_Dashboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manage_Car_Orders loginForm = new Manage_Car_Orders();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Part_Orders loginForm = new Manage_Part_Orders();
            loginForm.Show();

        }
    }
}
