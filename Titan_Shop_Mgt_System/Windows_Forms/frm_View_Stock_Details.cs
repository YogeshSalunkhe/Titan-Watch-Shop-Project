using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Titan_Shop_Mgt_System
{
    public partial class frm_View_Stock_Details : Form
    {
        public frm_View_Stock_Details()
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

        void Bind_Grid(string Query)
        {
            Con_Open();

            dgv_Stock_Updates.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_Stock_Updates.DataSource = dt;

            Con_Close();
        }

        private void frm_View_Stock_Details_Load(object sender, EventArgs e)
        {
            int C_Month = System.DateTime.Today.Month;
            int C_Year = System.DateTime.Today.Year;

            cmb_Year.Text = Convert.ToString(C_Year);
            cmb_Month.SelectedIndex = C_Month - 1;
        }

        void Load_Data()
        {
            if (cmb_Month.SelectedIndex >= 0 && cmb_Year.SelectedIndex >= 0)
            {
                int C_Month = cmb_Month.SelectedIndex + 1;
                int C_Year = Convert.ToInt32(cmb_Year.Text);

                Bind_Grid("Select * from Stock_Updates Where Month(Stock_Added_Date) = " + C_Month + " And Year(Stock_Added_Date) = " + C_Year + " ");
            }
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            int C_Month = System.DateTime.Today.Month;
            int C_Year = System.DateTime.Today.Year;

            cmb_Year.Text = Convert.ToString(C_Year);
            cmb_Month.SelectedIndex = C_Month - 1;
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
