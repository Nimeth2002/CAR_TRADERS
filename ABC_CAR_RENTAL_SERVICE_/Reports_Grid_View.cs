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
    public partial class Reports_Grid_View : Form
    {
        public Reports_Grid_View()
        {
            InitializeComponent();
        }

        private void Reports_Grid_View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_Car_Rental_ServiceDataSet11.Reports' table. You can move, or remove it, as needed.
            this.reportsTableAdapter.Fill(this.aBC_Car_Rental_ServiceDataSet11.Reports);

        }
    }
}
