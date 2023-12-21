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
    public partial class frm_Add_Watch_Stock : Form
    {
        public frm_Add_Watch_Stock()
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


        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Watch_ID.Clear();
            tb_Model_Name.Clear();
            tb_Category.Clear();
            tb_Add_Stock.Clear();
            tb_Current_Stock.Clear();
        }

        void Controls_Disable()
        {
            btn_Search.Enabled = false;
            btn_Update_Stock.Enabled = false;
            tb_Watch_ID.Enabled = true;
        }

        private void frm_Add_Watch_Stock_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            Controls_Disable();
            tb_Watch_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * From Watch_Model_Details where Watch_ID = " + tb_Watch_ID.Text + " ", Con);

            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Category.Text = obj.GetString(obj.GetOrdinal("Watch_Category"));
                tb_Model_Name.Text = obj.GetString(obj.GetOrdinal("Watch_Model_Name"));
                tb_Current_Stock.Text = (obj["Current_Stock"].ToString());

                tb_Watch_ID.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid Watch ID!!!");
                tb_Watch_ID.Clear();
                tb_Watch_ID.Focus();
                btn_Search.Enabled = false;
            }
            obj.Dispose();
            Cmd.Dispose();
            Con_Close();
        }

        private void btn_Update_Stock_Click(object sender, EventArgs e)
        {
            Con_Open();

            int New_Stock = Convert.ToInt32(tb_Current_Stock.Text) + Convert.ToInt32(tb_Add_Stock.Text);

            if (tb_Watch_ID.Text != "" && tb_Model_Name.Text != "" && tb_Current_Stock.Text != "" && tb_Category.Text != "" && Convert.ToInt32(tb_Add_Stock.Text) > 0 )
            {
                SqlDataAdapter sda = new SqlDataAdapter("Update Watch_Model_Details Set Current_Stock = " + New_Stock + " where Watch_ID = " + tb_Watch_ID.Text + "", Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                SqlCommand cmd1 = new SqlCommand("Insert Into Stock_Updates Values (@Watch_ID, @Category, @Model_Name, @Stock_Date, @Stock_Added, @Stock_Receiver) ", Con);

                cmd1.Parameters.Add("@Watch_ID", SqlDbType.Int).Value = tb_Watch_ID.Text;
                cmd1.Parameters.Add("@Category", SqlDbType.NVarChar).Value = tb_Category.Text;
                cmd1.Parameters.Add("@Model_Name", SqlDbType.NVarChar).Value = tb_Model_Name.Text;
                cmd1.Parameters.Add("@Stock_Date", SqlDbType.Date).Value = dtp_Stock_Date.Value.Date;
                cmd1.Parameters.Add("@Stock_Added", SqlDbType.Int).Value = tb_Add_Stock.Text;
                cmd1.Parameters.Add("@Stock_Receiver", SqlDbType.NVarChar).Value = Global_Vars.Uname;

                cmd1.ExecuteNonQuery();
                cmd1.Dispose();

                MessageBox.Show("Stock Updated Successfully");
                Clear_Controls();
                Controls_Disable();
                tb_Watch_ID.Enabled = true;
            }
            else
            {
                MessageBox.Show("1st Fill Valid Values!!!");
            }

            Con_Close();
        }

        private void tb_Watch_ID_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void tb_Add_Stock_TextChanged(object sender, EventArgs e)
        {
            btn_Update_Stock.Enabled = true;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Controls_Disable();
            tb_Watch_ID.Focus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (tb_Watch_ID.Text != "" || tb_Add_Stock.Text != "" || tb_Model_Name.Text != "")
            {
                MessageBox.Show("Are You Sure? Data Entered will be lost");
            }

            this.Close();
        }
    }
}
