
namespace HQTCSDL_G6.Components
{
    partial class ViewBranchControl
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
            tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            viewButton = new System.Windows.Forms.Button();
            branchGridView = new System.Windows.Forms.DataGridView();
            tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)branchGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tableLayoutPanel16.ColumnCount = 1;
            tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel16.Controls.Add(viewButton, 0, 0);
            tableLayoutPanel16.Controls.Add(branchGridView, 0, 1);
            tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            tableLayoutPanel16.Size = new System.Drawing.Size(430, 319);
            tableLayoutPanel16.TabIndex = 1;
            // 
            // viewButton
            // 
            viewButton.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            viewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            viewButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            viewButton.ForeColor = System.Drawing.Color.White;
            viewButton.Location = new System.Drawing.Point(3, 2);
            viewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            viewButton.Name = "viewButton";
            viewButton.Size = new System.Drawing.Size(424, 27);
            viewButton.TabIndex = 0;
            viewButton.Text = "Xem danh sách các chi nhánh";
            viewButton.UseVisualStyleBackColor = false;
            // 
            // branchGridView
            // 
            branchGridView.AllowUserToAddRows = false;
            branchGridView.AllowUserToDeleteRows = false;
            branchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            branchGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            branchGridView.Location = new System.Drawing.Point(3, 33);
            branchGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            branchGridView.Name = "branchGridView";
            branchGridView.RowHeadersWidth = 51;
            branchGridView.RowTemplate.Height = 29;
            branchGridView.Size = new System.Drawing.Size(424, 284);
            branchGridView.TabIndex = 1;
            // 
            // ViewBranchControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel16);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "ViewBranchControl";
            Size = new System.Drawing.Size(430, 319);
            tableLayoutPanel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)branchGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.DataGridView branchGridView;
    }
}
