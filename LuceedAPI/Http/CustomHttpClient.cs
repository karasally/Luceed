using Microsoft.Extensions.Configuration;
using System.Text;
using System.Xml.Linq;

namespace LuceedAPI.Http
{
    public class CustomHttpClient : ICustomHttpClient
    {
        private HttpClient client;
        private readonly IConfiguration configuration;
        private string encodedAuth;
        public CustomHttpClient(HttpClient _client, IConfigurationRoot config)
        {
            client = _client;
            configuration = config;
            var username = configuration["LuceedUsername"];
            var password = configuration["LuceedPassword"];
            encodedAuth = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"));
        }

        public async Task<HttpResponseMessage> OnGet(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Authorization", $"Basic {encodedAuth}");
            var response = await client.SendAsync(request);
            return response;
        }
    }
}
