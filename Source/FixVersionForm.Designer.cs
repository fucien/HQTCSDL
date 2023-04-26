
namespace HQTCSDL_G6
{
    partial class FixVersionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label label1;
            logoutButton = new System.Windows.Forms.Button();
            delayTimeNumeric = new System.Windows.Forms.NumericUpDown();
            currentFunctionLabel = new System.Windows.Forms.Label();
            functionsPanel = new System.Windows.Forms.TableLayoutPanel();
            currentFunctionPanel = new System.Windows.Forms.Panel();
            loginControl = new Components.LoginControl();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delayTimeNumeric).BeginInit();
            functionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(logoutButton, 2, 0);
            tableLayoutPanel5.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel5.Controls.Add(currentFunctionLabel, 1, 0);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(3, 2);
            tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new System.Drawing.Size(1015, 43);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            logoutButton.AutoSize = true;
            logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            logoutButton.Location = new System.Drawing.Point(925, 2);
            logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new System.Drawing.Size(87, 29);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Đăng xuất";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += LogoutButton_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(delayTimeNumeric);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(400, 39);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 19);
            label1.TabIndex = 1;
            label1.Text = "Thời gian chờ (giây)";
            // 
            // delayTimeNumeric
            // 
            delayTimeNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            delayTimeNumeric.Location = new System.Drawing.Point(137, 2);
            delayTimeNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            delayTimeNumeric.Name = "delayTimeNumeric";
            delayTimeNumeric.Size = new System.Drawing.Size(131, 25);
            delayTimeNumeric.TabIndex = 2;
            // 
            // currentFunctionLabel
            // 
            currentFunctionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            currentFunctionLabel.AutoSize = true;
            currentFunctionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            currentFunctionLabel.Location = new System.Drawing.Point(544, 0);
            currentFunctionLabel.Name = "currentFunctionLabel";
            currentFunctionLabel.Size = new System.Drawing.Size(130, 43);
            currentFunctionLabel.TabIndex = 4;
            currentFunctionLabel.Text = "Khách hàng 1";
            // 
            // functionsPanel
            // 
            functionsPanel.ColumnCount = 1;
            functionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            functionsPanel.Controls.Add(tableLayoutPanel5, 0, 0);
            functionsPanel.Controls.Add(currentFunctionPanel, 0, 1);
            functionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            functionsPanel.Location = new System.Drawing.Point(0, 0);
            functionsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            functionsPanel.Name = "functionsPanel";
            functionsPanel.RowCount = 3;
            functionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            functionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            functionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            functionsPanel.Size = new System.Drawing.Size(1021, 487);
            functionsPanel.TabIndex = 2;
            functionsPanel.Visible = false;
            // 
            // currentFunctionPanel
            // 
            currentFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            currentFunctionPanel.Location = new System.Drawing.Point(3, 49);
            currentFunctionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            currentFunctionPanel.Name = "currentFunctionPanel";
            currentFunctionPanel.Size = new System.Drawing.Size(1015, 420);
            currentFunctionPanel.TabIndex = 2;
            // 
            // loginControl
            // 
            loginControl.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            loginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            loginControl.Location = new System.Drawing.Point(0, 0);
            loginControl.Margin = new System.Windows.Forms.Padding(2);
            loginControl.Name = "loginControl";
            loginControl.Size = new System.Drawing.Size(1021, 487);
            loginControl.TabIndex = 3;
            loginControl.TabStop = false;
            loginControl.Load += loginControl_Load;
            // 
            // FixVersionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            ClientSize = new System.Drawing.Size(1021, 487);
            Controls.Add(loginControl);
            Controls.Add(functionsPanel);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FixVersionForm";
            Text = "FixVersionForm";
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)delayTimeNumeric).EndInit();
            functionsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel functionsPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.NumericUpDown delayTimeNumeric;
        private System.Windows.Forms.Label currentFunctionLabel;
        private System.Windows.Forms.Panel currentFunctionPanel;
        private Components.LoginControl loginControl;
    }
}