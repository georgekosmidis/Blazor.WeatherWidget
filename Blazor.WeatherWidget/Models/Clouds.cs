using Newtonsoft.Json;

namespace Blazor.WeatherWidget.Models;

    public class Clouds
    {
        [JsonProperty("all")]
        public int Coverage { get; set; }
    }

