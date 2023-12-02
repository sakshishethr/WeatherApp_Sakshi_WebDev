using NUnit.Framework;
using WebApp_Library.Class;
using System.Collections.Generic;

namespace WebApp_Library.Tests
{
    [TestFixture]
    public class CurrentTests
    {
        private Current _current;

        [SetUp]
        public void Setup()
        {
            _current = new Current();
        }

        [Test]
        public void WhenSettingDt_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedDt = 1617187200;

            // Act
            _current.dt = expectedDt;

            // Assert
            Assert.AreEqual(expectedDt, _current.dt, "The dt property did not return the expected value.");
        }

        [Test]
        public void WhenSettingSunrise_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedSunrise = 1617160800;

            // Act
            _current.sunrise = expectedSunrise;

            // Assert
            Assert.AreEqual(expectedSunrise, _current.sunrise, "The sunrise property did not return the expected value.");
        }

        // Similar tests for other properties like sunset, temp, feels_like, etc.

        [Test]
        public void WhenSettingWeatherList_ShouldReturnCorrectValues()
        {
            // Arrange
            var expectedWeatherList = new List<Weather>
            {
                new Weather { id = 500, main = "Rain", description = "light rain", icon = "10d" }
            };

            // Act
            _current.weather = expectedWeatherList;

            // Assert
            Assert.AreEqual(expectedWeatherList, _current.weather, "The weather property did not return the expected value.");
        }

        [TearDown]
        public void TearDown()
        {
            _current = null;
        }
    }
}
