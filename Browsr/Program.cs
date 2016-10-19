using System;
using System.Windows.Forms;

namespace Browsr {
    class Program {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThreadAttribute]
        static void Main() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainWindow MainWindow = new MainWindow();
            Application.Run(MainWindow);

        }

    }
}
