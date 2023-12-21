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
    public partial class frm_Update_Watch_Details : Form
    {
        public frm_Update_Watch_Details()
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

        void Clear_Controls()
        {
            tb_Watch_ID.Text = "";

            tb_Model_Name.Clear();
            tb_Purchase_Rate.Clear();
            tb_Sales_Rate.Clear();
            tb_Category.Clear();

            tb_Watch_ID.Enabled = true;
            tb_Watch_ID.Focus();
        }

        private void frm_Update_Watch_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * From Watch_Model_Details where Watch_ID = " + tb_Watch_ID.Text + " ", Con);

            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Category.Text = obj.GetString(obj.GetOrdinal("Watch_Category"));
                tb_Model_Name.Text = obj.GetString(obj.GetOrdinal("Watch_Category"));

                tb_Purchase_Rate.Text = (obj["Purchase_Rate"].ToString());
                tb_Sales_Rate.Text = (obj["Sales_Rate"].ToString());
                tb_Watch_ID.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid Watch ID!!!");
                Clear_Controls();
            }
            obj.Dispose();
            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Watch_ID.Text != "" && tb_Category.Text != "" && tb_Model_Name.Text != "" && tb_Sales_Rate.Text != "" && tb_Purchase_Rate.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Update Watch_Model_Details Set Purchase_Rate = '" + tb_Purchase_Rate.Text + "', Sales_Rate = " + tb_Sales_Rate.Text + " where Watch_ID = " + tb_Watch_ID.Text + "", Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Watch Details Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Enter Valid Watch ID & Set Prices Then Click Update","Incomplete Info",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Watch_ID.Text != "" || tb_Category.Text != "" || tb_Model_Name.Text != "" || tb_Sales_Rate.Text != "" || tb_Purchase_Rate.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
