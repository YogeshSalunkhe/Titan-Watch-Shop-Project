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
    public partial class frm_Add_Category : Form
    {
        public frm_Add_Category()
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

        int Auto_Incr()
        {
            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Con_Open();

            Cmd.CommandText = "Select Count(Category_ID) from Category_Details";
            Cmd.Connection = Con;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cnt = Cnt + 101;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();
            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Category_ID.Text = Convert.ToString(Auto_Incr());
            tb_Category_Name.Text = "";
        }

        private void frm_Add_Category_Load(object sender, EventArgs e)
        {
            tb_Category_Name.Focus();
            tb_Category_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Category_ID.Text != "" && tb_Category_Name.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert Into Category_Details Values ('" + tb_Category_Name.Text + "') ", Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Record Saved Successfully");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!");
            }

            Con_Close();
        }
    }
}
