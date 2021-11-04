using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blazor.WeatherWidget.Models
{
    public class WeatherGetResult
    {
        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("dt")]
        public int SecondsSinceUnitTime { get; set; }

        public DateTime DateTimeUTC => new DateTime(1970, 1, 1).AddSeconds(SecondsSinceUnitTime);
        public DateTime DateTimeLocal => new DateTime(1970, 1, 1).AddSeconds(SecondsSinceUnitTime).ToLocalTime();

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("timezone")]
        public int Timezone { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string CityName { get; set; }

        [JsonProperty("cod")]
        public int Cod { get; set; }

        [JsonProperty("snow")]
        public Snow Snow { get; set; }

        [JsonProperty("rain")]
        public Rain Rain { get; set; }

    }
}
