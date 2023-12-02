using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly string OpenWeatherApiKey = "38c0927bf0a04a186a70bcaa540afe92";


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetWeather()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetWeather(string city)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={OpenWeatherApiKey}&units=metric";

                    var response = await httpClient.GetStringAsync(apiUrl);

                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error occurred while fetching weather data: " + ex.Message;
            }

            return View();
        }
    }
}
