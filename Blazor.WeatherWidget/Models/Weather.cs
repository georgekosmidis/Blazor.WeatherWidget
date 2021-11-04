using Newtonsoft.Json;
using System.Globalization;

namespace Blazor.WeatherWidget.Models
{
    public class Weather
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        public string DefaultIcon => $"http://openweathermap.org/img/wn/{Icon}@2x.png";
    }
}
