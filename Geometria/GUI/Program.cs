using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    /**
       * IF YOU WANT TO RUN THIS MAIN PLEASE CLICK THE LEFT MOUSE BUTTON ON "Solution'Geomatria'"
       * AND SELECT "GUI" IN "STARTUP PROJECT" RUBRIC
    **/
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
            Application.Run(new POINTS());
        }
    }
}
