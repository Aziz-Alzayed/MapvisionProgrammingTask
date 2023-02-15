using MapvisionTask.Data.Queries;
using MapvisionTask.Data.Repositories;
using MapvisionTask.Services.Calculations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MapvisionApp
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.                     
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Main>());
        }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<IPartPointsQueriesRepository, PartPointsQueriesRepository>();
                    services.AddTransient<IPartPointsQueries,PartPointsQueries>();
                    services.AddTransient<ICalculationsSvc, CalculationsSvc>();
                    services.AddTransient<Main>();
                });
        }

    }
}