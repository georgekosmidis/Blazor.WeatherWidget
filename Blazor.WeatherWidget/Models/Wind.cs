using Newtonsoft.Json;

namespace Blazor.WeatherWidget.Models
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("Degrees")]
        public int Degrees { get; set; }

        [JsonProperty("gust")]
        public double Gusts { get; set; }
        public string Description
        {
            get
            {
                if (Speed >= 0 && Speed <= 0.2) { return "calm"; } 
                else if (Speed > 0.2 && Speed <= 1.5) { return "light air"; }
                else if (Speed > 1.5 && Speed <= 3.3) { return "light breeze"; }
                else if (Speed > 3.3 && Speed <= 5.4) { return "gentle breeze"; }
                else if (Speed > 5.4 && Speed <= 7.9) { return "moderate breeze"; }
                else if (Speed > 7.9 && Speed <= 10.7) { return "fresh breeze"; }
                else if (Speed > 10.7 && Speed <= 13.8) { return "strong breeze"; }
                else if (Speed > 13.8 && Speed <= 17.1) { return "near gale"; }
                else if (Speed > 17.1 && Speed <= 20.7) { return "gale"; }
                else if (Speed > 20.7 && Speed <= 24.4) { return "severe gale"; }
                else if (Speed > 24.4 && Speed <= 28.4) { return "strong storms"; }
                else if (Speed > 28.4 && Speed <= 32.6) { return "violent storms"; }
                else { return "hurricanes"; }
            }
        }

        public string ShortNamedDirection
        {
            get
            {
                if (Degrees >= 11.25 && Degrees < 33.75) { return "NNE"; }
                else if (Degrees >= 33.75 && Degrees < 56.25) { return "NE"; }
                else if (Degrees >= 56.25 && Degrees < 78.75) { return "ENE"; }
                else if (Degrees >= 78.75 && Degrees < 101.25) { return "E"; }
                else if (Degrees >= 101.25 && Degrees < 123.75) { return "ESE"; }
                else if (Degrees >= 123.75 && Degrees < 146.25) { return "SE"; }
                else if (Degrees >= 146.25 && Degrees < 168.75) { return "SSE"; }
                else if (Degrees >= 168.75 && Degrees < 191.25) { return "S"; }
                else if (Degrees >= 191.25 && Degrees < 213.75) { return "SSW"; }
                else if (Degrees >= 213.75 && Degrees < 236.25) { return "SW"; }
                else if (Degrees >= 236.25 && Degrees < 258.75) { return "WSW"; }
                else if (Degrees >= 258.75 && Degrees < 281.25) { return "W"; }
                else if (Degrees >= 281.25 && Degrees < 303.75) { return "WNW"; }
                else if (Degrees >= 303.75 && Degrees < 326.25) { return "NW"; }
                else if (Degrees >= 326.25 && Degrees < 348.75) { return "NNW"; }
                else { return "N"; }
            }
        }

        public string NamedDirection
        {
            get
            {
                switch (ShortNamedDirection)
                {
                    case "NNE":
                        return "North-North-East";
                    case "NE":
                        return "North-East";
                    case "ENE":
                        return "East-North-East";
                    case "E":
                        return "East";
                    case "ESE":
                        return "East-South-East";
                    case "SE":
                        return "South-East";
                    case "SSE":
                        return "South-South-East";
                    case "S":
                        return "South";
                    case "SSW":
                        return "South-South-West";
                    case "SW":
                        return "South-West";
                    case "WSW":
                        return "West-South-West";
                    case "W":
                        return "West";
                    case "WNW":
                        return "West-North-West";
                    case "NW":
                        return "North-West";
                    case "NNW":
                        return "North-North-West";
                    default:
                        return "North";
                }
            }
        }
    }

}
