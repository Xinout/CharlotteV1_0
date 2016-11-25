using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CharlotteV1_0
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
            Global.common = new DAL.Common();
            Global.mainForm = new Main();
            Application.Run(Global.mainForm);
        }
    }
}
