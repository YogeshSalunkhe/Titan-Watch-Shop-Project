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
    public partial class frm_User_Management : Form
    {
        public frm_User_Management()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source= Aadii;Initial Catalog=Titan_Watch_Shop_Mgt_System_DB;Integrated Security=True");

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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd1 = new SqlCommand("Select Count(*) From Login where Username = '" + tb_Username.Text + "' ", Con);

            int Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show(" Use Different Username ", "Username Already Used", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tb_Username.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show(" Fill Username & Password First!!!", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tb_Password.Text == tb_C_Password.Text)
            {
                SqlCommand Cmd2 = new SqlCommand("Insert Into Login Values (@Uname, @Password) ", Con);

                Cmd2.Parameters.Add("@Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
                Cmd2.Parameters.Add("@Password", SqlDbType.NVarChar).Value = tb_C_Password.Text;

                Cmd2.ExecuteNonQuery();

                MessageBox.Show(" User Added Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_Username.Clear();
                tb_Password.Clear();
                tb_C_Password.Clear();
            }
            else
            {
                MessageBox.Show(" Password Didnot Match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Username.Text != "" || tb_Password.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Username_CP.Text == "" || tb_New_Password.Text == "" || tb_Current_Password.Text == "")
            {
                MessageBox.Show(" Fill Username & Password Details First!!!", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlCommand Cmd1 = new SqlCommand("Select * From Login where Username = '" + tb_Username_CP.Text + "' ", Con);

                int Cnt = Convert.ToInt32(Cmd1.ExecuteNonQuery());

                if (Cnt == 0)
                {
                    MessageBox.Show(" Invalid Username", "No User Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var Obj = Cmd1.ExecuteReader();

                    string pwd = "";

                    if (Obj.Read())
                    {
                        pwd = Obj.GetString(Obj.GetOrdinal("Password"));
                    }
                    Obj.Dispose();
                    Cmd1.Dispose();

                    if (tb_Current_Password.Text == pwd)
                    {
                        SqlCommand Cmd2 = new SqlCommand("Update Login Set Password = '" + tb_New_Password.Text + "' where Username = '" + tb_Username_CP.Text + "'", Con);

                        Cmd2.ExecuteNonQuery();

                        MessageBox.Show(" Password Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tb_Username_CP.Clear();
                        tb_Current_Password.Clear();
                        tb_New_Password.Clear();
                    }
                    else
                    {
                        MessageBox.Show(" Password Didnot Match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            Con_Close();
        }

        private void btn_Close_CP_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Username_CP.Text != "" || tb_Current_Password.Text != "" || tb_New_Password.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_D_Username.Text == "" || tb_Admin_Password.Text == "")
            {
                MessageBox.Show(" Fill Username & Password Details First!!!", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tb_D_Username.Text == "Admin")
            {
                MessageBox.Show(" Admin User Can't Be Deleted!!!", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand Cmd1 = new SqlCommand("Select * From Login where Username = 'Admin' ", Con);
                var Obj = Cmd1.ExecuteReader();

                string Admin_pwd = "";

                if (Obj.Read())
                {
                    Admin_pwd = Obj.GetString(Obj.GetOrdinal("Password"));
                }
                Obj.Dispose();
                Cmd1.Dispose();

                if (tb_Admin_Password.Text == Admin_pwd)
                {
                    SqlCommand Cmd2 = new SqlCommand("Delete From Login Where Username = '" + tb_D_Username.Text + "' ", Con);

                    Cmd2.ExecuteNonQuery();

                    MessageBox.Show(" User Deleted Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_D_Username.Clear();
                    tb_Admin_Password.Clear();
                }
                else
                {
                    MessageBox.Show(" Admin Password Didnot Match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Close_Dlt_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_D_Username.Text != "" || tb_Admin_Password.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frm_User_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
