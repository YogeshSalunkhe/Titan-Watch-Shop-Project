namespace Titan_Shop_Mgt_System.Windows_Forms
{
    partial class frm_Update_Watch_Details
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.tb_Sales_Rate = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Rate = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.tb_Model_Name = new System.Windows.Forms.TextBox();
            this.tb_Watch_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Category = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
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
            this.lbl_Title.Location = new System.Drawing.Point(372, 6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(375, 47);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "Update Watch Details";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Update.Location = new System.Drawing.Point(272, 591);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 40);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Close.Location = new System.Drawing.Point(710, 591);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(110, 40);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Linen;
            this.GroupBox1.Controls.Add(this.btn_Search);
            this.GroupBox1.Controls.Add(this.TextBox9);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.tb_Sales_Rate);
            this.GroupBox1.Controls.Add(this.tb_Purchase_Rate);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.tb_Category);
            this.GroupBox1.Controls.Add(this.tb_Model_Name);
            this.GroupBox1.Controls.Add(this.tb_Watch_ID);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(10, 71);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1093, 494);
            this.GroupBox1.TabIndex = 48;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Watch Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Search.Location = new System.Drawing.Point(558, 39);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 33);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // TextBox9
            // 
            this.TextBox9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox9.Location = new System.Drawing.Point(1027, 573);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(247, 25);
            this.TextBox9.TabIndex = 57;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(808, 574);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(60, 21);
            this.Label11.TabIndex = 69;
            this.Label11.Text = "Salary";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(605, 322);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(91, 21);
            this.Label8.TabIndex = 68;
            this.Label8.Text = "Sales Rate";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(605, 159);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(76, 21);
            this.Label5.TabIndex = 66;
            this.Label5.Text = "Category";
            // 
            // tb_Sales_Rate
            // 
            this.tb_Sales_Rate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Rate.Location = new System.Drawing.Point(812, 321);
            this.tb_Sales_Rate.MaxLength = 10;
            this.tb_Sales_Rate.Name = "tb_Sales_Rate";
            this.tb_Sales_Rate.Size = new System.Drawing.Size(200, 25);
            this.tb_Sales_Rate.TabIndex = 4;
            // 
            // tb_Purchase_Rate
            // 
            this.tb_Purchase_Rate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Rate.Location = new System.Drawing.Point(262, 321);
            this.tb_Purchase_Rate.MaxLength = 10;
            this.tb_Purchase_Rate.Name = "tb_Purchase_Rate";
            this.tb_Purchase_Rate.Size = new System.Drawing.Size(200, 25);
            this.tb_Purchase_Rate.TabIndex = 3;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(53, 322);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(123, 21);
            this.Label7.TabIndex = 61;
            this.Label7.Text = "Purchase Rate";
            // 
            // tb_Model_Name
            // 
            this.tb_Model_Name.Enabled = false;
            this.tb_Model_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Model_Name.Location = new System.Drawing.Point(262, 158);
            this.tb_Model_Name.MaxLength = 20;
            this.tb_Model_Name.Name = "tb_Model_Name";
            this.tb_Model_Name.Size = new System.Drawing.Size(200, 25);
            this.tb_Model_Name.TabIndex = 3;
            // 
            // tb_Watch_ID
            // 
            this.tb_Watch_ID.Enabled = false;
            this.tb_Watch_ID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Watch_ID.Location = new System.Drawing.Point(262, 44);
            this.tb_Watch_ID.MaxLength = 5;
            this.tb_Watch_ID.Name = "tb_Watch_ID";
            this.tb_Watch_ID.Size = new System.Drawing.Size(200, 25);
            this.tb_Watch_ID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Model Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Watch Id";
            // 
            // tb_Category
            // 
            this.tb_Category.Enabled = false;
            this.tb_Category.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category.Location = new System.Drawing.Point(812, 158);
            this.tb_Category.MaxLength = 20;
            this.tb_Category.Name = "tb_Category";
            this.tb_Category.Size = new System.Drawing.Size(200, 25);
            this.tb_Category.TabIndex = 3;
            // 
            // frm_Update_Watch_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel1);
            this.Name = "frm_Update_Watch_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Watch Details";
            this.Load += new System.EventHandler(this.frm_Update_Watch_Details_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox TextBox9;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox tb_Sales_Rate;
        private System.Windows.Forms.TextBox tb_Purchase_Rate;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox tb_Model_Name;
        private System.Windows.Forms.TextBox tb_Watch_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Category;
    }
}