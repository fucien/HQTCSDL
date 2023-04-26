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
    public partial class TxForm : UserControl
    {
        public TxForm()
        {
            InitializeComponent();
        }

        private void DkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // add to database

            DatabaseManager.DBManager.Init.SignupTX(TkTbx.Text, MkTbx.Text, HtTbx.Text, CmndTbx.Text, SdtBtn.Text, BsxTbx.Text, KvTbx.Text, ETbx.Text, BTbx.Text);
            MessageBox.Show("Đăng ký thành công!");
            this.Parent.Controls.Add(new LoginControl());
        }
    }
}
