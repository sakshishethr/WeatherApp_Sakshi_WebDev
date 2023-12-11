using NUnit.Framework;
using WebApp_Library.Class;

namespace WebApp_Library.Tests
{
    [TestFixture]
    public class GeoRootTests
    {
        private GeoRoot _geoRoot;

        [SetUp]
        public void Setup()
        {
            _geoRoot = new GeoRoot();
        }

        [Test]
        public void WhenSettingName_ShouldReturnCorrectValue()
        {
            
            var expectedName = "New York";

            // Act
            _geoRoot.name = expectedName;

            // Assert
            Assert.AreEqual(expectedName, _geoRoot.name, "The name property did not return the expected value.");
        }

        [Test]
        public void WhenSettingLatitude_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedLatitude = 40.7128;

            // Act
            _geoRoot.lat = expectedLatitude;

            // Assert
            Assert.AreEqual(expectedLatitude, _geoRoot.lat, "The lat property did not return the expected value.");
        }

        [Test]
        public void WhenSettingLongitude_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedLongitude = -74.0060;

            // Act
            _geoRoot.lon = expectedLongitude;

            // Assert
            Assert.AreEqual(expectedLongitude, _geoRoot.lon, "The lon property did not return the expected value.");
        }

        [Test]
        public void WhenSettingCountry_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedCountry = "USA";

            // Act
            _geoRoot.country = expectedCountry;

            // Assert
            Assert.AreEqual(expectedCountry, _geoRoot.country, "The country property did not return the expected value.");
        }

        [Test]
        public void WhenSettingState_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedState = "New York";

            // Act
            _geoRoot.state = expectedState;

            // Assert
            Assert.AreEqual(expectedState, _geoRoot.state, "The state property did not return the expected value.");
        }

        [TearDown]
        public void TearDown()
        {
            _geoRoot = null;
        }
    }
}
