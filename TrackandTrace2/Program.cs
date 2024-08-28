using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackandTrace2.auth;
using TrackandTrace2.db;
using TrackandTrace2.form;

namespace TrackandTrace2
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

            try
            {
                if (DataBaseUser.IsUserDataPresent())
                {
                    Application.Run(new Form_Main(new form_login()));
                }
                else
                {
                    Application.Run(new form_login());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                Application.Run(new form_login());
            }
        }


    }
}
