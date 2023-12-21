namespace Titan_Shop_Mgt_System.Windows_Forms
{
    partial class frm_Add_Watch_Stock
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gb_Watch_Details = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Model_Name = new System.Windows.Forms.TextBox();
            this.tb_Current_Stock = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtp_Stock_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Category = new System.Windows.Forms.TextBox();
            this.tb_Watch_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Stock_Details = new System.Windows.Forms.GroupBox();
            this.tb_Add_Stock = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.btn_Update_Stock = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.gb_Watch_Details.SuspendLayout();
            this.gb_Stock_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.Panel1.Controls.Add(this.lbl_Title);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1114, 58);
            this.Panel1.TabIndex = 44;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Californian FB", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Title.Location = new System.Drawing.Point(414, 6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(302, 47);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "Add Watch Stock";
            // 
            // gb_Watch_Details
            // 
            this.gb_Watch_Details.BackColor = System.Drawing.Color.Linen;
            this.gb_Watch_Details.Controls.Add(this.btn_Search);
            this.gb_Watch_Details.Controls.Add(this.tb_Model_Name);
            this.gb_Watch_Details.Controls.Add(this.tb_Current_Stock);
            this.gb_Watch_Details.Controls.Add(this.Label5);
            this.gb_Watch_Details.Controls.Add(this.Label4);
            this.gb_Watch_Details.Controls.Add(this.Label2);
            this.gb_Watch_Details.Controls.Add(this.dtp_Stock_Date);
            this.gb_Watch_Details.Controls.Add(this.tb_Category);
            this.gb_Watch_Details.Controls.Add(this.tb_Watch_ID);
            this.gb_Watch_Details.Controls.Add(this.label3);
            this.gb_Watch_Details.Controls.Add(this.label1);
            this.gb_Watch_Details.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Watch_Details.Location = new System.Drawing.Point(12, 74);
            this.gb_Watch_Details.Name = "gb_Watch_Details";
            this.gb_Watch_Details.Size = new System.Drawing.Size(1090, 352);
            this.gb_Watch_Details.TabIndex = 45;
            this.gb_Watch_Details.TabStop = false;
            this.gb_Watch_Details.Text = "Watch Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Search.Location = new System.Drawing.Point(376, 65);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(88, 39);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Model_Name
            // 
            this.tb_Model_Name.Enabled = false;
            this.tb_Model_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Model_Name.Location = new System.Drawing.Point(814, 189);
            this.tb_Model_Name.MaxLength = 5;
            this.tb_Model_Name.Name = "tb_Model_Name";
            this.tb_Model_Name.Size = new System.Drawing.Size(200, 25);
            this.tb_Model_Name.TabIndex = 72;
            // 
            // tb_Current_Stock
            // 
            this.tb_Current_Stock.Enabled = false;
            this.tb_Current_Stock.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock.Location = new System.Drawing.Point(566, 279);
            this.tb_Current_Stock.MaxLength = 5;
            this.tb_Current_Stock.Name = "tb_Current_Stock";
            this.tb_Current_Stock.Size = new System.Drawing.Size(200, 25);
            this.tb_Current_Stock.TabIndex = 70;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(348, 280);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(116, 21);
            this.Label5.TabIndex = 71;
            this.Label5.Text = "Current Stock";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(619, 190);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(107, 21);
            this.Label4.TabIndex = 66;
            this.Label4.Text = "Model Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(619, 74);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(131, 21);
            this.Label2.TabIndex = 65;
            this.Label2.Text = "Stock Add Date";
            // 
            // dtp_Stock_Date
            // 
            this.dtp_Stock_Date.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.dtp_Stock_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Stock_Date.Location = new System.Drawing.Point(814, 72);
            this.dtp_Stock_Date.Name = "dtp_Stock_Date";
            this.dtp_Stock_Date.Size = new System.Drawing.Size(200, 25);
            this.dtp_Stock_Date.TabIndex = 2;
            // 
            // tb_Category
            // 
            this.tb_Category.Enabled = false;
            this.tb_Category.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category.Location = new System.Drawing.Point(154, 186);
            this.tb_Category.MaxLength = 20;
            this.tb_Category.Name = "tb_Category";
            this.tb_Category.Size = new System.Drawing.Size(200, 25);
            this.tb_Category.TabIndex = 3;
            // 
            // tb_Watch_ID
            // 
            this.tb_Watch_ID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Watch_ID.Location = new System.Drawing.Point(154, 72);
            this.tb_Watch_ID.MaxLength = 5;
            this.tb_Watch_ID.Name = "tb_Watch_ID";
            this.tb_Watch_ID.Size = new System.Drawing.Size(200, 25);
            this.tb_Watch_ID.TabIndex = 1;
            this.tb_Watch_ID.TextChanged += new System.EventHandler(this.tb_Watch_ID_TextChanged);
            this.tb_Watch_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Watch Id";
            // 
            // gb_Stock_Details
            // 
            this.gb_Stock_Details.BackColor = System.Drawing.Color.Linen;
            this.gb_Stock_Details.Controls.Add(this.tb_Add_Stock);
            this.gb_Stock_Details.Controls.Add(this.Label9);
            this.gb_Stock_Details.Location = new System.Drawing.Point(12, 443);
            this.gb_Stock_Details.Name = "gb_Stock_Details";
            this.gb_Stock_Details.Size = new System.Drawing.Size(1090, 116);
            this.gb_Stock_Details.TabIndex = 46;
            this.gb_Stock_Details.TabStop = false;
            this.gb_Stock_Details.Text = "Stock Details";
            // 
            // tb_Add_Stock
            // 
            this.tb_Add_Stock.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Add_Stock.ForeColor = System.Drawing.Color.Crimson;
            this.tb_Add_Stock.Location = new System.Drawing.Point(566, 49);
            this.tb_Add_Stock.MaxLength = 5;
            this.tb_Add_Stock.Name = "tb_Add_Stock";
            this.tb_Add_Stock.Size = new System.Drawing.Size(200, 27);
            this.tb_Add_Stock.TabIndex = 3;
            this.tb_Add_Stock.TextChanged += new System.EventHandler(this.tb_Add_Stock_TextChanged);
            this.tb_Add_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Crimson;
            this.Label9.Location = new System.Drawing.Point(348, 50);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(122, 24);
            this.Label9.TabIndex = 66;
            this.Label9.Text = "Stock Added";
            // 
            // btn_Update_Stock
            // 
            this.btn_Update_Stock.BackColor = System.Drawing.Color.White;
            this.btn_Update_Stock.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Stock.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Update_Stock.Location = new System.Drawing.Point(433, 586);
            this.btn_Update_Stock.Name = "btn_Update_Stock";
            this.btn_Update_Stock.Size = new System.Drawing.Size(182, 40);
            this.btn_Update_Stock.TabIndex = 4;
            this.btn_Update_Stock.Text = "Update Stock";
            this.btn_Update_Stock.UseVisualStyleBackColor = false;
            this.btn_Update_Stock.Click += new System.EventHandler(this.btn_Update_Stock_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Close.Location = new System.Drawing.Point(786, 586);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(110, 40);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Refresh.Location = new System.Drawing.Point(119, 588);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(110, 40);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_Watch_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Update_Stock);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.gb_Stock_Details);
            this.Controls.Add(this.gb_Watch_Details);
            this.Controls.Add(this.Panel1);
            this.Name = "frm_Add_Watch_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Watch Stock";
            this.Load += new System.EventHandler(this.frm_Add_Watch_Stock_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.gb_Watch_Details.ResumeLayout(false);
            this.gb_Watch_Details.PerformLayout();
            this.gb_Stock_Details.ResumeLayout(false);
            this.gb_Stock_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_Title;
        internal System.Windows.Forms.GroupBox gb_Watch_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Model_Name;
        private System.Windows.Forms.TextBox tb_Current_Stock;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dtp_Stock_Date;
        private System.Windows.Forms.TextBox tb_Category;
        private System.Windows.Forms.TextBox tb_Watch_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Stock_Details;
        private System.Windows.Forms.TextBox tb_Add_Stock;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Button btn_Update_Stock;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
    }
}