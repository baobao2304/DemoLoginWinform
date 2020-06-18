using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVLB_Buoi4_BT_AppSmart
{
    static class Program
    {
        public static Form1 loginForm = null;
        public static HomeForm homeMainForm = null;
        public static RegisterForm registerForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new Form1();
            Application.Run(loginForm);
        }
    }
}
