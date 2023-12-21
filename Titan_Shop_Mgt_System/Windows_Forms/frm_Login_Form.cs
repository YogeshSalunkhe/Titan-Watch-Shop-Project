using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Titan_Shop_Mgt_System.Windows_Forms
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source = Aadii; Initial Catalog = Titan_Watch_Shop_Mgt_System_DB; Integrated Security = True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void frm_Login_Form_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
            lbl_Note.Text = "Please Enter Your Login Details";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(*) from Login where Username = '" + tb_Username.Text + "' And Password = '" + tb_Password.Text + "'", Con);

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                lbl_Note.Visible = false;

                MessageBox.Show("Login Successful");
                Global_Vars.Uname = tb_Username.Text;

                if (tb_Username.Text == "Admin")
                {
                    Global_Vars.URole = 1;
                }
                else if (tb_Username.Text == "Manager")
                {
                    Global_Vars.URole = 2;
                }

                frm_Titan_Shop_MDI obj = new frm_Titan_Shop_MDI();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Visible = true;
                lbl_Note.Text = "Invalid Username Or Password";
                lbl_Note.ForeColor = Color.Red;
            }
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus();

            Con_Close();
        }
    }
}
