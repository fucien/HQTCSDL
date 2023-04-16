
namespace HQTCSDL_Group01.Components
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            passwordTb = new System.Windows.Forms.TextBox();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            accountTb = new System.Windows.Forms.TextBox();
            confirmButton = new System.Windows.Forms.Button();
            loginPanel = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
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
            loginPanel.Controls.Add(label1, 0, 0);
            loginPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            loginPanel.Location = new System.Drawing.Point(0, 0);
            loginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            loginPanel.Name = "loginPanel";
            loginPanel.RowCount = 3;
            loginPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            loginPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            loginPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            loginPanel.Size = new System.Drawing.Size(427, 362);
            loginPanel.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(151, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 26);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel1.Controls.Add(confirmButton, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(421, 308);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(passwordTb, 0, 1);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(129, 79);
            tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            tableLayoutPanel5.Size = new System.Drawing.Size(162, 73);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // passwordTb
            // 
            passwordTb.Dock = System.Windows.Forms.DockStyle.Fill;
            passwordTb.Location = new System.Drawing.Point(3, 23);
            passwordTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.Size = new System.Drawing.Size(156, 23);
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
            tableLayoutPanel6.Location = new System.Drawing.Point(129, 2);
            tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tableLayoutPanel6.Size = new System.Drawing.Size(162, 73);
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
            accountTb.Location = new System.Drawing.Point(3, 23);
            accountTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            accountTb.Name = "accountTb";
            accountTb.Size = new System.Drawing.Size(156, 23);
            accountTb.TabIndex = 1;
            // 
            // confirmButton
            // 
            confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            confirmButton.AutoSize = true;
            confirmButton.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            confirmButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            confirmButton.ForeColor = System.Drawing.Color.White;
            confirmButton.Location = new System.Drawing.Point(166, 156);
            confirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new System.Drawing.Size(87, 29);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "Đăng nhập";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(loginPanel);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "LoginControl";
            Size = new System.Drawing.Size(427, 362);
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

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox accountTb;
    }
}
