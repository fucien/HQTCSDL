
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
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            versionsPanel = new System.Windows.Forms.TableLayoutPanel();
            versionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // versionsPanel
            // 
            versionsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            versionsPanel.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            versionsPanel.ColumnCount = 1;
            versionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            versionsPanel.Controls.Add(radioButton2, 0, 1);
            versionsPanel.Controls.Add(radioButton1, 0, 0);
            versionsPanel.Location = new System.Drawing.Point(0, 0);
            versionsPanel.Name = "versionsPanel";
            versionsPanel.RowCount = 2;
            versionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            versionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            versionsPanel.Size = new System.Drawing.Size(800, 451);
            versionsPanel.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            radioButton1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radioButton1.ForeColor = System.Drawing.Color.White;
            radioButton1.Location = new System.Drawing.Point(270, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(259, 219);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Phiên bản lỗi";
            radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            radioButton2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radioButton2.ForeColor = System.Drawing.Color.White;
            radioButton2.Location = new System.Drawing.Point(234, 228);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(331, 220);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Phiên bản sửa lỗi";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // SelectVersionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 451);
            Controls.Add(versionsPanel);
            Name = "SelectVersionForm";
            Text = "Chọn phiên bản";
            versionsPanel.ResumeLayout(false);
            versionsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}