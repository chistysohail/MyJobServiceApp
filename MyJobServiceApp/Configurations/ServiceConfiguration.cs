using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyJobServiceApp.Services;

namespace MyJobServiceApp.Configurations
{
    public static class ServiceConfiguration
    {
        public static void Configure(IServiceCollection services, IConfiguration config)
        {
            // Register IHttpClientFactory
            services.AddHttpClient();


            services.AddTransient<IJobService, SampleJobService>();
            services.AddTransient<IJobService, AnotherJobService>();
            services.AddTransient<IJobService, ApiCallJobService>();

            services.AddHostedService<JobsService>();
        }
    }
}
