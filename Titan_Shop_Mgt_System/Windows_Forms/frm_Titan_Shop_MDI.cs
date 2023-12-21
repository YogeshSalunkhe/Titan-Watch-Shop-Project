using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Titan_Shop_Mgt_System.Windows_Forms
{
    public partial class frm_Titan_Shop_MDI : Form
    {
        public frm_Titan_Shop_MDI()
        {
            InitializeComponent();
        }

        private void frm_Titan_Shop_MDI_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_Uname.Text = "Welcome " + Global_Vars.Uname;

            if (Global_Vars.URole == 1)
            {
                addWatchCategoryToolStripMenuItem.Visible = true;
                addNewWatchDetailsToolStripMenuItem.Visible = true;
                updateWatchDetailsToolStripMenuItem.Visible = true;
                userManagementToolStripMenuItem.Visible = true;
            }
            else if (Global_Vars.URole == 2)
            {
                 userManagementToolStripMenuItem.Visible = true;
            }
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Customer obj = new frm_Add_New_Customer();
            pb_Main.Hide();
            pb_Title.Hide();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addWatchCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Category obj = new frm_Add_Category();

            obj.MdiParent = this;
            //obj.WindowState = FormWindowState.Maximized;
            //obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void addNewWatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Model obj = new frm_Add_New_Model();
            pb_Main.Hide();
            pb_Title.Hide();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateWatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Watch_Details obj = new frm_Update_Watch_Details();
            pb_Main.Hide();
            pb_Title.Hide();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewWatchesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Watch_List obj = new frm_View_Watch_List();
            pb_Main.Hide();
            pb_Title.Hide();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Watch_Stock obj = new frm_Add_Watch_Stock();
            pb_Main.Hide();
            pb_Title.Hide();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Stock_Details obj = new frm_View_Stock_Details();
            pb_Main.Hide();
            pb_Title.Hide();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_User_Management obj = new frm_User_Management();
            pb_Main.Hide();
            pb_Title.Hide();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;

            obj.UserMgt.SelectedIndex = 0;
            obj.Show();
        }

        private void updatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_User_Management obj = new frm_User_Management();
            pb_Main.Hide();
            pb_Title.Hide();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;

            obj.UserMgt.SelectedIndex = 1;
            obj.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_User_Management obj = new frm_User_Management();
            pb_Main.Hide();
            pb_Title.Hide();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;

            obj.UserMgt.SelectedIndex = 2;
            obj.Show();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            Global_Vars.Uname = "";

            addWatchCategoryToolStripMenuItem.Visible = false;
            addNewWatchDetailsToolStripMenuItem.Visible = false;
            updateWatchDetailsToolStripMenuItem.Visible = false;
            userManagementToolStripMenuItem.Visible = false;

            Global_Vars.URole = 0;

            obj.Show();
            this.Hide();
        }

        private void monthlyCustomerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Report obj = new Customer_Report();
           // obj.Show();
            this.Hide();
        }

        private void monthlySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Report obj = new Stock_Report();
           // obj.Show();
            this.Hide();
        }
    }
}
