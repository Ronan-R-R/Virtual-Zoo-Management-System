using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    // Main entry point of the program
    class Program
    {
        // STAThread attribute indicates that the COM threading model for the application is single-threaded apartment (STA)
        [STAThread]
        static void Main()
        {
            // Enables visual styles for the application
            Application.EnableVisualStyles();
            // Sets the application-wide default font to be compatible with visual styles
            Application.SetCompatibleTextRenderingDefault(false);
            // Runs the application, starting with the MainForm
            Application.Run(new MainForm());
        }
    }
}