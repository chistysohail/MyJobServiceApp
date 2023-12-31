// In the Services folder, create ApiCallJobService.cs

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyJobServiceApp.Services
{
    public class ApiCallJobService : IJobService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ApiCallJobService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task ExecuteAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            var content = await response.Content.ReadAsStringAsync();

            Console.WriteLine("API Call Job Completed. Response Length: " + content.Length);
        }
    }
}
