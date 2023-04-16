
namespace HQTCSDL_Group01.Components.PartnerControls.OrderControls
{
    partial class PartnerViewOrderControl
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
            System.Windows.Forms.TableLayoutPanel panel;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            viewButton = new System.Windows.Forms.Button();
            ordersPanel = new System.Windows.Forms.TableLayoutPanel();
            productsGridView = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panel = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            panel.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(viewButton, 0, 0);
            tableLayoutPanel1.Controls.Add(panel, 0, 1);
            tableLayoutPanel1.Controls.Add(productsGridView, 0, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel1.Size = new System.Drawing.Size(660, 364);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // viewButton
            // 
            viewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            viewButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            viewButton.Location = new System.Drawing.Point(3, 2);
            viewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            viewButton.Name = "viewButton";
            viewButton.Size = new System.Drawing.Size(654, 32);
            viewButton.TabIndex = 2;
            viewButton.Text = "Tải lại đơn hàng";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += ViewButton_Click;
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.ColumnCount = 1;
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panel.Controls.Add(tableLayoutPanel4, 0, 0);
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(3, 38);
            panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.RowCount = 2;
            panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            panel.Size = new System.Drawing.Size(654, 159);
            panel.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(ordersPanel, 0, 1);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel4.Size = new System.Drawing.Size(648, 140);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel5.ColumnCount = 10;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel5.Controls.Add(label14, 9, 0);
            tableLayoutPanel5.Controls.Add(label13, 8, 0);
            tableLayoutPanel5.Controls.Add(label12, 7, 0);
            tableLayoutPanel5.Controls.Add(label11, 6, 0);
            tableLayoutPanel5.Controls.Add(label10, 5, 0);
            tableLayoutPanel5.Controls.Add(label9, 4, 0);
            tableLayoutPanel5.Controls.Add(label8, 3, 0);
            tableLayoutPanel5.Controls.Add(label7, 2, 0);
            tableLayoutPanel5.Controls.Add(label6, 1, 0);
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(3, 2);
            tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new System.Drawing.Size(642, 24);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(563, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(61, 24);
            label14.TabIndex = 9;
            label14.Text = "Xem chi tiết";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(499, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(58, 24);
            label13.TabIndex = 8;
            label13.Text = "Phí vận chuyển";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(435, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(57, 24);
            label12.TabIndex = 7;
            label12.Text = "Phí sản phẩm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(371, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(46, 24);
            label11.TabIndex = 6;
            label11.Text = "Tình trạng đơn hàng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(243, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(115, 19);
            label10.TabIndex = 5;
            label10.Text = "Địa chỉ giao hàng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(179, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(49, 24);
            label9.TabIndex = 4;
            label9.Text = "Hình thức thanh toán";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(135, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(33, 24);
            label8.TabIndex = 3;
            label8.Text = "Mã tài xế";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(91, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(37, 24);
            label7.TabIndex = 2;
            label7.Text = "Mã khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(47, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(33, 24);
            label6.TabIndex = 1;
            label6.Text = "Mã chi nhánh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 24);
            label5.TabIndex = 0;
            label5.Text = "Mã hóa đơn";
            // 
            // ordersPanel
            // 
            ordersPanel.AutoScroll = true;
            ordersPanel.ColumnCount = 1;
            ordersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            ordersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ordersPanel.Location = new System.Drawing.Point(3, 30);
            ordersPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.RowCount = 1;
            ordersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            ordersPanel.Size = new System.Drawing.Size(642, 108);
            ordersPanel.TabIndex = 2;
            // 
            // productsGridView
            // 
            productsGridView.AllowUserToAddRows = false;
            productsGridView.AllowUserToDeleteRows = false;
            productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, name, amount, price });
            productsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            productsGridView.Location = new System.Drawing.Point(3, 201);
            productsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            productsGridView.Name = "productsGridView";
            productsGridView.ReadOnly = true;
            productsGridView.RowHeadersWidth = 51;
            productsGridView.RowTemplate.Height = 29;
            productsGridView.Size = new System.Drawing.Size(654, 161);
            productsGridView.TabIndex = 4;
            // 
            // id
            // 
            id.HeaderText = "Mã sản phẩm";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Tên sản phẩm";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // amount
            // 
            amount.HeaderText = "Số lượng";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.ReadOnly = true;
            // 
            // price
            // 
            price.HeaderText = "Đơn giá";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // PartnerViewOrderControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "PartnerViewOrderControl";
            Size = new System.Drawing.Size(660, 364);
            tableLayoutPanel1.ResumeLayout(false);
            panel.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel ordersPanel;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}
