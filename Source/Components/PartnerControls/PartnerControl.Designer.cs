
namespace HQTCSDL_G6.Components.PartnerControls
{
    partial class PartnerControl
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
            System.Windows.Forms.TabControl tabControl1;
            System.Windows.Forms.TabPage contractTab;
            System.Windows.Forms.TabPage productTab;
            System.Windows.Forms.TabPage orderTab;
            System.Windows.Forms.TabControl tabControl6;
            System.Windows.Forms.TabPage tabPage14;
            System.Windows.Forms.TabPage tabPage15;
            tabControl3 = new System.Windows.Forms.TabControl();
            tabPage2 = new System.Windows.Forms.TabPage();
            extendContractControl = new ExtendContractControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            viewContractControl = new ViewContractControl();
            tabControl4 = new System.Windows.Forms.TabControl();
            tabPage4 = new System.Windows.Forms.TabPage();
            addProductControl = new AddProductControl();
            tabPage5 = new System.Windows.Forms.TabPage();
            deleteProductControl = new DeleteProductControl();
            tabPage6 = new System.Windows.Forms.TabPage();
            updateProductControl = new UpdateProductControl();
            tabPage7 = new System.Windows.Forms.TabPage();
            updateProductAmountControl = new UpdateProductAmountControl();
            partnerViewOrderControl = new OrderControls.PartnerViewOrderControl();
            partnerStatisticsControl = new PartnerStatisticsControl();
            tabControl1 = new System.Windows.Forms.TabControl();
            contractTab = new System.Windows.Forms.TabPage();
            productTab = new System.Windows.Forms.TabPage();
            orderTab = new System.Windows.Forms.TabPage();
            tabControl6 = new System.Windows.Forms.TabControl();
            tabPage14 = new System.Windows.Forms.TabPage();
            tabPage15 = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            contractTab.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            productTab.SuspendLayout();
            tabControl4.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            orderTab.SuspendLayout();
            tabControl6.SuspendLayout();
            tabPage14.SuspendLayout();
            tabPage15.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(contractTab);
            tabControl1.Controls.Add(productTab);
            tabControl1.Controls.Add(orderTab);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(686, 497);
            tabControl1.TabIndex = 1;
            // 
            // contractTab
            // 
            contractTab.Controls.Add(tabControl3);
            contractTab.Location = new System.Drawing.Point(4, 29);
            contractTab.Name = "contractTab";
            contractTab.Padding = new System.Windows.Forms.Padding(3);
            contractTab.Size = new System.Drawing.Size(678, 464);
            contractTab.TabIndex = 1;
            contractTab.Text = "Hợp đồng";
            contractTab.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage2);
            tabControl3.Controls.Add(tabPage3);
            tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl3.Location = new System.Drawing.Point(3, 3);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new System.Drawing.Size(672, 458);
            tabControl3.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(extendContractControl);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(664, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gia hạn hợp đồng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // extendContractControl
            // 
            extendContractControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            extendContractControl.Dock = System.Windows.Forms.DockStyle.Fill;
            extendContractControl.Error = false;
            extendContractControl.Location = new System.Drawing.Point(3, 3);
            extendContractControl.Name = "extendContractControl";
            extendContractControl.Size = new System.Drawing.Size(658, 419);
            extendContractControl.TabIndex = 0;
            extendContractControl.Load += extendContractControl_Load;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(viewContractControl);
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(664, 425);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Xem hợp đồng";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // viewContractControl
            // 
            viewContractControl.CurrentID = 0;
            viewContractControl.Dock = System.Windows.Forms.DockStyle.Fill;
            viewContractControl.Location = new System.Drawing.Point(0, 0);
            viewContractControl.Name = "viewContractControl";
            viewContractControl.Size = new System.Drawing.Size(664, 425);
            viewContractControl.TabIndex = 0;
            // 
            // productTab
            // 
            productTab.Controls.Add(tabControl4);
            productTab.Location = new System.Drawing.Point(4, 29);
            productTab.Name = "productTab";
            productTab.Size = new System.Drawing.Size(192, 67);
            productTab.TabIndex = 2;
            productTab.Text = "Sản phẩm";
            productTab.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            tabControl4.Controls.Add(tabPage4);
            tabControl4.Controls.Add(tabPage5);
            tabControl4.Controls.Add(tabPage6);
            tabControl4.Controls.Add(tabPage7);
            tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl4.Location = new System.Drawing.Point(0, 0);
            tabControl4.Name = "tabControl4";
            tabControl4.SelectedIndex = 0;
            tabControl4.Size = new System.Drawing.Size(192, 67);
            tabControl4.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(addProductControl);
            tabPage4.Location = new System.Drawing.Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(184, 34);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Thêm sản phẩm";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // addProductControl
            // 
            addProductControl.Dock = System.Windows.Forms.DockStyle.Fill;
            addProductControl.Location = new System.Drawing.Point(3, 3);
            addProductControl.Name = "addProductControl";
            addProductControl.Size = new System.Drawing.Size(178, 28);
            addProductControl.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(deleteProductControl);
            tabPage5.Location = new System.Drawing.Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(3);
            tabPage5.Size = new System.Drawing.Size(192, 67);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Xóa sản phẩm";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // deleteProductControl
            // 
            deleteProductControl.Dock = System.Windows.Forms.DockStyle.Fill;
            deleteProductControl.Location = new System.Drawing.Point(3, 3);
            deleteProductControl.Name = "deleteProductControl";
            deleteProductControl.Size = new System.Drawing.Size(186, 61);
            deleteProductControl.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(updateProductControl);
            tabPage6.Location = new System.Drawing.Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new System.Drawing.Size(192, 67);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Cập nhật thông tin sản phẩm";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // updateProductControl
            // 
            updateProductControl.Dock = System.Windows.Forms.DockStyle.Fill;
            updateProductControl.Location = new System.Drawing.Point(0, 0);
            updateProductControl.Name = "updateProductControl";
            updateProductControl.Size = new System.Drawing.Size(192, 67);
            updateProductControl.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(updateProductAmountControl);
            tabPage7.Location = new System.Drawing.Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new System.Drawing.Size(192, 67);
            tabPage7.TabIndex = 3;
            tabPage7.Text = "Cập nhật số lượng sản phẩm";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // updateProductAmountControl
            // 
            updateProductAmountControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            updateProductAmountControl.Dock = System.Windows.Forms.DockStyle.Fill;
            updateProductAmountControl.Error = false;
            updateProductAmountControl.Location = new System.Drawing.Point(0, 0);
            updateProductAmountControl.Name = "updateProductAmountControl";
            updateProductAmountControl.Size = new System.Drawing.Size(192, 67);
            updateProductAmountControl.TabIndex = 0;
            // 
            // orderTab
            // 
            orderTab.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            orderTab.Controls.Add(tabControl6);
            orderTab.Location = new System.Drawing.Point(4, 29);
            orderTab.Name = "orderTab";
            orderTab.Size = new System.Drawing.Size(192, 67);
            orderTab.TabIndex = 3;
            orderTab.Text = "Đơn hàng";
            // 
            // tabControl6
            // 
            tabControl6.Controls.Add(tabPage14);
            tabControl6.Controls.Add(tabPage15);
            tabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl6.Location = new System.Drawing.Point(0, 0);
            tabControl6.Name = "tabControl6";
            tabControl6.SelectedIndex = 0;
            tabControl6.Size = new System.Drawing.Size(192, 67);
            tabControl6.TabIndex = 0;
            // 
            // tabPage14
            // 
            tabPage14.Controls.Add(partnerViewOrderControl);
            tabPage14.Location = new System.Drawing.Point(4, 29);
            tabPage14.Name = "tabPage14";
            tabPage14.Padding = new System.Windows.Forms.Padding(3);
            tabPage14.Size = new System.Drawing.Size(184, 34);
            tabPage14.TabIndex = 0;
            tabPage14.Text = "Xem đơn hàng";
            tabPage14.UseVisualStyleBackColor = true;
            // 
            // partnerViewOrderControl
            // 
            partnerViewOrderControl.BackColor = System.Drawing.Color.Black;
            partnerViewOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            partnerViewOrderControl.ForeColor = System.Drawing.Color.Black;
            partnerViewOrderControl.Location = new System.Drawing.Point(3, 3);
            partnerViewOrderControl.Name = "partnerViewOrderControl";
            partnerViewOrderControl.Size = new System.Drawing.Size(178, 28);
            partnerViewOrderControl.TabIndex = 0;
            // 
            // tabPage15
            // 
            tabPage15.Controls.Add(partnerStatisticsControl);
            tabPage15.Location = new System.Drawing.Point(4, 29);
            tabPage15.Name = "tabPage15";
            tabPage15.Padding = new System.Windows.Forms.Padding(3);
            tabPage15.Size = new System.Drawing.Size(184, 34);
            tabPage15.TabIndex = 1;
            tabPage15.Text = "Thống kê đơn hàng";
            tabPage15.UseVisualStyleBackColor = true;
            // 
            // partnerStatisticsControl
            // 
            partnerStatisticsControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            partnerStatisticsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            partnerStatisticsControl.Error = false;
            partnerStatisticsControl.Location = new System.Drawing.Point(3, 3);
            partnerStatisticsControl.Name = "partnerStatisticsControl";
            partnerStatisticsControl.Size = new System.Drawing.Size(178, 28);
            partnerStatisticsControl.TabIndex = 0;
            // 
            // PartnerControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "PartnerControl";
            Size = new System.Drawing.Size(686, 497);
            tabControl1.ResumeLayout(false);
            contractTab.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            productTab.ResumeLayout(false);
            tabControl4.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            orderTab.ResumeLayout(false);
            tabControl6.ResumeLayout(false);
            tabPage14.ResumeLayout(false);
            tabPage15.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage2;
        private ExtendContractControl extendContractControl;
        private System.Windows.Forms.TabPage tabPage3;
        private ViewContractControl viewContractControl;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private AddProductControl addProductControl;
        private DeleteProductControl deleteProductControl;
        private UpdateProductControl updateProductControl;
        private UpdateProductAmountControl updateProductAmountControl;
        private OrderControls.PartnerViewOrderControl partnerViewOrderControl;
        private PartnerStatisticsControl partnerStatisticsControl;
    }
}
