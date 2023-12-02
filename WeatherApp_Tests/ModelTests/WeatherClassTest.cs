using NUnit.Framework;
using WebApp_Library.Class;

namespace WebApp_Library.Tests
{
    [TestFixture]
    public class WeatherTests
    {
        private Weather _weather;

        [SetUp]
        public void Setup()
        {
            _weather = new Weather();
        }

        [Test]
        public void WhenSettingId_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedId = 800;

            // Act
            _weather.id = expectedId;

            // Assert
            Assert.AreEqual(expectedId, _weather.id, "The id property did not return the expected value.");
        }

        [Test]
        public void WhenSettingMain_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedMain = "Clear";

            // Act
            _weather.main = expectedMain;

            // Assert
            Assert.AreEqual(expectedMain, _weather.main, "The main property did not return the expected value.");
        }

        [Test]
        public void WhenSettingDescription_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedDescription = "clear sky";

            // Act
            _weather.description = expectedDescription;

            // Assert
            Assert.AreEqual(expectedDescription, _weather.description, "The description property did not return the expected value.");
        }

        [Test]
        public void WhenSettingIcon_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedIcon = "01d";

            // Act
            _weather.icon = expectedIcon;

            // Assert
            Assert.AreEqual(expectedIcon, _weather.icon, "The icon property did not return the expected value.");
        }

        [TearDown]
        public void TearDown()
        {
            _weather = null;
        }
    }
}
