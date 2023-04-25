using HQTCSDL_G6.DatabaseManager;
using HQTCSDL_G6.DatabaseManager.DTOs;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HQTCSDL_G6.Components.AdminControl
{


    public partial class AdminControl : UserControl, IDelay
    {
        public int CurrentID { get; internal set; }

        public bool Error { get; set; } = false;
        public TimeSpan CurrentDelay { get; set; }

        public AdminControl(int id, bool error)
        {
            InitializeComponent();

            CurrentID = id;
            Error = error;

        }
        void load()
        {
            string table;
            switch (Cbx.Text)
            {
                case "Admin":
                    table = "Admin";
                    break;
                case "Nhân Viên":
                    table = "NhanVien";
                    break;
                case "Đối Tác":
                    table = "DoiTac";
                    break;
                case "Khách Hàng":
                    table = "KhachHang";
                    break;
                case "Tài Xế":
                    table = "TaiXe";
                    break;
                default:
                    table = "Admin";
                    break;
            }
            dataGridView1.DataSource = DatabaseManager.DBManager.Init.Admin.GetAccount();
            dataGridView2.DataSource = DatabaseManager.DBManager.Init.Admin.GetAccount();
            dataGridView3.DataSource = DatabaseManager.DBManager.Init.Admin.GetTable(table);
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            AccTbx.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            PassTbx.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            RoleCbx.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string acc = AccTbx.Text;
            string pass = PassTbx.Text;
            string role = RoleCbx.Text;

            DatabaseManager.DBManager.Init.Admin.AddAccount(acc, pass, role);

            load();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string acc = AccTbx.Text;
            DatabaseManager.DBManager.Init.Admin.DeleteAccount(acc);

            load();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string acc = AccTbx.Text;
            string pass = PassTbx.Text;
            DatabaseManager.DBManager.Init.Admin.UpdateAccount(pass, acc);

            load();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            SttDATbx.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
        }

        private void DeBtn_Click(object sender, EventArgs e)
        {
            string username = AccTbx.Text;
            DatabaseManager.DBManager.Init.Admin.LockAccount(username);

            load();

        }

        private void AcBtn_Click(object sender, EventArgs e)
        {
            string username = AccTbx.Text;
            DatabaseManager.DBManager.Init.Admin.UnlockAccount(username);

            load();

        }

        public void SetDelay(TimeSpan delay)
        {
            CurrentDelay = delay;
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            AccTbx.Text = "";
            PassTbx.Text = "";
            RoleCbx.Text = "";
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            string table;
            switch (Cbx.Text)
            {
                case "Admin":
                    table = "Admin";
                    break;
                case "Nhân Viên":
                    table = "NhanVien";
                    break;
                case "Đối Tác":
                    table = "DoiTac";
                    break;
                case "Khách Hàng":
                    table = "KhachHang";
                    break;
                case "Tài Xế":
                    table = "TaiXe";
                    break;
                default:
                    table = "Admin";
                    break;
            }
            dataGridView3.DataSource = DatabaseManager.DBManager.Init.Admin.GetTable(table);
        }
    }
}
