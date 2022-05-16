using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entreprise
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static User defaultUser;
        public static int year = 0;
        public static int month = 0;
        public static string type = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
