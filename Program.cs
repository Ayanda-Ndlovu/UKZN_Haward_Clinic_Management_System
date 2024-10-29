using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKZN_Howard_Clinic_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form myForm = new LogIn();
            myForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(myForm);
        }
    }
}
