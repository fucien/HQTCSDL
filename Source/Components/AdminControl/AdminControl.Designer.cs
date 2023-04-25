namespace HQTCSDL_G6.Components.AdminControl
{
    partial class AdminControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            ShowBtn = new System.Windows.Forms.Button();
            dataGridView3 = new System.Windows.Forms.DataGridView();
            Cbx = new System.Windows.Forms.ComboBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            ClrBtn = new System.Windows.Forms.Button();
            RoleCbx = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            PassTbx = new System.Windows.Forms.TextBox();
            AccTbx = new System.Windows.Forms.TextBox();
            EditBtn = new System.Windows.Forms.Button();
            DelBtn = new System.Windows.Forms.Button();
            AddBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tabPage3 = new System.Windows.Forms.TabPage();
            AcBtn = new System.Windows.Forms.Button();
            DeBtn = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            SttDATbx = new System.Windows.Forms.TextBox();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(3, 4);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(554, 459);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tabPage1.Controls.Add(ShowBtn);
            tabPage1.Controls.Add(dataGridView3);
            tabPage1.Controls.Add(Cbx);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Size = new System.Drawing.Size(546, 426);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cập nhật thông tin tài khoản";
            // 
            // ShowBtn
            // 
            ShowBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ShowBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            ShowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowBtn.Location = new System.Drawing.Point(442, 8);
            ShowBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new System.Drawing.Size(86, 31);
            ShowBtn.TabIndex = 3;
            ShowBtn.Text = "Show";
            ShowBtn.UseVisualStyleBackColor = true;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new System.Drawing.Point(7, 47);
            dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new System.Drawing.Size(531, 367);
            dataGridView3.TabIndex = 2;
            // 
            // Cbx
            // 
            Cbx.FormattingEnabled = true;
            Cbx.Items.AddRange(new object[] { "Admin", "Nhân Viên", "Đối Tác", "Khách Hàng", "Tài Xế" });
            Cbx.Location = new System.Drawing.Point(7, 8);
            Cbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Cbx.Name = "Cbx";
            Cbx.Size = new System.Drawing.Size(411, 28);
            Cbx.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tabPage2.Controls.Add(ClrBtn);
            tabPage2.Controls.Add(RoleCbx);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(PassTbx);
            tabPage2.Controls.Add(AccTbx);
            tabPage2.Controls.Add(EditBtn);
            tabPage2.Controls.Add(DelBtn);
            tabPage2.Controls.Add(AddBtn);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Size = new System.Drawing.Size(546, 426);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thêm - xóa - sửa tài khoản";
            // 
            // ClrBtn
            // 
            ClrBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            ClrBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ClrBtn.ForeColor = System.Drawing.Color.White;
            ClrBtn.Location = new System.Drawing.Point(7, 48);
            ClrBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ClrBtn.Name = "ClrBtn";
            ClrBtn.Size = new System.Drawing.Size(57, 31);
            ClrBtn.TabIndex = 13;
            ClrBtn.Text = "Clear";
            ClrBtn.UseVisualStyleBackColor = false;
            ClrBtn.Click += ClrBtn_Click;
            // 
            // RoleCbx
            // 
            RoleCbx.FormattingEnabled = true;
            RoleCbx.Items.AddRange(new object[] { "AD", "NV", "KH", "DT", "TX" });
            RoleCbx.Location = new System.Drawing.Point(143, 85);
            RoleCbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RoleCbx.Name = "RoleCbx";
            RoleCbx.Size = new System.Drawing.Size(237, 28);
            RoleCbx.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(71, 91);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 20);
            label5.TabIndex = 10;
            label5.Text = "Vai trò";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(71, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(71, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 20);
            label1.TabIndex = 6;
            label1.Text = "Tài khoản";
            // 
            // PassTbx
            // 
            PassTbx.Location = new System.Drawing.Point(143, 48);
            PassTbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PassTbx.Name = "PassTbx";
            PassTbx.Size = new System.Drawing.Size(237, 27);
            PassTbx.TabIndex = 5;
            // 
            // AccTbx
            // 
            AccTbx.Location = new System.Drawing.Point(143, 9);
            AccTbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AccTbx.Name = "AccTbx";
            AccTbx.Size = new System.Drawing.Size(237, 27);
            AccTbx.TabIndex = 4;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            EditBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            EditBtn.ForeColor = System.Drawing.Color.White;
            EditBtn.Location = new System.Drawing.Point(413, 85);
            EditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new System.Drawing.Size(86, 31);
            EditBtn.TabIndex = 3;
            EditBtn.Text = "Sửa";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            DelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DelBtn.ForeColor = System.Drawing.Color.White;
            DelBtn.Location = new System.Drawing.Point(413, 47);
            DelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new System.Drawing.Size(86, 31);
            DelBtn.TabIndex = 2;
            DelBtn.Text = "Xóa";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            AddBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AddBtn.ForeColor = System.Drawing.Color.White;
            AddBtn.Location = new System.Drawing.Point(413, 8);
            AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(86, 31);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Thêm";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(7, 124);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(531, 293);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tabPage3.Controls.Add(AcBtn);
            tabPage3.Controls.Add(DeBtn);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(SttDATbx);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage3.Size = new System.Drawing.Size(546, 426);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Khóa và kích hoạt tài khoản";
            // 
            // AcBtn
            // 
            AcBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AcBtn.ForeColor = System.Drawing.Color.Black;
            AcBtn.Location = new System.Drawing.Point(408, 32);
            AcBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AcBtn.Name = "AcBtn";
            AcBtn.Size = new System.Drawing.Size(86, 31);
            AcBtn.TabIndex = 13;
            AcBtn.Text = "Kích hoạt";
            AcBtn.UseVisualStyleBackColor = true;
            AcBtn.Click += AcBtn_Click;
            // 
            // DeBtn
            // 
            DeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DeBtn.ForeColor = System.Drawing.Color.Black;
            DeBtn.Location = new System.Drawing.Point(223, 32);
            DeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DeBtn.Name = "DeBtn";
            DeBtn.Size = new System.Drawing.Size(86, 31);
            DeBtn.TabIndex = 12;
            DeBtn.Text = "Khóa";
            DeBtn.UseVisualStyleBackColor = true;
            DeBtn.Click += DeBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(56, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(75, 20);
            label4.TabIndex = 11;
            label4.Text = "Số thứ tự";
            // 
            // SttDATbx
            // 
            SttDATbx.Location = new System.Drawing.Point(66, 47);
            SttDATbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SttDATbx.Name = "SttDATbx";
            SttDATbx.Size = new System.Drawing.Size(42, 27);
            SttDATbx.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(7, 103);
            dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(531, 311);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // AdminControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "AdminControl";
            Size = new System.Drawing.Size(558, 467);
            Load += AdminControl_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PassTbx;
        private System.Windows.Forms.TextBox AccTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AcBtn;
        private System.Windows.Forms.Button DeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SttDATbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RoleCbx;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox Cbx;
        private System.Windows.Forms.Button ShowBtn;
    }
}
