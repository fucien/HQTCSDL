﻿using System;
using HQTCSDL_G6.DatabaseManager;
using System.Windows.Forms;
using HQTCSDL_G6.Components.PartnerControls;
using HQTCSDL_G6.Components.CustomerControl;
using HQTCSDL_G6.Components.ShipperControl;
using HQTCSDL_G6.Components.AdminControl;
using HQTCSDL_G6.Components.EmployeeControl;
using HQTCSDL_G6.Components;
using HQTCSDL_G6.Components.EmployeeControl;

namespace HQTCSDL_G6
{
    public partial class ErrorVersionForm : Form
    {
        private UserControl currentControl;


        public ErrorVersionForm()
        {
            InitializeComponent();
            loginControl.OnLogin += (loginInfor) =>
            {
                var Name = loginInfor.Name;
                var currentID = loginInfor.ID;
                if (loginInfor.Type == "DT")
                {
                    currentControl = new PartnerControl(currentID, true);
                    currentFunctionLabel.Text = "Đối tác: " + Name;
                }
                else if (loginInfor.Type == "KH")
                {
                    currentControl = new CustomerControl(currentID, true);
                    currentFunctionLabel.Text = "Khách hàng: " + Name;
                }
                else if (loginInfor.Type == "TX")
                {
                    currentControl = new ShipperControl(currentID, true);
                    currentFunctionLabel.Text = "Tài xế: " + Name;
                }
                else if (loginInfor.Type == "AD")
                {
                    currentControl = new AdminControl(currentID, true);
                    currentFunctionLabel.Text = "Quản lý: " + Name;
                }
                else if (loginInfor.Type == "NV")
                {
                    currentControl = new EmployeeControl(currentID, true);
                    currentFunctionLabel.Text = "Nhân viên: " + Name;
                }
                currentFunctionPanel.Controls.Add(currentControl);
                currentControl.Dock = DockStyle.Fill;
                (currentControl as IDelay).SetDelay(TimeSpan.FromSeconds((double)delayTimeNumeric.Value));
                functionsPanel.Visible = true;
                functionsPanel.BringToFront();
            };

            delayTimeNumeric.ValueChanged += (s, e) =>
            {
                if (currentControl is IDelay delay)
                    delay.SetDelay(TimeSpan.FromSeconds((double)delayTimeNumeric.Value));
            };
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentControl != null)
                {
                    currentFunctionPanel.Controls.Remove(currentControl);
                    currentControl.Dispose();
                    currentControl = null;
                }

                functionsPanel.Visible = false;
                loginControl.Visible = true;
                loginControl.BringToFront();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}