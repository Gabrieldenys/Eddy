﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kodi_M3U_IPTV_Editor
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
            Application.Run(new Editor());
            Editor settingsForm = new Editor();

            // Show the settings form
            settingsForm.Show();
        }
    }
}
