using System.Globalization;
using TemperatureConverter;
using TemperatureConverter.GUI;

namespace TemperatureSensor
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
            var culture = CultureInfo.GetCultureInfo("de-DE");

            //Culture for any thread
            CultureInfo.DefaultThreadCurrentCulture = culture;

            //Culture for UI in any thread
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            //Culture for current thread (STA)
            //no need for: Application.CurrentCulture = culture;

            //Thread.CurrentThread.CurrentCulture == Application.CurrentCulture
            //no need for: Thread.CurrentThread.CurrentCulture = culture;

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}