namespace Titan_Shop_Mgt_System.Windows_Forms
{
    partial class frm_User_Management
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
            this.UserMgt = new System.Windows.Forms.TabControl();
            this.tab_Add_New_User = new System.Windows.Forms.TabPage();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_C_Password = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tab_Change_Password = new System.Windows.Forms.TabPage();
            this.btn_Close_CP = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_New_Password = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tb_Current_Password = new System.Windows.Forms.TextBox();
            this.tb_Username_CP = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.tab_Delete_User = new System.Windows.Forms.TabPage();
            this.btn_Close_Dlt = new System.Windows.Forms.Button();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.tb_Admin_Password = new System.Windows.Forms.TextBox();
            this.tb_D_Username = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.UserMgt.SuspendLayout();
            this.tab_Add_New_User.SuspendLayout();
            this.tab_Change_Password.SuspendLayout();
            this.tab_Delete_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.Panel1.Controls.Add(this.lbl_Title);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1485, 71);
            this.Panel1.TabIndex = 44;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Californian FB", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Title.Location = new System.Drawing.Point(544, 7);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(394, 58);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "User Management";
            // 
            // UserMgt
            // 
            this.UserMgt.Controls.Add(this.tab_Add_New_User);
            this.UserMgt.Controls.Add(this.tab_Change_Password);
            this.UserMgt.Controls.Add(this.tab_Delete_User);
            this.UserMgt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserMgt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserMgt.Location = new System.Drawing.Point(0, 79);
            this.UserMgt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserMgt.Name = "UserMgt";
            this.UserMgt.SelectedIndex = 0;
            this.UserMgt.Size = new System.Drawing.Size(1485, 735);
            this.UserMgt.TabIndex = 45;
            // 
            // tab_Add_New_User
            // 
            this.tab_Add_New_User.BackColor = System.Drawing.Color.Linen;
            this.tab_Add_New_User.Controls.Add(this.btn_Close);
            this.tab_Add_New_User.Controls.Add(this.btn_Submit);
            this.tab_Add_New_User.Controls.Add(this.tb_C_Password);
            this.tab_Add_New_User.Controls.Add(this.Label7);
            this.tab_Add_New_User.Controls.Add(this.tb_Password);
            this.tab_Add_New_User.Controls.Add(this.tb_Username);
            this.tab_Add_New_User.Controls.Add(this.Label5);
            this.tab_Add_New_User.Controls.Add(this.Label6);
            this.tab_Add_New_User.Controls.Add(this.Label2);
            this.tab_Add_New_User.Location = new System.Drawing.Point(4, 31);
            this.tab_Add_New_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Add_New_User.Name = "tab_Add_New_User";
            this.tab_Add_New_User.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Add_New_User.Size = new System.Drawing.Size(1477, 700);
            this.tab_Add_New_User.TabIndex = 0;
            this.tab_Add_New_User.Text = "Add New User";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Close.Location = new System.Drawing.Point(929, 526);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(147, 49);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Submit.Location = new System.Drawing.Point(377, 526);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(173, 49);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_C_Password
            // 
            this.tb_C_Password.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_C_Password.Location = new System.Drawing.Point(972, 353);
            this.tb_C_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_C_Password.MaxLength = 8;
            this.tb_C_Password.Name = "tb_C_Password";
            this.tb_C_Password.Size = new System.Drawing.Size(344, 33);
            this.tb_C_Password.TabIndex = 3;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(236, 357);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(190, 25);
            this.Label7.TabIndex = 30;
            this.Label7.Text = "Confirm Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(972, 241);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(344, 33);
            this.tb_Password.TabIndex = 2;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(972, 143);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Username.MaxLength = 8;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(344, 33);
            this.tb_Username.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(236, 146);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(108, 25);
            this.Label5.TabIndex = 28;
            this.Label5.Text = "Username";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(236, 245);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(166, 25);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "Enter Password";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.Label2.ForeColor = System.Drawing.Color.Crimson;
            this.Label2.Location = new System.Drawing.Point(613, 18);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(266, 44);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Add New User";
            // 
            // tab_Change_Password
            // 
            this.tab_Change_Password.BackColor = System.Drawing.Color.Linen;
            this.tab_Change_Password.Controls.Add(this.btn_Close_CP);
            this.tab_Change_Password.Controls.Add(this.btn_Update);
            this.tab_Change_Password.Controls.Add(this.tb_New_Password);
            this.tab_Change_Password.Controls.Add(this.Label10);
            this.tab_Change_Password.Controls.Add(this.tb_Current_Password);
            this.tab_Change_Password.Controls.Add(this.tb_Username_CP);
            this.tab_Change_Password.Controls.Add(this.Label8);
            this.tab_Change_Password.Controls.Add(this.Label9);
            this.tab_Change_Password.Controls.Add(this.Label3);
            this.tab_Change_Password.Location = new System.Drawing.Point(4, 31);
            this.tab_Change_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Change_Password.Name = "tab_Change_Password";
            this.tab_Change_Password.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Change_Password.Size = new System.Drawing.Size(1477, 700);
            this.tab_Change_Password.TabIndex = 1;
            this.tab_Change_Password.Text = "Change Password";
            // 
            // btn_Close_CP
            // 
            this.btn_Close_CP.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_CP.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Close_CP.Location = new System.Drawing.Point(980, 527);
            this.btn_Close_CP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Close_CP.Name = "btn_Close_CP";
            this.btn_Close_CP.Size = new System.Drawing.Size(147, 49);
            this.btn_Close_CP.TabIndex = 10;
            this.btn_Close_CP.Text = "Close";
            this.btn_Close_CP.UseVisualStyleBackColor = true;
            this.btn_Close_CP.Click += new System.EventHandler(this.btn_Close_CP_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Update.Location = new System.Drawing.Point(271, 527);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(323, 49);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Update Password";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_New_Password
            // 
            this.tb_New_Password.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Password.Location = new System.Drawing.Point(953, 345);
            this.tb_New_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_New_Password.MaxLength = 8;
            this.tb_New_Password.Name = "tb_New_Password";
            this.tb_New_Password.PasswordChar = '*';
            this.tb_New_Password.Size = new System.Drawing.Size(351, 33);
            this.tb_New_Password.TabIndex = 8;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(185, 345);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(153, 25);
            this.Label10.TabIndex = 49;
            this.Label10.Text = "New Password";
            // 
            // tb_Current_Password
            // 
            this.tb_Current_Password.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Password.Location = new System.Drawing.Point(953, 247);
            this.tb_Current_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Current_Password.MaxLength = 8;
            this.tb_Current_Password.Name = "tb_Current_Password";
            this.tb_Current_Password.PasswordChar = '*';
            this.tb_Current_Password.Size = new System.Drawing.Size(351, 33);
            this.tb_Current_Password.TabIndex = 7;
            // 
            // tb_Username_CP
            // 
            this.tb_Username_CP.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username_CP.Location = new System.Drawing.Point(953, 150);
            this.tb_Username_CP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Username_CP.MaxLength = 8;
            this.tb_Username_CP.Name = "tb_Username_CP";
            this.tb_Username_CP.Size = new System.Drawing.Size(351, 33);
            this.tb_Username_CP.TabIndex = 6;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(185, 154);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(108, 25);
            this.Label8.TabIndex = 47;
            this.Label8.Text = "Username";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(185, 251);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(184, 25);
            this.Label9.TabIndex = 46;
            this.Label9.Text = "Current Password";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.Label3.ForeColor = System.Drawing.Color.Crimson;
            this.Label3.Location = new System.Drawing.Point(613, 18);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(314, 44);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "Change Password";
            // 
            // tab_Delete_User
            // 
            this.tab_Delete_User.BackColor = System.Drawing.Color.Linen;
            this.tab_Delete_User.Controls.Add(this.btn_Close_Dlt);
            this.tab_Delete_User.Controls.Add(this.btn_Delete_User);
            this.tab_Delete_User.Controls.Add(this.tb_Admin_Password);
            this.tab_Delete_User.Controls.Add(this.tb_D_Username);
            this.tab_Delete_User.Controls.Add(this.Label11);
            this.tab_Delete_User.Controls.Add(this.Label12);
            this.tab_Delete_User.Controls.Add(this.Label4);
            this.tab_Delete_User.Location = new System.Drawing.Point(4, 31);
            this.tab_Delete_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Delete_User.Name = "tab_Delete_User";
            this.tab_Delete_User.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Delete_User.Size = new System.Drawing.Size(1477, 700);
            this.tab_Delete_User.TabIndex = 2;
            this.tab_Delete_User.Text = "Delete User";
            // 
            // btn_Close_Dlt
            // 
            this.btn_Close_Dlt.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_Dlt.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Close_Dlt.Location = new System.Drawing.Point(919, 510);
            this.btn_Close_Dlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Close_Dlt.Name = "btn_Close_Dlt";
            this.btn_Close_Dlt.Size = new System.Drawing.Size(147, 49);
            this.btn_Close_Dlt.TabIndex = 59;
            this.btn_Close_Dlt.Text = "Close";
            this.btn_Close_Dlt.UseVisualStyleBackColor = true;
            this.btn_Close_Dlt.Click += new System.EventHandler(this.btn_Close_Dlt_Click);
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Delete_User.Location = new System.Drawing.Point(347, 510);
            this.btn_Delete_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(231, 49);
            this.btn_Delete_User.TabIndex = 58;
            this.btn_Delete_User.Text = "Delete User";
            this.btn_Delete_User.UseVisualStyleBackColor = true;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // tb_Admin_Password
            // 
            this.tb_Admin_Password.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Admin_Password.Location = new System.Drawing.Point(960, 314);
            this.tb_Admin_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Admin_Password.MaxLength = 8;
            this.tb_Admin_Password.Name = "tb_Admin_Password";
            this.tb_Admin_Password.PasswordChar = '*';
            this.tb_Admin_Password.Size = new System.Drawing.Size(295, 33);
            this.tb_Admin_Password.TabIndex = 53;
            // 
            // tb_D_Username
            // 
            this.tb_D_Username.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_D_Username.Location = new System.Drawing.Point(960, 166);
            this.tb_D_Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_D_Username.MaxLength = 8;
            this.tb_D_Username.Name = "tb_D_Username";
            this.tb_D_Username.Size = new System.Drawing.Size(295, 33);
            this.tb_D_Username.TabIndex = 52;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(305, 166);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(108, 25);
            this.Label11.TabIndex = 55;
            this.Label11.Text = "Username";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(305, 314);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(241, 25);
            this.Label12.TabIndex = 54;
            this.Label12.Text = "Enter Admin Password";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Crimson;
            this.Label4.Location = new System.Drawing.Point(613, 18);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(218, 44);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Delete User";
            // 
            // frm_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 814);
            this.ControlBox = false;
            this.Controls.Add(this.UserMgt);
            this.Controls.Add(this.Panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frm_User_Management_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.UserMgt.ResumeLayout(false);
            this.tab_Add_New_User.ResumeLayout(false);
            this.tab_Add_New_User.PerformLayout();
            this.tab_Change_Password.ResumeLayout(false);
            this.tab_Change_Password.PerformLayout();
            this.tab_Delete_User.ResumeLayout(false);
            this.tab_Delete_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_Title;
        internal System.Windows.Forms.TabControl UserMgt;
        internal System.Windows.Forms.TabPage tab_Add_New_User;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_C_Password;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TabPage tab_Change_Password;
        private System.Windows.Forms.Button btn_Close_CP;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_New_Password;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox tb_Current_Password;
        private System.Windows.Forms.TextBox tb_Username_CP;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TabPage tab_Delete_User;
        private System.Windows.Forms.Button btn_Close_Dlt;
        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.TextBox tb_Admin_Password;
        private System.Windows.Forms.TextBox tb_D_Username;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Label Label4;
    }
}