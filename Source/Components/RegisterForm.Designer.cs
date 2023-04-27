namespace HQTCSDL_G6.Components
{
    partial class RegisterForm
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
            TxBtn = new System.Windows.Forms.Button();
            KhBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            DtBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // TxBtn
            // 
            TxBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            TxBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxBtn.ForeColor = System.Drawing.Color.White;
            TxBtn.Location = new System.Drawing.Point(26, 75);
            TxBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TxBtn.Name = "TxBtn";
            TxBtn.Size = new System.Drawing.Size(86, 31);
            TxBtn.TabIndex = 0;
            TxBtn.Text = "Tài xế";
            TxBtn.UseVisualStyleBackColor = false;
            TxBtn.Click += TxBtn_Click;
            // 
            // KhBtn
            // 
            KhBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            KhBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            KhBtn.ForeColor = System.Drawing.Color.White;
            KhBtn.Location = new System.Drawing.Point(119, 75);
            KhBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            KhBtn.Name = "KhBtn";
            KhBtn.Size = new System.Drawing.Size(94, 31);
            KhBtn.TabIndex = 1;
            KhBtn.Text = "Khách hàng";
            KhBtn.UseVisualStyleBackColor = false;
            KhBtn.Click += KhBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(82, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(198, 20);
            label1.TabIndex = 2;
            label1.Text = "Chọn vai trò muốn đăng ký";
            // 
            // DtBtn
            // 
            DtBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            DtBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DtBtn.ForeColor = System.Drawing.Color.White;
            DtBtn.Location = new System.Drawing.Point(219, 75);
            DtBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DtBtn.Name = "DtBtn";
            DtBtn.Size = new System.Drawing.Size(94, 31);
            DtBtn.TabIndex = 3;
            DtBtn.Text = "Đối tác";
            DtBtn.UseVisualStyleBackColor = false;
            DtBtn.Click += DtBtn_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            Controls.Add(DtBtn);
            Controls.Add(label1);
            Controls.Add(KhBtn);
            Controls.Add(TxBtn);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Size = new System.Drawing.Size(343, 133);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button TxBtn;
        private System.Windows.Forms.Button KhBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DtBtn;
    }
}
