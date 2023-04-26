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
            SuspendLayout();
            // 
            // TxBtn
            // 
            TxBtn.Location = new System.Drawing.Point(57, 56);
            TxBtn.Name = "TxBtn";
            TxBtn.Size = new System.Drawing.Size(75, 23);
            TxBtn.TabIndex = 0;
            TxBtn.Text = "Tài xế";
            TxBtn.UseVisualStyleBackColor = true;
            TxBtn.Click += TxBtn_Click;
            // 
            // KhBtn
            // 
            KhBtn.Location = new System.Drawing.Point(151, 56);
            KhBtn.Name = "KhBtn";
            KhBtn.Size = new System.Drawing.Size(82, 23);
            KhBtn.TabIndex = 1;
            KhBtn.Text = "Khách hàng";
            KhBtn.UseVisualStyleBackColor = true;
            KhBtn.Click += KhBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(72, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(152, 15);
            label1.TabIndex = 2;
            label1.Text = "Chọn vai trò muốn đăng ký";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(KhBtn);
            Controls.Add(TxBtn);
            Name = "RegisterForm";
            Size = new System.Drawing.Size(300, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button TxBtn;
        private System.Windows.Forms.Button KhBtn;
        private System.Windows.Forms.Label label1;
    }
}
