using Blazor.WeatherWidget.Models;
using System.Threading.Tasks;

namespace Blazor.WeatherWidget.Services;

public interface IWeatherService
{
    Task<WeatherGetResult> GetAsync(string query, string key, string unit);
}