using Newtonsoft.Json;
using System.Globalization;

namespace Blazor.WeatherWidget.Shared.Weather.OpenWeatherMap.Models
{
    public class Weather
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public string Custom_Description => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Description.ToLower());

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
