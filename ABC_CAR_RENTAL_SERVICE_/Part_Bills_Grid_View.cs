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
    public partial class Part_Bills_Grid_View : Form
    {
        public Part_Bills_Grid_View()
        {
            InitializeComponent();
        }

        private void Part_Bills_Grid_View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_Car_Rental_ServiceDataSet10.CAR_pART_Bill_Details' table. You can move, or remove it, as needed.
            this.cAR_pART_Bill_DetailsTableAdapter.Fill(this.aBC_Car_Rental_ServiceDataSet10.CAR_pART_Bill_Details);

        }
    }
}
