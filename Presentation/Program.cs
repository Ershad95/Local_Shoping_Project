using shoping_project;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Da;

namespace Presentation
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
            CultureInfo cul = new CultureInfo("en");
            string state = Properties.Settings.Default.Lang;

            if (state == "en")
                cul = new CultureInfo("en-US");
            else if (state == "fa")
                cul = new CultureInfo("fa-IR");

           
            Thread.CurrentThread.CurrentCulture = cul;
            Thread.CurrentThread.CurrentUICulture = cul;
            Application.Run(new Splash());
        }
    }
}
