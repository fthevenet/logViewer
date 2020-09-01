using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace FTH.Utils.LogViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var v = new { test = "bob", idx = 2 };

   


            log4net.Config.XmlConfigurator.Configure();
            string ErrorLog_Filename = "c:\\logViewer.log";
            string logPath = string.Format(
                        "{0}\\{1}_{2}_{3}{4}",
                        Path.GetDirectoryName(ErrorLog_Filename),
                        Path.GetFileNameWithoutExtension(ErrorLog_Filename),
                        Process.GetCurrentProcess().StartTime.ToString("yyyy-MM-ddTHH-mm-ss"),
                        Process.GetCurrentProcess().Id.ToString(),
                        Path.GetExtension(ErrorLog_Filename)
                        );

            Tools.Log4netConfigTools.SetupRootFileAppender("FileAppender", logPath, log4net.Core.Level.All);

            log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            logger.InfoFormat("Starting {0} ({1})",
                System.Diagnostics.Process.GetCurrentProcess().ProcessName,
                System.Diagnostics.Process.GetCurrentProcess().Id);

            try
            {             


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LogViewerForm(args));
                logger.InfoFormat("Stopping {0} ({1})",
                    System.Diagnostics.Process.GetCurrentProcess().ProcessName,
                    System.Diagnostics.Process.GetCurrentProcess().Id);
            }
            catch (Exception ex)
            {
                logger.Fatal("A fatal error has occured", ex);
                throw;

            }
        }
    }
}
