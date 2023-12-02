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
        private HttpClient mockHttpClient;

        public WeatherController(HttpClient mockHttpClient)
        {
            // Initialize the WeatherController with a mock HttpClient.
            this.mockHttpClient = mockHttpClient;
        }

        public IActionResult Index()
        {
            // Default action for displaying a view (not used in this code).
            return View();
        }

        [HttpGet]
        public IActionResult GetWeather()
        {
            // HTTP GET action for displaying a view to input a city name.
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetWeather(string city)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    // Construct the API URL for OpenWeatherMap using the provided city and API key.
                    string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={OpenWeatherApiKey}&units=metric";

                    // Send an asynchronous HTTP GET request to the OpenWeatherMap API.
                    var response = await httpClient.GetStringAsync(apiUrl);


                }
            }
            catch (Exception ex)
            {
                // If an exception occurs during the HTTP request, set an error message to be displayed in the view.
                ViewBag.Error = "Error occurred while fetching weather data: " + ex.Message;
            }

            // Return the view, which may display weather data or an error message.
            return View();
        }
    }
}
