using HQTCSDL_G6.DatabaseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_G6.Components
{
    public partial class LoginControl : UserControl
    {
        public event System.Action<AccountTypeWithID> OnLogin;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(accountTb.Text)
               || String.IsNullOrWhiteSpace(passwordTb.Text))
            {
                MessageBox.Show("Tài khoản và mặt khẩu không được để trông!");
                return;
            }
            var loginInfor = DBManager.Init.Login(accountTb.Text, passwordTb.Text);
            if (loginInfor == null)
                MessageBox.Show("Đăng nhập thất bại, hãy xem lại các thông tin!");
            else
            {
                OnLogin?.Invoke(loginInfor);
                this.Visible = false;
            }
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new RegisterForm());
        }
    }
}
