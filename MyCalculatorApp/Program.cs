using log4net;
using log4net.Config;
using MyCalculatorApp.Views;
using System.Reflection;

namespace MyCalculatorApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // log4netê›íËÉtÉ@ÉCÉãÇì«Ç›çûÇﬁ
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
#if DEBUG
            XmlConfigurator.Configure(logRepository, new FileInfo("log4netDebug.config"));
#else
            XmlConfigurator.Configure(logRepository, new FileInfo("log4netRelease.config"));
#endif
            Application.Run(new Form1());
        }
    }
}