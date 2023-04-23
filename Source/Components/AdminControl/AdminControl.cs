using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HQTCSDL_Group01.Components.AdminControl
{
    public partial class AdminControl : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string query = "đường dẫn"; // bỏ vào đây đường dẫn đến database

        void load()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from /////"; // bỏ vào đây tên bảng trong database
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView2.DataSource = table;
        }
        public AdminControl()
        {
            InitializeComponent();
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(query);
            connection.Open();
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SttTbx.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            SttTbx.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            AccTbx.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            PassTbx.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string acc = AccTbx.Text;
            string pass = PassTbx.Text;
            int IsActive = 1;
            command = connection.CreateCommand();
            command.CommandText = "insert into ///// values ('" + acc + "', '" + pass + "', '" + IsActive + "')"; // bỏ vào đây tên bảng trong database
            command.ExecuteNonQuery();

            command = new SqlCommand("update ///// set stt = stt + 1", connection); // bỏ vào đây tên bảng trong database
            command.ExecuteNonQuery();

            MessageBox.Show("Thêm thành công");
            load();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from ///// where stt = '" + SttTbx.Text + "'"; // bỏ vào đây tên bảng trong database
            command.ExecuteNonQuery();

            command = new SqlCommand("update ///// set stt = stt - 1 where stt > '" + SttTbx.Text + "'", connection); // bỏ vào đây tên bảng trong database
            command.ExecuteNonQuery();

            MessageBox.Show("Xóa thành công");
            load();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update ///// set acc = '" + AccTbx.Text + "', pass = '" + PassTbx.Text + "' where stt = '" + SttTbx.Text + "'";
            // bỏ vào đây tên bảng trong database
            command.ExecuteNonQuery();

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
            command = connection.CreateCommand();
            command.CommandText = "update ///// set IsActive = 0 where stt = '" + SttDATbx.Text + "'"; // bỏ vào đây tên bảng trong database
            command.ExecuteNonQuery();

            MessageBox.Show("Khóa thành công");
        }

        private void AcBtn_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update ///// set IsActive = 1 where stt = '" + SttDATbx.Text + "'"; // bỏ vào đây tên bảng trong database
            command.ExecuteNonQuery();

            MessageBox.Show("Mở khóa thành công");
        }
    }
}
