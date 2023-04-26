namespace HQTCSDL_G6.Components.EmployeeControl
{
    partial class EmployeeControl
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
            NummTbx = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            GuiBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            NumTbx = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            AccBtn = new System.Windows.Forms.Button();
            RejBtn = new System.Windows.Forms.Button();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(3, 52);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(565, 508);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tabPage1.Controls.Add(NummTbx);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(GuiBtn);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Size = new System.Drawing.Size(557, 475);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý đối tác";
            // 
            // NummTbx
            // 
            NummTbx.Location = new System.Drawing.Point(438, 35);
            NummTbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            NummTbx.Name = "NummTbx";
            NummTbx.Size = new System.Drawing.Size(110, 27);
            NummTbx.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(449, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã hợp đồng";
            // 
            // GuiBtn
            // 
            GuiBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            GuiBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            GuiBtn.ForeColor = System.Drawing.Color.White;
            GuiBtn.Location = new System.Drawing.Point(438, 380);
            GuiBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GuiBtn.Name = "GuiBtn";
            GuiBtn.Size = new System.Drawing.Size(111, 83);
            GuiBtn.TabIndex = 1;
            GuiBtn.Text = "Gửi thông báo";
            GuiBtn.UseVisualStyleBackColor = false;
            GuiBtn.Click += GuiBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(3, 4);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(427, 459);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tabPage2.Controls.Add(NumTbx);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(AccBtn);
            tabPage2.Controls.Add(RejBtn);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Size = new System.Drawing.Size(557, 475);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Xác nhận hợp đồng";
            tabPage2.Click += tabPage2_Click;
            // 
            // NumTbx
            // 
            NumTbx.Location = new System.Drawing.Point(438, 40);
            NumTbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            NumTbx.Name = "NumTbx";
            NumTbx.Size = new System.Drawing.Size(110, 27);
            NumTbx.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(449, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã hợp đồng";
            // 
            // AccBtn
            // 
            AccBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            AccBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AccBtn.ForeColor = System.Drawing.Color.White;
            AccBtn.Location = new System.Drawing.Point(438, 289);
            AccBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AccBtn.Name = "AccBtn";
            AccBtn.Size = new System.Drawing.Size(111, 83);
            AccBtn.TabIndex = 3;
            AccBtn.Text = "Xác nhận";
            AccBtn.UseVisualStyleBackColor = false;
            AccBtn.Click += AccBtn_Click;
            // 
            // RejBtn
            // 
            RejBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            RejBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            RejBtn.ForeColor = System.Drawing.Color.White;
            RejBtn.Location = new System.Drawing.Point(438, 380);
            RejBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RejBtn.Name = "RejBtn";
            RejBtn.Size = new System.Drawing.Size(111, 83);
            RejBtn.TabIndex = 2;
            RejBtn.Text = "Từ chối";
            RejBtn.UseVisualStyleBackColor = false;
            RejBtn.Click += RejBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(3, 4);
            dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(427, 459);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // EmployeeControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "EmployeeControl";
            Size = new System.Drawing.Size(571, 564);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button GuiBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AccBtn;
        private System.Windows.Forms.Button RejBtn;
        private System.Windows.Forms.TextBox NumTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NummTbx;
        private System.Windows.Forms.Label label2;
    }
}
