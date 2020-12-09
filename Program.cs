using System;
using System.Windows.Forms;

namespace rm_idle
{
    static class Program
    {
        public static string filepath;
        public static string[] rawsavedata; // data is saved as string, load into here for conversion.
        public static int[] convsavedata; // convert save data to int for usage
        public static int[] dirtysavedata; // pre-save storage
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainMenu());
        }
    }
}
