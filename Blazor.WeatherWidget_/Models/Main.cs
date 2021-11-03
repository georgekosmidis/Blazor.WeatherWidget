using Newtonsoft.Json;

namespace Blazor.WeatherWidget.Models
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }

        public double Custom_Temp_Celcius => Temp - 273.15;

        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }

        public double Custom_FeelsLike_Celcius => FeelsLike - 273.15;

        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        public double TempMax { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }
}
