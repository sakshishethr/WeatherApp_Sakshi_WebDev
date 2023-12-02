using NUnit.Framework;
using WeatherApp;
using System.Collections.Generic;

namespace WebApp_Test.Tests
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

        // Additional tests for other properties like sunrise, sunset, moonrise, moonset, etc...

        [TearDown]
        public void TearDown()
        {
            _daily = null;
        }
    }
}
