using NUnit.Framework;
using WebApp_Library.Class;
using System.Collections.Generic;

namespace WebApp_Library.Tests
{
    [TestFixture]
    public class HourlyTests
    {
        private Hourly _hourly;

        [SetUp]
        public void Setup()
        {
            _hourly = new Hourly();
        }

        [Test]
        public void WhenSettingDt_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedDt = 1617187200;

            // Act
            _hourly.dt = expectedDt;

            // Assert
            Assert.AreEqual(expectedDt, _hourly.dt, "The dt property did not return the expected value.");
        }

        [Test]
        public void WhenSettingTemp_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedTemp = 15.5;

            // Act
            _hourly.temp = expectedTemp;

            // Assert
            Assert.AreEqual(expectedTemp, _hourly.temp, "The temp property did not return the expected value.");
        }

        // Similar tests for other properties like feels_like, pressure, humidity, etc.

        [Test]
        public void WhenSettingWeatherList_ShouldReturnCorrectValues()
        {
            // Arrange
            var expectedWeatherList = new List<Weather>
            {
                new Weather { id = 800, main = "Clear", description = "clear sky", icon = "01d" }
            };

            // Act
            _hourly.weather = expectedWeatherList;

            // Assert
            Assert.AreEqual(expectedWeatherList, _hourly.weather, "The weather property did not return the expected value.");
        }

        [TearDown]
        public void TearDown()
        {
            _hourly = null;
        }
    }
}
