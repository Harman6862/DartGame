using System;
using System.Windows.Forms;


namespace GhostBowling
{
    // Program class definition
    static class Program
    {
        // The main entry point for the application.
        // Runs application by providing object of 
        // basic game form - GhostBowlingForm
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GhostBowlingForm());
        }
    }
}
