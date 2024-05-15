using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    static class Program
    {
        // Define the shared list of animals
        public static List<Animal> Zoo { get; } = new List<Animal>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}