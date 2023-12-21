namespace Titan_Shop_Mgt_System.Windows_Forms
{
    partial class frm_Titan_Shop_MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Titan_Shop_MDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWatchCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewWatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateWatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWatchesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyCustomerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlySalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Logged_In_Uname = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.pb_Main = new System.Windows.Forms.PictureBox();
            this.pb_Title = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Title)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip.Font = new System.Drawing.Font("Rockwell", 12F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.watchesToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1485, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // watchesToolStripMenuItem
            // 
            this.watchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWatchCategoryToolStripMenuItem,
            this.addNewWatchDetailsToolStripMenuItem,
            this.updateWatchDetailsToolStripMenuItem,
            this.viewWatchesListToolStripMenuItem});
            this.watchesToolStripMenuItem.Name = "watchesToolStripMenuItem";
            this.watchesToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.watchesToolStripMenuItem.Text = "Watches";
            // 
            // addWatchCategoryToolStripMenuItem
            // 
            this.addWatchCategoryToolStripMenuItem.Name = "addWatchCategoryToolStripMenuItem";
            this.addWatchCategoryToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.addWatchCategoryToolStripMenuItem.Text = "Add Watch Category";
            this.addWatchCategoryToolStripMenuItem.Visible = false;
            this.addWatchCategoryToolStripMenuItem.Click += new System.EventHandler(this.addWatchCategoryToolStripMenuItem_Click);
            // 
            // addNewWatchDetailsToolStripMenuItem
            // 
            this.addNewWatchDetailsToolStripMenuItem.Name = "addNewWatchDetailsToolStripMenuItem";
            this.addNewWatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.addNewWatchDetailsToolStripMenuItem.Text = "Add New Watch Details";
            this.addNewWatchDetailsToolStripMenuItem.Visible = false;
            this.addNewWatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.addNewWatchDetailsToolStripMenuItem_Click);
            // 
            // updateWatchDetailsToolStripMenuItem
            // 
            this.updateWatchDetailsToolStripMenuItem.Name = "updateWatchDetailsToolStripMenuItem";
            this.updateWatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.updateWatchDetailsToolStripMenuItem.Text = "Update Watch Details";
            this.updateWatchDetailsToolStripMenuItem.Visible = false;
            this.updateWatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateWatchDetailsToolStripMenuItem_Click);
            // 
            // viewWatchesListToolStripMenuItem
            // 
            this.viewWatchesListToolStripMenuItem.Name = "viewWatchesListToolStripMenuItem";
            this.viewWatchesListToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.viewWatchesListToolStripMenuItem.Text = "View Watches List ";
            this.viewWatchesListToolStripMenuItem.Click += new System.EventHandler(this.viewWatchesListToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStockToolStripMenuItem,
            this.viewStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
            // 
            // viewStockToolStripMenuItem
            // 
            this.viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            this.viewStockToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.viewStockToolStripMenuItem.Text = "View Stock";
            this.viewStockToolStripMenuItem.Click += new System.EventHandler(this.viewStockToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.updatePasswordToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Visible = false;
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // updatePasswordToolStripMenuItem
            // 
            this.updatePasswordToolStripMenuItem.Name = "updatePasswordToolStripMenuItem";
            this.updatePasswordToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.updatePasswordToolStripMenuItem.Text = "Update Password";
            this.updatePasswordToolStripMenuItem.Click += new System.EventHandler(this.updatePasswordToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyCustomerReportToolStripMenuItem,
            this.monthlySalesToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // monthlyCustomerReportToolStripMenuItem
            // 
            this.monthlyCustomerReportToolStripMenuItem.Name = "monthlyCustomerReportToolStripMenuItem";
            this.monthlyCustomerReportToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.monthlyCustomerReportToolStripMenuItem.Text = "Customer Report";
            this.monthlyCustomerReportToolStripMenuItem.Click += new System.EventHandler(this.monthlyCustomerReportToolStripMenuItem_Click);
            // 
            // monthlySalesToolStripMenuItem
            // 
            this.monthlySalesToolStripMenuItem.Name = "monthlySalesToolStripMenuItem";
            this.monthlySalesToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.monthlySalesToolStripMenuItem.Text = "Stock Reports";
            this.monthlySalesToolStripMenuItem.Click += new System.EventHandler(this.monthlySalesToolStripMenuItem_Click);
            // 
            // lbl_Logged_In_Uname
            // 
            this.lbl_Logged_In_Uname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Logged_In_Uname.AutoSize = true;
            this.lbl_Logged_In_Uname.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_Logged_In_Uname.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_In_Uname.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Logged_In_Uname.Location = new System.Drawing.Point(1135, 4);
            this.lbl_Logged_In_Uname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Logged_In_Uname.Name = "lbl_Logged_In_Uname";
            this.lbl_Logged_In_Uname.Size = new System.Drawing.Size(166, 28);
            this.lbl_Logged_In_Uname.TabIndex = 1;
            this.lbl_Logged_In_Uname.Text = "Logged In User";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Log_Out.BackColor = System.Drawing.Color.Lime;
            this.btn_Log_Out.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Azure;
            this.btn_Log_Out.Location = new System.Drawing.Point(1388, 0);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(97, 36);
            this.btn_Log_Out.TabIndex = 0;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // pb_Main
            // 
            this.pb_Main.Image = ((System.Drawing.Image)(resources.GetObject("pb_Main.Image")));
            this.pb_Main.Location = new System.Drawing.Point(0, 33);
            this.pb_Main.Name = "pb_Main";
            this.pb_Main.Padding = new System.Windows.Forms.Padding(5);
            this.pb_Main.Size = new System.Drawing.Size(1485, 804);
            this.pb_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Main.TabIndex = 4;
            this.pb_Main.TabStop = false;
            // 
            // pb_Title
            // 
            this.pb_Title.Image = ((System.Drawing.Image)(resources.GetObject("pb_Title.Image")));
            this.pb_Title.Location = new System.Drawing.Point(78, 43);
            this.pb_Title.Name = "pb_Title";
            this.pb_Title.Size = new System.Drawing.Size(1314, 67);
            this.pb_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Title.TabIndex = 5;
            this.pb_Title.TabStop = false;
            // 
            // frm_Titan_Shop_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 838);
            this.Controls.Add(this.pb_Title);
            this.Controls.Add(this.pb_Main);
            this.Controls.Add(this.lbl_Logged_In_Uname);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Titan_Shop_MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titan_Shop_MDI";
            this.Load += new System.EventHandler(this.frm_Titan_Shop_MDI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Logged_In_Uname;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWatchCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewWatchDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateWatchDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWatchesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyCustomerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlySalesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_Main;
        private System.Windows.Forms.PictureBox pb_Title;
    }
}



