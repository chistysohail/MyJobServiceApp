using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyJobServiceApp.Services
{
    public class JobsService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        public JobsService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var jobServices = scope.ServiceProvider.GetServices<IJobService>();
                    foreach (var job in jobServices)
                    {
                        await job.ExecuteAsync();
                    }
                }
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
