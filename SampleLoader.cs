using playground.Models;
using System.Net.Http.Json;

namespace playground
{
    public class SampleLoader
    {
        public SampleLoader(HttpClient client)
        {
            HttpClient = client;
        }

        public HttpClient HttpClient { get; set; }

        public async Task<string> GetSampleAsync(string id)
        {
            var sample = await HttpClient.GetFromJsonAsync<Sample>($"/samples/{id}.json");

            return sample.Body;
        }
    }
}