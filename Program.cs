using System;
using System.Threading;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.AutomationElements.PatternElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Input;
using FlaUI.UIA3;
using System.Diagnostics;

namespace SolidWorksAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the automation object

            //// Start SolidWorks (adjust the path if needed)
            //Process.Start("C:\\Program Files\\SOLIDWORKS Corp\\SOLIDWORKS\\SLDWORKS.exe");

            //// Wait for SolidWorks to start
            //Thread.Sleep(5000); // Adjust the delay as needed

            // Find the SolidWorks main window
            var app = FlaUI.Core.Application.Launch("C:\\Program Files\\SOLIDWORKS Corp\\SOLIDWORKS\\SLDWORKS.exe");
            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);
                Console.WriteLine(window.Title);
            }
        }
    }
}
