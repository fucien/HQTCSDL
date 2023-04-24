namespace HQTCSDL_Group01.Components.EmployeeControl
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
            tabControl1.Location = new System.Drawing.Point(3, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(494, 381);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(NummTbx);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(GuiBtn);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(486, 353);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý đối tác";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // NummTbx
            // 
            NummTbx.Location = new System.Drawing.Point(383, 26);
            NummTbx.Name = "NummTbx";
            NummTbx.Size = new System.Drawing.Size(97, 23);
            NummTbx.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(393, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Hợp đồng số";
            // 
            // GuiBtn
            // 
            GuiBtn.Location = new System.Drawing.Point(383, 285);
            GuiBtn.Name = "GuiBtn";
            GuiBtn.Size = new System.Drawing.Size(97, 62);
            GuiBtn.TabIndex = 1;
            GuiBtn.Text = "Gửi thông báo";
            GuiBtn.UseVisualStyleBackColor = true;
            GuiBtn.Click += GuiBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(374, 344);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(NumTbx);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(AccBtn);
            tabPage2.Controls.Add(RejBtn);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(486, 353);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Xác nhận hợp đồng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // NumTbx
            // 
            NumTbx.Location = new System.Drawing.Point(383, 30);
            NumTbx.Name = "NumTbx";
            NumTbx.Size = new System.Drawing.Size(97, 23);
            NumTbx.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(393, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "Hợp đồng số";
            // 
            // AccBtn
            // 
            AccBtn.Location = new System.Drawing.Point(383, 217);
            AccBtn.Name = "AccBtn";
            AccBtn.Size = new System.Drawing.Size(97, 62);
            AccBtn.TabIndex = 3;
            AccBtn.Text = "Xác nhận";
            AccBtn.UseVisualStyleBackColor = true;
            AccBtn.Click += AccBtn_Click;
            // 
            // RejBtn
            // 
            RejBtn.Location = new System.Drawing.Point(383, 285);
            RejBtn.Name = "RejBtn";
            RejBtn.Size = new System.Drawing.Size(97, 62);
            RejBtn.TabIndex = 2;
            RejBtn.Text = "Từ chối";
            RejBtn.UseVisualStyleBackColor = true;
            RejBtn.Click += RejBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(374, 344);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // EmployeeControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "EmployeeControl";
            Size = new System.Drawing.Size(500, 423);
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
