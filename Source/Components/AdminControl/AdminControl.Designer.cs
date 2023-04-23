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
            tabPage2 = new System.Windows.Forms.TabPage();
            label3 = new System.Windows.Forms.Label();
            SttTbx = new System.Windows.Forms.TextBox();
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
            tabControl1.Location = new System.Drawing.Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(485, 344);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(477, 316);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cập nhật thông tin tài khoản";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(SttTbx);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(PassTbx);
            tabPage2.Controls.Add(AccTbx);
            tabPage2.Controls.Add(EditBtn);
            tabPage2.Controls.Add(DelBtn);
            tabPage2.Controls.Add(AddBtn);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(477, 316);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thêm - xóa - sửa tài khoản";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 9;
            label3.Text = "Số thứ tự";
            // 
            // SttTbx
            // 
            SttTbx.Location = new System.Drawing.Point(23, 44);
            SttTbx.Name = "SttTbx";
            SttTbx.Size = new System.Drawing.Size(37, 23);
            SttTbx.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(75, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(75, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Tài khoản";
            // 
            // PassTbx
            // 
            PassTbx.Location = new System.Drawing.Point(138, 49);
            PassTbx.Name = "PassTbx";
            PassTbx.Size = new System.Drawing.Size(208, 23);
            PassTbx.TabIndex = 5;
            // 
            // AccTbx
            // 
            AccTbx.Location = new System.Drawing.Point(138, 20);
            AccTbx.Name = "AccTbx";
            AccTbx.Size = new System.Drawing.Size(208, 23);
            AccTbx.TabIndex = 4;
            // 
            // EditBtn
            // 
            EditBtn.Location = new System.Drawing.Point(361, 64);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new System.Drawing.Size(75, 23);
            EditBtn.TabIndex = 3;
            EditBtn.Text = "Sửa";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.Location = new System.Drawing.Point(361, 35);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new System.Drawing.Size(75, 23);
            DelBtn.TabIndex = 2;
            DelBtn.Text = "Xóa";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new System.Drawing.Point(361, 6);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(75, 23);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Thêm";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(6, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(465, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(AcBtn);
            tabPage3.Controls.Add(DeBtn);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(SttDATbx);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(477, 316);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Khóa và kích hoạt tài khoản";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // AcBtn
            // 
            AcBtn.Location = new System.Drawing.Point(357, 24);
            AcBtn.Name = "AcBtn";
            AcBtn.Size = new System.Drawing.Size(75, 23);
            AcBtn.TabIndex = 13;
            AcBtn.Text = "Kích hoạt";
            AcBtn.UseVisualStyleBackColor = true;
            AcBtn.Click += AcBtn_Click;
            // 
            // DeBtn
            // 
            DeBtn.Location = new System.Drawing.Point(195, 24);
            DeBtn.Name = "DeBtn";
            DeBtn.Size = new System.Drawing.Size(75, 23);
            DeBtn.TabIndex = 12;
            DeBtn.Text = "Khóa";
            DeBtn.UseVisualStyleBackColor = true;
            DeBtn.Click += DeBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(49, 14);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 11;
            label4.Text = "Số thứ tự";
            // 
            // SttDATbx
            // 
            SttDATbx.Location = new System.Drawing.Point(58, 35);
            SttDATbx.Name = "SttDATbx";
            SttDATbx.Size = new System.Drawing.Size(37, 23);
            SttDATbx.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(6, 77);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(465, 233);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // AdminControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "AdminControl";
            Size = new System.Drawing.Size(488, 350);
            Load += AdminControl_Load;
            tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SttTbx;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AcBtn;
        private System.Windows.Forms.Button DeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SttDATbx;
    }
}
