using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherMvcFront.Controllers;
using WeatherMvcFront.Models;

namespace WeatherMvcFront.Services
{
    public class WeatherClient : IWeatherClient
    {
        private readonly HttpClient _httpClient;
        public WeatherClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<WeatherForecast>> GetWeather()
        {
            Console.WriteLine($"url {_httpClient.BaseAddress}");
            var result= await _httpClient.
                GetFromJsonAsync<IEnumerable<WeatherForecast>>("/weatherforecast");
            return result;
        }

    }
}
