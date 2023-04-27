using HQTCSDL_G6.Components;
using HQTCSDL_G6.DatabaseManager;
using HQTCSDL_G6.DatabaseManager.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQTCSDL_G6.Components.EmployeeControl
{
    public partial class EmployeeControl : UserControl, IDelay
    {
        public int CurrentID { get; internal set; }

        public bool Error { get; set; } = false;

        public TimeSpan CurrentDelay { get; set; }



        public EmployeeControl(int id, bool error)
        {
            InitializeComponent();
            load();
            load1();

            CurrentID = id;
            Error = error;

        }
        public EmployeeControl()
        {
            InitializeComponent();
        }

        void load()
        {
            dataGridView1.DataSource = DBManager.Init.Employee.GetActiveHD();
        }

        void load1()
        {

            dataGridView2.DataSource = DBManager.Init.Employee.GetInactiveHD();
        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            load();
            load1();
        }

        private void GuiBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NummTbx.Text);
            DBManager.Init.Employee.SendNotification(num);
            load();
            load1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            NummTbx.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            NumTbx.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void AccBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumTbx.Text);
            DBManager.Init.Employee.AcceptHD(num);
            load();
            load1();
        }

        private void RejBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumTbx.Text);
            DBManager.Init.Employee.RejectHD(num);
            load();
            load1();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        public void SetDelay(TimeSpan delay)
        {
            CurrentDelay = delay;
        }

        private void NumTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
