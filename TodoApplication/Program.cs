using System;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoApplication.LoginForms;

namespace TodoApplication
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
            Application.Run(new LoginForm());
            
        }


       
    }
}