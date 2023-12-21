using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Titan_Shop_Mgt_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// FORK INFOSYSTEMS PROJECT JUNE 2021
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Splash_Screen_Titan_Shop_App());
            Application.Run(new Windows_Forms.frm_Login_Form());

        }
    }
}
