
namespace HQTCSDL_G6.Components.ShipperControl
{
    partial class ShipperControl
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
            System.Windows.Forms.TabPage tabPage11;
            System.Windows.Forms.TabPage tabPage12;
            System.Windows.Forms.TabPage tabPage13;
            acceptOrderControl = new AcceptOrderControl();
            updateOrderControl = new UpdateOrderControl();
            shipperViewStatisticsControl = new ShipperViewStatisticsControl();
            acceptOrderGridView = new System.Windows.Forms.TabControl();
            tabPage11 = new System.Windows.Forms.TabPage();
            tabPage12 = new System.Windows.Forms.TabPage();
            tabPage13 = new System.Windows.Forms.TabPage();
            tabPage11.SuspendLayout();
            tabPage12.SuspendLayout();
            tabPage13.SuspendLayout();
            acceptOrderGridView.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage11
            // 
            tabPage11.Controls.Add(acceptOrderControl);
            tabPage11.Location = new System.Drawing.Point(4, 24);
            tabPage11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage11.Name = "tabPage11";
            tabPage11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage11.Size = new System.Drawing.Size(478, 367);
            tabPage11.TabIndex = 0;
            tabPage11.Text = "Nhận đơn hàng";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // acceptOrderControl
            // 
            acceptOrderControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            acceptOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            acceptOrderControl.Error = false;
            acceptOrderControl.Location = new System.Drawing.Point(3, 2);
            acceptOrderControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            acceptOrderControl.Name = "acceptOrderControl";
            acceptOrderControl.Size = new System.Drawing.Size(472, 363);
            acceptOrderControl.TabIndex = 0;
            // 
            // tabPage12
            // 
            tabPage12.Controls.Add(updateOrderControl);
            tabPage12.Location = new System.Drawing.Point(4, 24);
            tabPage12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage12.Name = "tabPage12";
            tabPage12.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage12.Size = new System.Drawing.Size(478, 367);
            tabPage12.TabIndex = 1;
            tabPage12.Text = "Cập nhật đơn hàng";
            tabPage12.UseVisualStyleBackColor = true;
            // 
            // updateOrderControl
            // 
            updateOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            updateOrderControl.Location = new System.Drawing.Point(3, 2);
            updateOrderControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            updateOrderControl.Name = "updateOrderControl";
            updateOrderControl.Size = new System.Drawing.Size(472, 363);
            updateOrderControl.TabIndex = 0;
            // 
            // tabPage13
            // 
            tabPage13.Controls.Add(shipperViewStatisticsControl);
            tabPage13.Location = new System.Drawing.Point(4, 24);
            tabPage13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage13.Name = "tabPage13";
            tabPage13.Size = new System.Drawing.Size(478, 367);
            tabPage13.TabIndex = 2;
            tabPage13.Text = "Thống kê thu nhập";
            tabPage13.UseVisualStyleBackColor = true;
            // 
            // shipperViewStatisticsControl
            // 
            shipperViewStatisticsControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            shipperViewStatisticsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            shipperViewStatisticsControl.Error = false;
            shipperViewStatisticsControl.Location = new System.Drawing.Point(0, 0);
            shipperViewStatisticsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            shipperViewStatisticsControl.Name = "shipperViewStatisticsControl";
            shipperViewStatisticsControl.Size = new System.Drawing.Size(478, 367);
            shipperViewStatisticsControl.TabIndex = 0;
            // 
            // acceptOrderGridView
            // 
            acceptOrderGridView.Controls.Add(tabPage11);
            acceptOrderGridView.Controls.Add(tabPage12);
            acceptOrderGridView.Controls.Add(tabPage13);
            acceptOrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            acceptOrderGridView.Location = new System.Drawing.Point(0, 0);
            acceptOrderGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            acceptOrderGridView.Name = "acceptOrderGridView";
            acceptOrderGridView.SelectedIndex = 0;
            acceptOrderGridView.Size = new System.Drawing.Size(486, 395);
            acceptOrderGridView.TabIndex = 1;
            // 
            // ShipperControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(acceptOrderGridView);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "ShipperControl";
            Size = new System.Drawing.Size(486, 395);
            tabPage11.ResumeLayout(false);
            tabPage12.ResumeLayout(false);
            tabPage13.ResumeLayout(false);
            acceptOrderGridView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TabControl acceptOrderGridView;
        private AcceptOrderControl acceptOrderControl;
        private UpdateOrderControl updateOrderControl;
        private ShipperViewStatisticsControl shipperViewStatisticsControl;
    }
}
