using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApp_Library.Class;

namespace WeatherApp_Sakshi_WebDev.Tests
{
    [TestFixture]
    public class WeatherIntegrationTests
    {
        private HttpClient _httpClient;

        [SetUp]
        public void SetUp()
        {
            // Normally you would configure your HttpClient here
            _httpClient = new HttpClient();
        }

        [Test]
        public async Task GetCurrentWeather_DeserializesApiResponseCorrectly()
        {
            // Arrange
            string apiUrl = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=38c0927bf0a04a186a70bcaa540afe92";

            // Act
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            Current currentWeather = JsonConvert.DeserializeObject<Current>(jsonResponse);

            // Assert
            Assert.IsNotNull(currentWeather);
            Assert.AreNotEqual(default(double), currentWeather.temp);
            // ... other assertions to validate the response
        }

        [TearDown]
        public void TearDown()
        {
            _httpClient?.Dispose();
        }
    }
}
