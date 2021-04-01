using System;
using System.Windows.Forms;

namespace TrainCalc
{

    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        ///
        public static decimal Gauge = 87;

        public static decimal Length = 100;
        public static string LengthName = "Zentimeter";

        public static Form1 Form;
        public static Settings Settings;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form = new Form1();
            Settings = new Settings();

            Application.Run(Form);
        }
    }
}
