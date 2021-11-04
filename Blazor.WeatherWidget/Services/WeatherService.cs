using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.WeatherWidget.Models;

namespace Blazor.WeatherWidget.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherGetResult> Get(string query, string key, string unit)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://api.openweathermap.org/data/2.5/weather?q={query}&APPID={key}&units={unit}");

            request.Headers.Add("User-Agent", "Blazor.WeatherWidget");
            request.Headers.Add("X-Code-Source", "https://github.com/georgekosmidis/Blazor.WeatherWidget");

            var response = await _httpClient.SendAsync(request);

            var result = new WeatherGetResult();
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<WeatherGetResult>(json);
            }
            return result;
        }
    }
}
