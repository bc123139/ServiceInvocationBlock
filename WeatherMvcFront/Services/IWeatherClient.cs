using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherMvcFront.Models;

namespace WeatherMvcFront.Services
{
    public interface IWeatherClient
    {
        Task<IEnumerable<WeatherForecast>> GetWeather();
    }
}
