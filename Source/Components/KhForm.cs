using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQTCSDL_G6.DatabaseManager;

namespace HQTCSDL_G6.Components
{
    public partial class KhForm : UserControl
    {
        public KhForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void ReBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseManager.DBManager.SignupKH("nhet ten may cai table vo day");

            MessageBox.Show("Đăng ký thành công!");
            this.Parent.Controls.Add(new LoginControl());
        }
    }
}
