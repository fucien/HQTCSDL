
namespace HQTCSDL_G6.Components
{
    partial class LoginControl
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
            System.Windows.Forms.TableLayoutPanel loginPanel;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            passwordTb = new System.Windows.Forms.TextBox();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            accountTb = new System.Windows.Forms.TextBox();
            confirmButton = new System.Windows.Forms.Button();
            RBtn = new System.Windows.Forms.Button();
            loginPanel = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            loginPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            loginPanel.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            loginPanel.ColumnCount = 1;
            loginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            loginPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            loginPanel.Controls.Add(label1, 0, 0);
            loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            loginPanel.Location = new System.Drawing.Point(0, 0);
            loginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            loginPanel.Name = "loginPanel";
            loginPanel.RowCount = 2;
            loginPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.4272537F));
            loginPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.57275F));
            loginPanel.Size = new System.Drawing.Size(300, 200);
            loginPanel.TabIndex = 4;
            loginPanel.Paint += loginPanel_Paint_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.6551743F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.3448257F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel1.Controls.Add(confirmButton, 0, 0);
            tableLayoutPanel1.Controls.Add(RBtn, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel1.Size = new System.Drawing.Size(294, 166);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(passwordTb, 0, 1);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(119, 81);
            tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            tableLayoutPanel5.Size = new System.Drawing.Size(172, 83);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // passwordTb
            // 
            passwordTb.Dock = System.Windows.Forms.DockStyle.Fill;
            passwordTb.Location = new System.Drawing.Point(3, 26);
            passwordTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.Size = new System.Drawing.Size(166, 23);
            passwordTb.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(3, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 19);
            label4.TabIndex = 0;
            label4.Text = "Mặt khẩu";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Controls.Add(accountTb, 0, 1);
            tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel6.Location = new System.Drawing.Point(119, 2);
            tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tableLayoutPanel6.Size = new System.Drawing.Size(172, 75);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên tài khoản";
            // 
            // accountTb
            // 
            accountTb.Dock = System.Windows.Forms.DockStyle.Fill;
            accountTb.Location = new System.Drawing.Point(3, 24);
            accountTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            accountTb.Name = "accountTb";
            accountTb.Size = new System.Drawing.Size(166, 23);
            accountTb.TabIndex = 1;
            // 
            // confirmButton
            // 
            confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            confirmButton.AutoSize = true;
            confirmButton.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            confirmButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            confirmButton.ForeColor = System.Drawing.Color.White;
            confirmButton.Location = new System.Drawing.Point(15, 2);
            confirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new System.Drawing.Size(86, 27);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "Đăng nhập";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // RBtn
            // 
            RBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            RBtn.AutoSize = true;
            RBtn.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            RBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            RBtn.ForeColor = System.Drawing.Color.White;
            RBtn.Location = new System.Drawing.Point(19, 81);
            RBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            RBtn.Name = "RBtn";
            RBtn.Size = new System.Drawing.Size(77, 27);
            RBtn.TabIndex = 4;
            RBtn.Text = "Đăng ký";
            RBtn.UseVisualStyleBackColor = false;
            RBtn.Click += RBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(88, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 30);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            label1.Click += label1_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(loginPanel);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "LoginControl";
            Size = new System.Drawing.Size(300, 200);
            loginPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox accountTb;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button RBtn;
    }
}
