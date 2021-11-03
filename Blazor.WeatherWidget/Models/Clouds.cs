using Newtonsoft.Json;

namespace Blazor.WeatherWidget.Models
{

    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }

}
