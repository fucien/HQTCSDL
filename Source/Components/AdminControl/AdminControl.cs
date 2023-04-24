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
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        //string query = "Data Source=LAPTOP-KSF5NDFT\SQLEXPRESS01;Initial Catalog=CHUYEN_HANG_ONLINE;User ID=QTV1; Password=QTV1;Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;MultiSubnetFailover=False";
        public TimeSpan CurrentDelay { get; set; }

        public AdminControl(int id, bool error)
        {
            InitializeComponent();

            CurrentID = id;
            Error = error;

            //customerViewOrderControl.CurrentID = id;
            //customerViewOrderControl.Error = error;

            //customerOrderStatisticsControl.CurrentID = id;
            //customerOrderStatisticsControl.Error = error;
        }
        void load()
        {
            dataGridView1.DataSource = DatabaseManager.DBManager.Init.Admin.GetAccount();
            dataGridView2.DataSource = DatabaseManager.DBManager.Init.Admin.GetAccount();
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
            MessageBox.Show("Thêm thành công");
            load();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string acc = AccTbx.Text;
            DatabaseManager.DBManager.Init.Admin.DeleteAccount(acc);
            MessageBox.Show("Xóa thành công");
            load();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string acc = AccTbx.Text;
            string pass = PassTbx.Text;
            DatabaseManager.DBManager.Init.Admin.UpdateAccount(pass, acc);

            MessageBox.Show("Sửa thành công");
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
            MessageBox.Show("Khóa thành công");
        }

        private void AcBtn_Click(object sender, EventArgs e)
        {
            string username = AccTbx.Text;
            DatabaseManager.DBManager.Init.Admin.UnlockAccount(username);
            MessageBox.Show("Mở khóa thành công");
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
    }
}
