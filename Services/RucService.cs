using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RucConsultaApp.Models;

namespace RucConsultaApp.Services
{
    public class RucService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public RucService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["ApiKey"];
        }

        public async Task<RucResponse> GetRucInfoAsync(string ruc)
        {
            var requestContent = new
            {
                token = _apiKey,
                ruc = ruc
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestContent), Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(HttpMethod.Post, "https://ruc.com.pe/api/v1/consultas")
            {
                Content = content
            };

            try
            {
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RucResponse>(responseContent);
            }
            catch (HttpRequestException e)
            {
                // Log the exception (you can use a logging framework instead of Console)
                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
        }
    }
}
