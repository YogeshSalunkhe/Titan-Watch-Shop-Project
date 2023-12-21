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
    public partial class frm_Add_New_Model : Form
    {
        public frm_Add_New_Model()
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
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(Watch_ID) from Watch_Model_Details", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Watch_ID) from Watch_Model_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1001;
            }

            Con_Close();

            return Cnt;
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        void Bind_ComboBox()
        {
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

            cmb_Supplier_Name.Items.Clear();

            Cmd.CommandText = "Select Supplier_F_Name, Supplier_L_Name From Supplier_Details";
            Cmd.Connection = Con;

            string Name = "";
            obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                Name = obj.GetString(obj.GetOrdinal("Supplier_F_Name")) + " " + obj.GetString(obj.GetOrdinal("Supplier_L_Name"));

                cmb_Supplier_Name.Items.Add(Name);
            }

            obj.Dispose();
            Cmd.Dispose();

            Con_Close();
        }

        void Clear_Controls()
        {
            tb_Watch_ID.Text = Convert.ToString(Auto_Incr());

            dtp_First_Stock_Date.ResetText();
            tb_Model_Name.Clear();
            tb_Purchase_Rate.Clear();
            tb_Sales_Rate.Clear();
            tb_Current_Stock.Text = "0";

            cmb_Category.SelectedIndex = -1;
            cmb_Supplier_Name.SelectedIndex = -1;
        }

        private void frm_Add_New_Model_Load(object sender, EventArgs e)
        {
            tb_Current_Stock.Text = "0";
            tb_Model_Name.Focus();
            Bind_ComboBox();
            tb_Watch_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if ( tb_Model_Name.Text != "" && tb_Purchase_Rate.Text != "" && tb_Sales_Rate.Text != "" && tb_Current_Stock.Text != "" && cmb_Supplier_Name.Text != "" && cmb_Category.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Watch_Model_Details Values (@Watch_ID, @Watch_Category, @Watch_Model_Name, @Stock_Date, @Purchase_Rate, @Sales_Rate, @Current_Stock, @Supplier_Name) ", Con);

                cmd.Parameters.Add("@Watch_ID", SqlDbType.Int).Value = tb_Watch_ID.Text;
                cmd.Parameters.Add("@Watch_Category", SqlDbType.NVarChar).Value = cmb_Category.Text;
                cmd.Parameters.Add("@Watch_Model_Name", SqlDbType.NVarChar).Value = tb_Model_Name.Text;
                cmd.Parameters.Add("@Stock_Date", SqlDbType.Date).Value = dtp_First_Stock_Date.Value.Date;
                cmd.Parameters.Add("@Purchase_Rate", SqlDbType.Money).Value = tb_Purchase_Rate.Text;
                cmd.Parameters.Add("@Sales_Rate", SqlDbType.Money).Value = tb_Sales_Rate.Text;
                cmd.Parameters.Add("@Current_Stock", SqlDbType.Int).Value = tb_Current_Stock.Text;
                cmd.Parameters.Add("@Supplier_Name", SqlDbType.NVarChar).Value = cmb_Supplier_Name.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                if (Convert.ToInt32(tb_Current_Stock.Text) > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("Insert Into Stock_Updates Values (@Watch_ID, @Stock_Date, @Stock_Added, @Stock_Receiver) ",Con);

                    cmd1.Parameters.Add("@Watch_ID", SqlDbType.Int).Value = tb_Watch_ID.Text;
                    cmd1.Parameters.Add("@Stock_Date", SqlDbType.Date).Value = dtp_First_Stock_Date.Value.Date;
                    cmd1.Parameters.Add("@Stock_Added", SqlDbType.Int).Value = tb_Current_Stock.Text;
                    cmd1.Parameters.Add("@Stock_Receiver", SqlDbType.NVarChar).Value = Global_Vars.Uname;

                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                }

                MessageBox.Show("Watch Model Saved Successfully");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!");
            }

            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Model_Name.Text != "" || tb_Purchase_Rate.Text != "" || tb_Sales_Rate.Text != "" || tb_Current_Stock.Text != "" || cmb_Supplier_Name.Text != "" || cmb_Category.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
