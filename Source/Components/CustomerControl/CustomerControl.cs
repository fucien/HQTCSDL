﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_G6.Components.CustomerControl
{
    public partial class CustomerControl : UserControl, IDelay
    {
        public CustomerControl(int id, bool error)
        {
            InitializeComponent();

            createOrderControl.CurrentID = id;
            createOrderControl.Error = error;

            customerViewOrderControl.CurrentID = id;
            customerViewOrderControl.Error = error;

            customerOrderStatisticsControl.CurrentID = id;
            customerOrderStatisticsControl.Error = error;
        }

        public void SetDelay(TimeSpan delay)
        {
            customerViewOrderControl.CurrentDelay = delay;
            createOrderControl.CurrentDelay = delay;
            customerOrderStatisticsControl.CurrentDelay = delay;
        }

        private void createOrderControl_Load(object sender, EventArgs e)
        {

        }

        private void customerOrderStatisticsControl_Load(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }
    }
}
