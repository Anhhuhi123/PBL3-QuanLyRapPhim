using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            if(loginForm.ShowDialog()==DialogResult.OK)
            {
                if(loginForm.user.Contains("QL"))
                {
                    Application.Run(new QuanLyForm(loginForm.user));
                    loginForm.Close();
                }
                else if(loginForm.user.Contains("BH"))
                {
                    Application.Run(new DatVe(loginForm.user));
                    loginForm.Close();
                }
            }
        }
    }
}
