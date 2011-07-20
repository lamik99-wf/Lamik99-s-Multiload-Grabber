using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiloadGrabber
{
    static class Program
    {
        public const int version = 14;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new hlavniOkno1());
        }
    }
}
