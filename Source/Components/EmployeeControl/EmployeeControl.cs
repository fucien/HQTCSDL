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

namespace HQTCSDL_Group01.Components.EmployeeControl
{
    public partial class EmployeeControl : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string query = "đường dẫn";

        public EmployeeControl()
        {
            InitializeComponent();
        }

        void load()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from /////"; // bản hợp đồng đã được duyệt
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        void load1()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from /////"; // bảng hợp đồng chưa được duyệt
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(query);
            connection.Open();
            load();
            load1();
        }

        private void GuiBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NummTbx.Text); // num là số thứ tự của hợp đồng
            command = connection.CreateCommand();
            command.CommandText = "update ///// set ///// = @num where ///// = @num"; // biến nhận thông báo/
            command.Parameters.AddWithValue("@num", num);
            command.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            NummTbx.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            NumTbx.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void AccBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumTbx.Text);
            command = connection.CreateCommand();
            command.CommandText = "update ///// set ///// = @num where ///// = @num"; // biến nhận thông báo/
            load();
        }

        private void RejBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumTbx.Text);
            command = connection.CreateCommand();
            command.CommandText = "delete from ///// where ///// = @num"; // xóa hợp đồng khỏi danh sách chờ/
            load1();
        }
    }
}
