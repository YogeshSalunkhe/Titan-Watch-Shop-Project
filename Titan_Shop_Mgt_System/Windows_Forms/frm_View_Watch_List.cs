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
    public partial class frm_View_Watch_List : Form
    {
        public frm_View_Watch_List()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=Aadii;Initial Catalog=Titan_Watch_Shop_Mgt_System_DB;Integrated Security=True");

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

        void Bind_Grid(string Query)
        {
            Con_Open();

            dgv_Watch_Details.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_Watch_Details.DataSource = dt;

            Con_Close();
        }

        private void frm_View_Watch_List_Load(object sender, EventArgs e)
        {
            cmb_Category.SelectedIndex = -1;
            cmb_Model_Name.SelectedIndex = -1;
            Bind_Grid("Select * from Watch_Model_Details");

            Con_Open();

            cmb_Category.Items.Clear();

            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText = "Select Distinct(Category_Name) From Category_Details";
            Cmd.Connection = Con;

            SqlDataReader obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }

            obj.Dispose();
            Cmd.Dispose();

            Con_Close();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText = "Select Distinct(Watch_Model_Name) From Watch_Model_Details where Watch_Category = '" + cmb_Category.Text + "'";
            Cmd.Connection = Con;

            SqlDataReader obj = Cmd.ExecuteReader();

            cmb_Model_Name.Items.Clear();

            while (obj.Read())
            {
                cmb_Model_Name.Items.Add(obj.GetString(obj.GetOrdinal("Watch_Model_Name")));
            }

            obj.Dispose();
            Cmd.Dispose();

            Bind_Grid("Select * from Watch_Model_Details Where Watch_Category = '" + cmb_Category.Text + "'");

            Con_Close();
        }

        private void cmb_Model_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Watch_Model_Details Where Watch_Category = '" + cmb_Category.Text + "' And Watch_Model_Name = '" + cmb_Model_Name.Text + "'");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Category.SelectedIndex = -1;
            cmb_Model_Name.SelectedIndex = -1;
            Bind_Grid("Select * from Watch_Model_Details");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want TO Close this Form?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
