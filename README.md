# Blazor.WeatherWidget

A simple component in Blazor that displays the current weather, featuring a default and a user defined template

## Default Template
![Weather.Widget](_readme/weatherwidget.png)

##User Defined Template
(Thanks @stavroskasidis)

###Sample Template

```csharp
    <WeatherWidget CurrentCity="Munich, DE" Template="Models.WeatherWidgetTemplate.Custom">
        <CustomTemplate>
            <div class="card text-center">
                <div class="card-header">
                    Weather for @context.CityName, @context.Sys.Country
                </div>
                <div class="card-body">
                    <img src="@context.Weather[0].DefaultIcon" />
                    <h5 class="card-title">@Math.Round(context.Main.Temperature, 1)&nbsp;°C</h5>
                    <p class="card-text">@context.DateTimeLocal</p>
                </div>
                <div class="card-footer text-muted">
                    @context.Weather[0].Description with @context.Wind.Description coming from @context.Wind.NamedDirection
                </div>
            </div>
        </CustomTemplate>
    </WeatherWidget>
```
###Available Properties
A user can create a custom template to consume all available properties:

*   `Coord`
    *   `Coord.Longitute` City geo location, longitude
    *   `Coord.Latitude` City geo location, latitude
*   `Weather` List of available updates. Position [0] holds the last update
    *   `Weather[0].Id` Weather condition id
    *   `Weather[0].Main` Group of weather parameters (Rain, Snow, Extreme etc.)
    *   `Weather[0].Description` Weather condition within the group.
    *   `Weather[0].Icon` Weather icon id, for custom icons
    *   `Weather[0].DefaultIcon` Weather icon URL    
*   `Base` Ignore, Internal Parameter    
*   `Main`
    *   `Main.Temperature` Temperature. Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
    *   `Main.FeelsLike` Temperature. This temperature parameter accounts for the human perception of weather. Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
    *   `Main.Pressure` Atmospheric pressure (on the sea level, if there is no sea_level or grnd_level data), hPa
    *   `Main.Humidity` Humidity, %
    *   `Main.TempMin` Minimum temperature at the moment. This is minimal currently observed temperature (within large megalopolises and urban areas). Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
    *   `Main.TempMax` Maximum temperature at the moment. This is maximal currently observed temperature (within large megalopolises and urban areas). Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
    *   `Main.SeaLevelPressure` Atmospheric pressure on the sea level, hPa
    *   `Main.GroundLevelPressure` Atmospheric pressure on the ground level, hPa
*   `Wind`
    *   `Wind.Speed` Wind speed. Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour.
    *   `Wind.Degrees` Wind direction, degrees (meteorological)
    *   `Wind.Gusts` Wind gust. Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour
    *   `Wind.Description` Description of the Wind speed
    *   `Wind.NamedDirection` Description of the Wind direction    
*   `Clouds`
    *   `Clouds.Coverage` Cloudiness, %
*   `Rain`
    *   `Rain.Volume1h` Rain volume for the last 1 hour, mm
    *   `Rain.Volume3h` Rain volume for the last 3 hours, mm
*   `Snow`
    *   `Snow.Volume1h` Snow volume for the last 1 hour, mm
    *   `Snow.Volume3h` Snow volume for the last 3 hours, mm
*   `SecondsSinceUnitTime` Time of data calculation, unix, UTC
*   `DateTimeUTC` DateTime of data calculation,  UTC
*   `DateTimeLocal` DateTime of data calculation, Local
*   `Timezone` Shift in seconds from UTC
*   `Sys`
    *   `Sys.Type` Internal parameter
    *   `Sys.Id` Internal parameter
    *   `Sys.Message` Internal parameter
    *   `Sys.Country` Country code (GB, JP etc.)
    *   `Sys.Sunrise` Sunrise time, unix, UTC
    *   `Sys.Sunset` Sunset time, unix, UTC
*   `id` City ID
*   `CityName` City name
*   `Cod` Ignore, Internal parameter

