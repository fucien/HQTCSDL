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
    public partial class TxForm : UserControl
    {
        public TxForm()
        {
            InitializeComponent();
        }

        private void DkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new LoginControl());
        }
    }
}
