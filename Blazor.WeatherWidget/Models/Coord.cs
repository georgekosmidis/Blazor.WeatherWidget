using Newtonsoft.Json;
using Newtonsoft.Json;

namespace Blazor.WeatherWidget.Models
{
    public class Coord
    {
        [JsonProperty("lon")]
        public double Longitute { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }
    }
}
