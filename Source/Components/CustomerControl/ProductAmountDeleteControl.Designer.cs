
namespace HQTCSDL_G6.Components
{
    partial class ProductAmountDeleteControl
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            productPriceTb = new System.Windows.Forms.TextBox();
            productIDCbb = new System.Windows.Forms.ComboBox();
            productNameTb = new System.Windows.Forms.TextBox();
            amountNumeric = new System.Windows.Forms.NumericUpDown();
            deleteButton = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountNumeric).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(243, 200, 28);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(productPriceTb, 2, 0);
            tableLayoutPanel1.Controls.Add(productIDCbb, 0, 0);
            tableLayoutPanel1.Controls.Add(productNameTb, 1, 0);
            tableLayoutPanel1.Controls.Add(amountNumeric, 3, 0);
            tableLayoutPanel1.Controls.Add(deleteButton, 4, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(700, 33);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // productPriceTb
            // 
            productPriceTb.Dock = System.Windows.Forms.DockStyle.Fill;
            productPriceTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            productPriceTb.Location = new System.Drawing.Point(283, 2);
            productPriceTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            productPriceTb.Name = "productPriceTb";
            productPriceTb.ReadOnly = true;
            productPriceTb.Size = new System.Drawing.Size(134, 25);
            productPriceTb.TabIndex = 2;
            // 
            // productIDCbb
            // 
            productIDCbb.Dock = System.Windows.Forms.DockStyle.Fill;
            productIDCbb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            productIDCbb.FormattingEnabled = true;
            productIDCbb.Location = new System.Drawing.Point(3, 2);
            productIDCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            productIDCbb.Name = "productIDCbb";
            productIDCbb.Size = new System.Drawing.Size(134, 25);
            productIDCbb.TabIndex = 0;
            // 
            // productNameTb
            // 
            productNameTb.Dock = System.Windows.Forms.DockStyle.Fill;
            productNameTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            productNameTb.Location = new System.Drawing.Point(143, 2);
            productNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            productNameTb.Name = "productNameTb";
            productNameTb.ReadOnly = true;
            productNameTb.Size = new System.Drawing.Size(134, 25);
            productNameTb.TabIndex = 1;
            // 
            // amountNumeric
            // 
            amountNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            amountNumeric.Location = new System.Drawing.Point(423, 2);
            amountNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            amountNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amountNumeric.Name = "amountNumeric";
            amountNumeric.Size = new System.Drawing.Size(131, 25);
            amountNumeric.TabIndex = 3;
            amountNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deleteButton.ForeColor = System.Drawing.Color.White;
            deleteButton.Location = new System.Drawing.Point(563, 2);
            deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(134, 29);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Xóa sản phẩm";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // ProductAmountDeleteControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "ProductAmountDeleteControl";
            Size = new System.Drawing.Size(700, 33);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox productPriceTb;
        private System.Windows.Forms.ComboBox productIDCbb;
        private System.Windows.Forms.TextBox productNameTb;
        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.Button deleteButton;
    }
}
