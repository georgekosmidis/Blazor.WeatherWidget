using Blazor.WeatherWidget.Services;
using Blazor.WeatherWidget.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Blazor.WeatherWidget;

public static class DependencyInjection
{
    public static IServiceCollection AddWeatherWidgetServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<WeatherWidgetSettings>(
            configuration.GetSection(nameof(WeatherWidgetSettings))
        );

        services.AddHttpClient<IWeatherService, WeatherService>()
                .SetHandlerLifetime(TimeSpan.FromMinutes(5));

        return services;
    }
}
