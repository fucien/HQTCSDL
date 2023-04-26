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
    public partial class DtForm : UserControl
    {
        public DtForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // add to database
            DBManager.Init.SignupDT(TkTbx.Text, MkTbx.Text, ChTbx.Text, HtTbx.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, SdtBtn.Text, ETbx.Text);
            MessageBox.Show("Đăng ký thành công!");
            this.Parent.Controls.Add(new LoginControl());
        }

        private void TkTbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
