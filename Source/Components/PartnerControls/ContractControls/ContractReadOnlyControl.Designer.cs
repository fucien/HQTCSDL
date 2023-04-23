
namespace HQTCSDL_G6.Components.PartnerControls.ContractControls
{
    partial class ContractReadOnlyControl
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            contractIDTb = new System.Windows.Forms.TextBox();
            contractTaxTb = new System.Windows.Forms.TextBox();
            viewBranchButton = new System.Windows.Forms.Button();
            contractRepTb = new System.Windows.Forms.TextBox();
            contractDatesTb = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(contractIDTb, 0, 0);
            tableLayoutPanel1.Controls.Add(contractTaxTb, 1, 0);
            tableLayoutPanel1.Controls.Add(viewBranchButton, 4, 0);
            tableLayoutPanel1.Controls.Add(contractRepTb, 2, 0);
            tableLayoutPanel1.Controls.Add(contractDatesTb, 3, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(810, 29);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // contractIDTb
            // 
            contractIDTb.Dock = System.Windows.Forms.DockStyle.Fill;
            contractIDTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            contractIDTb.Location = new System.Drawing.Point(3, 2);
            contractIDTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            contractIDTb.Name = "contractIDTb";
            contractIDTb.ReadOnly = true;
            contractIDTb.Size = new System.Drawing.Size(115, 25);
            contractIDTb.TabIndex = 0;
            // 
            // contractTaxTb
            // 
            contractTaxTb.Dock = System.Windows.Forms.DockStyle.Fill;
            contractTaxTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            contractTaxTb.Location = new System.Drawing.Point(124, 2);
            contractTaxTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            contractTaxTb.Name = "contractTaxTb";
            contractTaxTb.ReadOnly = true;
            contractTaxTb.Size = new System.Drawing.Size(115, 25);
            contractTaxTb.TabIndex = 1;
            // 
            // viewBranchButton
            // 
            viewBranchButton.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            viewBranchButton.Dock = System.Windows.Forms.DockStyle.Top;
            viewBranchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            viewBranchButton.ForeColor = System.Drawing.Color.White;
            viewBranchButton.Location = new System.Drawing.Point(649, 2);
            viewBranchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            viewBranchButton.Name = "viewBranchButton";
            viewBranchButton.Size = new System.Drawing.Size(158, 25);
            viewBranchButton.TabIndex = 3;
            viewBranchButton.Text = "Xem chi nhánh";
            viewBranchButton.UseVisualStyleBackColor = false;
            viewBranchButton.Click += ViewBranchButton_Click;
            // 
            // contractRepTb
            // 
            contractRepTb.Dock = System.Windows.Forms.DockStyle.Fill;
            contractRepTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            contractRepTb.Location = new System.Drawing.Point(245, 2);
            contractRepTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            contractRepTb.Name = "contractRepTb";
            contractRepTb.ReadOnly = true;
            contractRepTb.Size = new System.Drawing.Size(115, 25);
            contractRepTb.TabIndex = 4;
            // 
            // contractDatesTb
            // 
            contractDatesTb.Dock = System.Windows.Forms.DockStyle.Fill;
            contractDatesTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            contractDatesTb.Location = new System.Drawing.Point(366, 2);
            contractDatesTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            contractDatesTb.Name = "contractDatesTb";
            contractDatesTb.ReadOnly = true;
            contractDatesTb.Size = new System.Drawing.Size(277, 25);
            contractDatesTb.TabIndex = 5;
            // 
            // ContractReadOnlyControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "ContractReadOnlyControl";
            Size = new System.Drawing.Size(810, 29);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox contractIDTb;
        private System.Windows.Forms.TextBox contractTaxTb;
        private System.Windows.Forms.Button viewBranchButton;
        private System.Windows.Forms.TextBox contractRepTb;
        private System.Windows.Forms.TextBox contractDatesTb;
    }
}
