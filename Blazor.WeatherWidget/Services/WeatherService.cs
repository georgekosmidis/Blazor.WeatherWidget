using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.WeatherWidget.Models;
using System.Net.Http.Json;

namespace Blazor.WeatherWidget.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherGetResult> Get(string query, string key)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://api.openweathermap.org/data/2.5/weather?q={query}&APPID={key}");

            request.Headers.Add("User-Agent", "Blazor.WeatherWidget");
            request.Headers.Add("X-Code-Source", "https://www.github.com/...");

            var response = await _httpClient.SendAsync(request);

            var result = new WeatherGetResult();
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadFromJsonAsync<WeatherGetResult>();
            }

            return result;
        }
    }
}
