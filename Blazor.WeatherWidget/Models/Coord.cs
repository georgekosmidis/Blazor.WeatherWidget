using Newtonsoft.Json;
using Newtonsoft.Json;

namespace Blazor.WeatherWidget.Models
{
    public class Coord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }
}
