using System.Diagnostics;
using Kq1DosboxTas.GUI;
using Kq1DosboxTas.MemoryAccess;

namespace Kq1DosboxTas
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            StartTasPanel();
        }

        public static void StartTasPanel()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new KQ1TasPanel());
        }


        // not part of the application, run the methods in the 'TestMemoryOperations'
        // for some examples of reading and writing memory data
        public static void RunMemoryOperationExamples()
        {
            TestMemoryOperations.RunTrials();
        }
    }
}

