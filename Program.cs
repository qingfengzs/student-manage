using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_manage
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ÔØÈëµÇÂ¼´°ÌåÊµÀý
            LoginForm loginForm = new LoginForm();
            DialogResult dialogResult = loginForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if(UserType.userType == "teacher")
                {
                    Application.Run(new MainForm());
                }
                else
                {
                    Application.Run(new StudentMainForm());
                }
                
            }
            else
            {
                Application.Exit();
            }
            

        }
    }
}
