using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.WeatherWidget.Models
{
    public class Snow
    {
        [JsonProperty("1h")]
        public double Volume1h { get; set; }

        [JsonProperty("3h")]
        public double Volume3h { get; set; }
    }
}
