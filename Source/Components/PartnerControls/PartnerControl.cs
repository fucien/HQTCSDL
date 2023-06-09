﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_G6.Components.PartnerControls
{
    public partial class PartnerControl : UserControl, IDelay
    {
        public PartnerControl(int id, bool error)
        {
            InitializeComponent();
            extendContractControl.CurrentID = id;
            extendContractControl.Error = error;

            viewContractControl.CurrentID = id;
            addProductControl.CurrentID = id;
            deleteProductControl.CurrentID = id;
            updateProductControl.CurrentID = id;

            updateProductAmountControl.CurrentID = id;
            updateProductAmountControl.Error = error;

            partnerViewOrderControl.CurrentID = id;

            partnerStatisticsControl.CurrentID = id;
            partnerStatisticsControl.Error = error;
        }

        public void SetDelay(TimeSpan delay)
        {
            extendContractControl.CurrentDelay = delay;
            updateProductAmountControl.CurrentDelay = delay;
            partnerStatisticsControl.CurrentDelay = delay;
        }

        private void extendContractControl_Load(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }

        private void viewContractControl_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CCBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
