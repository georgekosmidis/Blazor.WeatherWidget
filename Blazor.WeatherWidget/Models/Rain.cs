using Newtonsoft.Json;

namespace Blazor.WeatherWidget.Models;

public class Rain
{
    [JsonProperty("1h")]
    public double Volume1h { get; set; }

    [JsonProperty("3h")]
    public double Volume3h { get; set; }
}
