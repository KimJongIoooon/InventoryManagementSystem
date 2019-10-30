﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace MainAplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       

        [STAThread]
        static void Main()
        {
            string sAttr;
            sAttr = ConfigurationManager.AppSettings.Get("Serverip");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(sAttr));

        }
    }
}
