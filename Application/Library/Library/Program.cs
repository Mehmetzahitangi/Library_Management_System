using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Database;

namespace Library
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
            Application.Run(new FormMain());
           /* if (IDataBase.DataToDataTable("select * from Users where IsActive=1").Rows.Count > 1)
            {
                Application.Run(new FormSignIn());

            }
            else
                Application.Run(new FormSignUp());*/
           
        }
    }
}
