using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using PrihodkoCourse.Forms;

namespace PrihodkoCourse
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var initialForm = ServiceProviderFactory.ServiceProvider.GetService<StartupForm>();
            Navigation.Refresh(initialForm);
            Application.Run(initialForm);
        }
    }
}
