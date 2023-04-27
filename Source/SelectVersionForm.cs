using System;
using System.Windows.Forms;
using System.Threading;

namespace HQTCSDL_G6
{
    public partial class SelectVersionForm : Form
    {
        public SelectVersionForm()
        {
            InitializeComponent();
        }

        private void errorVersionButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                new ErrorVersionForm().ShowDialog();
            });
            thread.Start();
        }

        private void fixVersionButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                new FixVersionForm().ShowDialog();
            });
            thread.Start();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Thread thread = new Thread(() =>
                {
                    new ErrorVersionForm().ShowDialog();
                });
                thread.Start();
            }
            else if (radioButton2.Checked)
            {
                Thread thread = new Thread(() =>
                {
                    new FixVersionForm().ShowDialog();
                });
                thread.Start();
            }
        }
    }
}
