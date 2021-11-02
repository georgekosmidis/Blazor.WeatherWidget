using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.WeatherWidget.Shared.Weather.OpenWeatherMap.Models
{

    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }

}
