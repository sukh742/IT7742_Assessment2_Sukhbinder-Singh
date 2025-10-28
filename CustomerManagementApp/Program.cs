using CustomerManagementApp;
using System;
using System.Windows.Forms;

namespace CustomerManagementApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Enable styles for older .NET versions
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomerForm());
        }
    }
}
