using NUnit.Framework;
using WebApp_Library.Class;

namespace WebApp_Library.Tests
{
    [TestFixture]
    public class MinutelyTests
    {
        private Minutely _minutely;

        [SetUp]
        public void Setup()
        {
            _minutely = new Minutely();
        }

        [Test]
        public void WhenSettingDt_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedDt = 1617187200;

            // Act
            _minutely.dt = expectedDt;

            // Assert
            Assert.AreEqual(expectedDt, _minutely.dt, "The dt property did not return the expected value.");
        }

        [Test]
        public void WhenSettingPrecipitation_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedPrecipitation = 5;

            // Act
            _minutely.precipitation = expectedPrecipitation;

            // Assert
            Assert.AreEqual(expectedPrecipitation, _minutely.precipitation, "The precipitation property did not return the expected value.");
        }

        [TearDown]
        public void TearDown()
        {
            _minutely = null;
        }
    }
}
