namespace SkiaDesktopTest.Services.Caching;
using WeatherForecast = SkiaDesktopTest.DataContracts.WeatherForecast;
public interface IWeatherCache
{
    ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
}
