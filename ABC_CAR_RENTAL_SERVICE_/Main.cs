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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Login loginForm = new Admin_Login();
            loginForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Login loginForm = new Customer_Login();
            loginForm.Show();
        }
    }
}
