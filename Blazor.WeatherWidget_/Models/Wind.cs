using Newtonsoft.Json;

namespace Blazor.WeatherWidget.Models
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public int Deg { get; set; }

        [JsonProperty("gust")]
        public double Gust { get; set; }
        public string Custom_WindName
        {
            get
            {
                if (Speed >= 0 && Speed <= 0.2) { return "No Air"; } //Calm
                else if (Speed >= 0.3 && Speed <= 1.5) { return "a Light Air"; }
                else if (Speed >= 1.6 && Speed <= 3.3) { return "a Light Breeze"; }
                else if (Speed >= 3.4 && Speed <= 5.4) { return "a Gentle Breeze"; }
                else if (Speed >= 5.5 && Speed <= 7.9) { return "a Moderate Breeze"; }
                else if (Speed >= 8.0 && Speed <= 10.7) { return "a Fresh Breeze"; }
                else if (Speed >= 10.8 && Speed <= 13.8) { return "a Strong Breeze"; }
                else if (Speed >= 13.9 && Speed <= 17.1) { return "a Near Gale"; }
                else if (Speed >= 17.2 && Speed <= 20.7) { return "a Gale"; }
                else if (Speed >= 20.8 && Speed <= 24.4) { return "a Severe Gale"; }
                else if (Speed >= 24.5 && Speed <= 28.4) { return "a Strong StormS"; }
                else if (Speed >= 28.5 && Speed <= 32.6) { return "Violent Storms"; }
                else { return "Hurricanes"; }
            }
        }
        public string Custom_Direction
        {
            get
            {
                if (Deg >= 11.25 && Deg < 33.75) { return "NNE"; }
                else if (Deg >= 33.75 && Deg < 56.25) { return "NE"; }
                else if (Deg >= 56.25 && Deg < 78.75) { return "ENE"; }
                else if (Deg >= 78.75 && Deg < 101.25) { return "E"; }
                else if (Deg >= 101.25 && Deg < 123.75) { return "ESE"; }
                else if (Deg >= 123.75 && Deg < 146.25) { return "SE"; }
                else if (Deg >= 146.25 && Deg < 168.75) { return "SSE"; }
                else if (Deg >= 168.75 && Deg < 191.25) { return "S"; }
                else if (Deg >= 191.25 && Deg < 213.75) { return "SSW"; }
                else if (Deg >= 213.75 && Deg < 236.25) { return "SW"; }
                else if (Deg >= 236.25 && Deg < 258.75) { return "WSW"; }
                else if (Deg >= 258.75 && Deg < 281.25) { return "W"; }
                else if (Deg >= 281.25 && Deg < 303.75) { return "WNW"; }
                else if (Deg >= 303.75 && Deg < 326.25) { return "NW"; }
                else if (Deg >= 326.25 && Deg < 348.75) { return "NNW"; }
                else { return "N"; }
            }
        }


    }

    static class WindExtensions
    {
        public static bool Between(this int value, int left, int right)
        {
            return value > left && value < right;
        }
    }

}
