﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EventLogUtility.WinApp
{
    static class AppMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppForm());
        }
    }
}
