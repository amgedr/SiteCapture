using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteCapture
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //make sure there is only 1 instance running of SiteCapture
            bool result;
            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);

            //if there is another instance running exit
            if (!result)
                return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            GC.KeepAlive(mutex);   
        }
    }
}
