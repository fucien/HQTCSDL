using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQTCSDL_G6.Components
{
    public partial class RegisterForm : UserControl
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void TxBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new TxForm());
        }

        private void KhBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new KhForm());
        }

        private void DtBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new DtForm());
        }
    }
}
