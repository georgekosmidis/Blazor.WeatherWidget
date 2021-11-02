using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.WeatherWidget.Shared.Weather.OpenWeatherMap.Models;

namespace Blazor.WeatherWidget.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Root> Get(string query, string key)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://api.openweathermap.org/data/2.5/weather?q={query}&APPID={key}");

            request.Headers.Add("User-Agent", "Blazor.WeatherWidget");
            request.Headers.Add("X-Code-Source", "https://www.github.com/...");

            var response = await _httpClient.SendAsync(request);

            var result = new Root();
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<Root>(responseString);
            }

            return result;
        }
    }
}
