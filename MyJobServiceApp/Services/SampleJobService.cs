using System;
using System.Threading.Tasks;

namespace MyJobServiceApp.Services
{
    public class SampleJobService : IJobService
    {
        public async Task ExecuteAsync()
        {
            Console.WriteLine("Executing Sample Job");
            await Task.Delay(1000); // Simulating work
        }
    }

    public class AnotherJobService : IJobService
    {
        public async Task ExecuteAsync()
        {
            Console.WriteLine("Executing Another Job");
            await Task.Delay(1000); // Simulating work
        }
    }
}
