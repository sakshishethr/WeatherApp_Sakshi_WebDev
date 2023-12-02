using NUnit.Framework;
using WebApp_Library.Class;
using System.Collections.Generic;

namespace WebApp_Library.Tests
{
    [TestFixture]
    public class DailyTests
    {
        private Daily _daily;

        [SetUp]
        public void Setup()
        {
            _daily = new Daily();
        }

        [Test]
        public void WhenSettingDt_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedDt = 1617187200;

            // Act
            _daily.dt = expectedDt;

            // Assert
            Assert.AreEqual(expectedDt, _daily.dt, "The dt property did not return the expected value.");
        }

        // Similar tests for other properties like sunrise, sunset, moonrise, moonset, etc.

        [Test]
        public void WhenSettingTemp_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedTemp = new Temp { day = 12.3, min = 7.0, max = 15.0, night = 9.2, eve = 11.5, morn = 8.1 };

            // Act
            _daily.temp = expectedTemp;

            // Assert
            Assert.AreEqual(expectedTemp, _daily.temp, "The temp property did not return the expected value.");
        }

        [Test]
        public void WhenSettingFeelsLike_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedFeelsLike = new FeelsLike { day = 12.0, night = 8.5, eve = 10.0, morn = 7.0 };

            // Act
            _daily.feels_like = expectedFeelsLike;

            // Assert
            Assert.AreEqual(expectedFeelsLike, _daily.feels_like, "The feels_like property did not return the expected value.");
        }

        [TearDown]
        public void TearDown()
        {
            _daily = null;
        }
    }
}
