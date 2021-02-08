using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Database
{
    class Helper
    {
        public static int userId = 0;
        public static string fotoPath(int readerId)
        {
            string path = Application.StartupPath + "/pictures/" + readerId + ".jpg";
            if (File.Exists(path))
            {
                return path;
            }
            else return Application.StartupPath + "/pictures/default.jpg";
        }
    }
}
