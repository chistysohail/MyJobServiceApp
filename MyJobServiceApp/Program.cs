using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyJobServiceApp.Configurations;
using System;

namespace MyJobServiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    ServiceConfiguration.Configure(services, context.Configuration);
                });
    }
}
