
namespace HQTCSDL_Group01.Components.CustomerControl
{
    partial class CustomerControl
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
            System.Windows.Forms.TabControl tabControl5;
            System.Windows.Forms.TabPage tabPage8;
            System.Windows.Forms.TabPage tabPage9;
            System.Windows.Forms.TabPage tabPage10;
            createOrderControl = new CreateOrderControl();
            customerViewOrderControl = new CustomerViewOrderControl();
            customerOrderStatisticsControl = new CustomerOrderStatisticsControl();
            tabControl5 = new System.Windows.Forms.TabControl();
            tabPage8 = new System.Windows.Forms.TabPage();
            tabPage9 = new System.Windows.Forms.TabPage();
            tabPage10 = new System.Windows.Forms.TabPage();
            tabControl5.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage9.SuspendLayout();
            tabPage10.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl5
            // 
            tabControl5.Controls.Add(tabPage8);
            tabControl5.Controls.Add(tabPage9);
            tabControl5.Controls.Add(tabPage10);
            tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl5.Location = new System.Drawing.Point(0, 0);
            tabControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabControl5.Name = "tabControl5";
            tabControl5.SelectedIndex = 0;
            tabControl5.Size = new System.Drawing.Size(438, 415);
            tabControl5.TabIndex = 1;
            // 
            // tabPage8
            // 
            tabPage8.BackColor = System.Drawing.Color.FromArgb(254, 200, 28);
            tabPage8.Controls.Add(createOrderControl);
            tabPage8.Location = new System.Drawing.Point(4, 24);
            tabPage8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage8.Size = new System.Drawing.Size(430, 387);
            tabPage8.TabIndex = 0;
            tabPage8.Text = "Tạo đơn hàng";
            tabPage8.Click += tabPage8_Click;
            // 
            // createOrderControl
            // 
            createOrderControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            createOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            createOrderControl.Error = false;
            createOrderControl.Location = new System.Drawing.Point(3, 2);
            createOrderControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            createOrderControl.Name = "createOrderControl";
            createOrderControl.Size = new System.Drawing.Size(424, 383);
            createOrderControl.TabIndex = 0;
            createOrderControl.Load += createOrderControl_Load;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(customerViewOrderControl);
            tabPage9.Location = new System.Drawing.Point(4, 24);
            tabPage9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage9.Size = new System.Drawing.Size(192, 72);
            tabPage9.TabIndex = 1;
            tabPage9.Text = "Xem đơn hàng hiện tại";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // customerViewOrderControl
            // 
            customerViewOrderControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            customerViewOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            customerViewOrderControl.Error = false;
            customerViewOrderControl.Location = new System.Drawing.Point(3, 2);
            customerViewOrderControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            customerViewOrderControl.Name = "customerViewOrderControl";
            customerViewOrderControl.Size = new System.Drawing.Size(186, 68);
            customerViewOrderControl.TabIndex = 0;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(customerOrderStatisticsControl);
            tabPage10.Location = new System.Drawing.Point(4, 24);
            tabPage10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new System.Drawing.Size(192, 72);
            tabPage10.TabIndex = 2;
            tabPage10.Text = "Thống kê các đơn hàng";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // customerOrderStatisticsControl
            // 
            customerOrderStatisticsControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            customerOrderStatisticsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            customerOrderStatisticsControl.Error = false;
            customerOrderStatisticsControl.Location = new System.Drawing.Point(0, 0);
            customerOrderStatisticsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            customerOrderStatisticsControl.Name = "customerOrderStatisticsControl";
            customerOrderStatisticsControl.Size = new System.Drawing.Size(192, 72);
            customerOrderStatisticsControl.TabIndex = 0;
            customerOrderStatisticsControl.Load += customerOrderStatisticsControl_Load;
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl5);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "CustomerControl";
            Size = new System.Drawing.Size(438, 415);
            tabControl5.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            tabPage10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CreateOrderControl createOrderControl;
        private CustomerViewOrderControl customerViewOrderControl;
        private CustomerOrderStatisticsControl customerOrderStatisticsControl;
    }
}
