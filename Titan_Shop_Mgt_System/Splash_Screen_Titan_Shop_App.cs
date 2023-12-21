using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Titan_Shop_Mgt_System
{
    public partial class Splash_Screen_Titan_Shop_App : Form
    {
        public Splash_Screen_Titan_Shop_App()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_Splash.PerformStep();

            if (pb_Splash.Value <= 10)
            {
                lbl_Note.Text =  "Loading Application Please Wait ...";
            }
            if (pb_Splash.Value >= 10 && pb_Splash.Value <= 20)
            {
                lbl_Note.Text =  "Loading Forms Please Wait ...";
            }
            if (pb_Splash.Value >= 20 && pb_Splash.Value <= 50)
            {
                lbl_Note.Text =  "Starting Application Please Wait ...";
            }
            if (pb_Splash.Value >= 50 && pb_Splash.Value <= 75)
            {
                lbl_Note.Text = "Loading Database Please Wait ...";
            }
            if (pb_Splash.Value >= 75 && pb_Splash.Value <= 85)
            {
                lbl_Note.Text =  "Connecting to Database Please Wait ...";
            }
            if (pb_Splash.Value >= 85 && pb_Splash.Value <= 100)
            {
                lbl_Note.Text = "Login Form Is Opening Please Wait ...";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            System.Threading.Thread.Sleep(200);
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity <= 0)
            {
                timer3.Enabled = false;

                Windows_Forms.frm_Login_Form Obj = new Windows_Forms.frm_Login_Form();

                Obj.Show();

                this.Hide();
            }
        }
    }
}
