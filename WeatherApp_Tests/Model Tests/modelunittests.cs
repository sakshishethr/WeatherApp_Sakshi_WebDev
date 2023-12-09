using NUnit.Framework;
using ASP.NET_MVC_WeatherApp.Models;

namespace ASP.NET_MVC_WeatherApp.Tests.Models
{
    [TestFixture]
    public class OpenWeatherMapTests
    {
        [Test]
        public void OpenWeatherMap_SetAndGetProperties_ReturnsCorrectValues()
        {
            // Arrange
            var openWeatherMap = new OpenWeatherMap();
            var testApiResponse = "{\"coord\":{\"lon\":139,\"lat\":35},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"base\":\"stations\",\"main\":{\"temp\":293.15,\"pressure\":1016,\"humidity\":63,\"temp_min\":289.15,\"temp_max\":298.15},\"visibility\":10000,\"wind\":{\"speed\":1.5,\"deg\":350},\"clouds\":{\"all\":1},\"dt\":1560350645,\"sys\":{\"type\":1,\"id\":8074,\"message\":0.0065,\"country\":\"JP\",\"sunrise\":1560281377,\"sunset\":1560333478},\"timezone\":32400,\"id\":1851632,\"name\":\"Shuzenji\",\"cod\":200}";
            var testLat = "35";
            var testLon = "139";

            // Act
            openWeatherMap.apiResponse = testApiResponse;
            openWeatherMap.lat = testLat;
            openWeatherMap.lon = testLon;

            // Assert
            Assert.AreEqual(testApiResponse, openWeatherMap.apiResponse);
            Assert.AreEqual(testLat, openWeatherMap.lat);
            Assert.AreEqual(testLon, openWeatherMap.lon);
        }
    }
}
