﻿using System;
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
    public partial class Car_Bills_Grid_View : Form
    {
        public Car_Bills_Grid_View()
        {
            InitializeComponent();
        }

        private void Car_Bills_Grid_View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_Car_Rental_ServiceDataSet6.Car_Bill_Details' table. You can move, or remove it, as needed.
            this.car_Bill_DetailsTableAdapter.Fill(this.aBC_Car_Rental_ServiceDataSet6.Car_Bill_Details);

        }
    }
}
