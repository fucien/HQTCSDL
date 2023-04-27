
namespace HQTCSDL_G6
{
    partial class SelectVersionForm
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
            System.Windows.Forms.TableLayoutPanel versionsPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectVersionForm));
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            button1 = new System.Windows.Forms.Button();
            versionsPanel = new System.Windows.Forms.TableLayoutPanel();
            versionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // versionsPanel
            // 
            versionsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            versionsPanel.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            versionsPanel.ColumnCount = 1;
            versionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            versionsPanel.Controls.Add(radioButton2, 0, 1);
            versionsPanel.Controls.Add(radioButton1, 0, 0);
            versionsPanel.Controls.Add(button1, 0, 2);
            versionsPanel.Location = new System.Drawing.Point(0, 0);
            versionsPanel.Name = "versionsPanel";
            versionsPanel.RowCount = 4;
            versionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.4586F));
            versionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.5414F));
            versionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            versionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            versionsPanel.Size = new System.Drawing.Size(800, 451);
            versionsPanel.TabIndex = 0;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            radioButton2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radioButton2.ForeColor = System.Drawing.Color.Black;
            radioButton2.Location = new System.Drawing.Point(275, 163);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(249, 128);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Phiên bản sửa lỗi";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            radioButton1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radioButton1.ForeColor = System.Drawing.Color.Black;
            radioButton1.Location = new System.Drawing.Point(301, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(197, 154);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Phiên bản lỗi";
            radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            button1.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(321, 297);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(158, 65);
            button1.TabIndex = 4;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SelectVersionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 451);
            Controls.Add(versionsPanel);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "SelectVersionForm";
            Text = "Chọn phiên bản";
            versionsPanel.ResumeLayout(false);
            versionsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
    }
}