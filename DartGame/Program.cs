using System;
using System.Windows.Forms;


namespace DartGame
{
    // Program class definition
    static class Program
    {
        // The main entry point for the application.
        // Runs application by providing object of 
        // basic game form - DartGameForm
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DartGameForm());
        }
    }
}
