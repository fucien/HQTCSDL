
namespace HQTCSDL_Group01.Components.PartnerControls.OrderControls
{
    partial class OrderControl
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
            panel = new System.Windows.Forms.TableLayoutPanel();
            shippingPriceTb = new System.Windows.Forms.TextBox();
            productPriceTb = new System.Windows.Forms.TextBox();
            orderStateTb = new System.Windows.Forms.TextBox();
            addressTb = new System.Windows.Forms.TextBox();
            shippingMethodTb = new System.Windows.Forms.TextBox();
            shipperIDTb = new System.Windows.Forms.TextBox();
            customerIDTb = new System.Windows.Forms.TextBox();
            branchIDTb = new System.Windows.Forms.TextBox();
            orderIDTb = new System.Windows.Forms.TextBox();
            viewProductButton = new System.Windows.Forms.Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.AutoSize = true;
            panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            panel.ColumnCount = 10;
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            panel.Controls.Add(shippingPriceTb, 8, 0);
            panel.Controls.Add(productPriceTb, 7, 0);
            panel.Controls.Add(orderStateTb, 6, 0);
            panel.Controls.Add(addressTb, 5, 0);
            panel.Controls.Add(shippingMethodTb, 4, 0);
            panel.Controls.Add(shipperIDTb, 3, 0);
            panel.Controls.Add(customerIDTb, 2, 0);
            panel.Controls.Add(branchIDTb, 1, 0);
            panel.Controls.Add(orderIDTb, 0, 0);
            panel.Controls.Add(viewProductButton, 9, 0);
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.RowCount = 1;
            panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            panel.Size = new System.Drawing.Size(760, 29);
            panel.TabIndex = 0;
            // 
            // shippingPriceTb
            // 
            shippingPriceTb.Dock = System.Windows.Forms.DockStyle.Fill;
            shippingPriceTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            shippingPriceTb.Location = new System.Drawing.Point(595, 2);
            shippingPriceTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            shippingPriceTb.Name = "shippingPriceTb";
            shippingPriceTb.ReadOnly = true;
            shippingPriceTb.Size = new System.Drawing.Size(70, 25);
            shippingPriceTb.TabIndex = 8;
            // 
            // productPriceTb
            // 
            productPriceTb.Dock = System.Windows.Forms.DockStyle.Fill;
            productPriceTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            productPriceTb.Location = new System.Drawing.Point(519, 2);
            productPriceTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            productPriceTb.Name = "productPriceTb";
            productPriceTb.ReadOnly = true;
            productPriceTb.Size = new System.Drawing.Size(70, 25);
            productPriceTb.TabIndex = 7;
            // 
            // orderStateTb
            // 
            orderStateTb.Dock = System.Windows.Forms.DockStyle.Fill;
            orderStateTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            orderStateTb.Location = new System.Drawing.Point(443, 2);
            orderStateTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            orderStateTb.Name = "orderStateTb";
            orderStateTb.ReadOnly = true;
            orderStateTb.Size = new System.Drawing.Size(70, 25);
            orderStateTb.TabIndex = 6;
            // 
            // addressTb
            // 
            addressTb.Dock = System.Windows.Forms.DockStyle.Fill;
            addressTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            addressTb.Location = new System.Drawing.Point(291, 2);
            addressTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addressTb.Name = "addressTb";
            addressTb.ReadOnly = true;
            addressTb.Size = new System.Drawing.Size(146, 25);
            addressTb.TabIndex = 5;
            // 
            // shippingMethodTb
            // 
            shippingMethodTb.Dock = System.Windows.Forms.DockStyle.Fill;
            shippingMethodTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            shippingMethodTb.Location = new System.Drawing.Point(215, 2);
            shippingMethodTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            shippingMethodTb.Name = "shippingMethodTb";
            shippingMethodTb.ReadOnly = true;
            shippingMethodTb.Size = new System.Drawing.Size(70, 25);
            shippingMethodTb.TabIndex = 4;
            // 
            // shipperIDTb
            // 
            shipperIDTb.Dock = System.Windows.Forms.DockStyle.Fill;
            shipperIDTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            shipperIDTb.Location = new System.Drawing.Point(162, 2);
            shipperIDTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            shipperIDTb.Name = "shipperIDTb";
            shipperIDTb.ReadOnly = true;
            shipperIDTb.Size = new System.Drawing.Size(47, 25);
            shipperIDTb.TabIndex = 3;
            // 
            // customerIDTb
            // 
            customerIDTb.Dock = System.Windows.Forms.DockStyle.Fill;
            customerIDTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            customerIDTb.Location = new System.Drawing.Point(109, 2);
            customerIDTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            customerIDTb.Name = "customerIDTb";
            customerIDTb.ReadOnly = true;
            customerIDTb.Size = new System.Drawing.Size(47, 25);
            customerIDTb.TabIndex = 2;
            // 
            // branchIDTb
            // 
            branchIDTb.Dock = System.Windows.Forms.DockStyle.Fill;
            branchIDTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            branchIDTb.Location = new System.Drawing.Point(56, 2);
            branchIDTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            branchIDTb.Name = "branchIDTb";
            branchIDTb.ReadOnly = true;
            branchIDTb.Size = new System.Drawing.Size(47, 25);
            branchIDTb.TabIndex = 1;
            // 
            // orderIDTb
            // 
            orderIDTb.Dock = System.Windows.Forms.DockStyle.Fill;
            orderIDTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            orderIDTb.Location = new System.Drawing.Point(3, 2);
            orderIDTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            orderIDTb.Name = "orderIDTb";
            orderIDTb.ReadOnly = true;
            orderIDTb.Size = new System.Drawing.Size(47, 25);
            orderIDTb.TabIndex = 0;
            // 
            // viewProductButton
            // 
            viewProductButton.AutoSize = true;
            viewProductButton.BackColor = System.Drawing.Color.FromArgb(241, 114, 40);
            viewProductButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            viewProductButton.ForeColor = System.Drawing.Color.White;
            viewProductButton.Location = new System.Drawing.Point(671, 2);
            viewProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            viewProductButton.Name = "viewProductButton";
            viewProductButton.Size = new System.Drawing.Size(82, 25);
            viewProductButton.TabIndex = 9;
            viewProductButton.Text = "Chi tiết";
            viewProductButton.UseVisualStyleBackColor = false;
            viewProductButton.Click += ViewProductButton_Click;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(panel);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "OrderControl";
            Size = new System.Drawing.Size(760, 29);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.TextBox shippingPriceTb;
        private System.Windows.Forms.TextBox productPriceTb;
        private System.Windows.Forms.TextBox orderStateTb;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.TextBox shippingMethodTb;
        private System.Windows.Forms.TextBox shipperIDTb;
        private System.Windows.Forms.TextBox customerIDTb;
        private System.Windows.Forms.TextBox branchIDTb;
        private System.Windows.Forms.TextBox orderIDTb;
        private System.Windows.Forms.Button viewProductButton;
    }
}
