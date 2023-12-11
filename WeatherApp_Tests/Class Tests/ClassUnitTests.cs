using NUnit.Framework;
using Newtonsoft.Json;
using WebApp_Library.Class; 
using System;

namespace WeatherApp_Sakshi_WebDev.Tests
{
    [TestFixture]
    public class GeoRootTests
    {
        private string json = @"{
            'name': 'Raleigh',
            'local_names': {
                'ru': 'Роли',
                'zh': '罗利 / 羅里 / 羅利',
                'ta': 'ராலீ',
                'pl': 'Raleigh',
                'uk': 'Ралі',
                'en': 'Raleigh'
            },
            'lat': 35.7803977,
            'lon': -78.6390989,
            'country': 'US',
            'state': 'North Carolina'
        }";

        [Test]
        public void Deserialize_GeoRoot_CorrectlyPopulatesProperties()
        {
            // Arrange & Act
            var geoRoot = JsonConvert.DeserializeObject<GeoRoot>(json);

            // Assert
            Assert.IsNotNull(geoRoot);
            Assert.AreEqual("Raleigh", geoRoot.name);
            Assert.AreEqual(35.7803977, geoRoot.lat);
            Assert.AreEqual(-78.6390989, geoRoot.lon);
            Assert.AreEqual("US", geoRoot.country);
            Assert.AreEqual("North Carolina", geoRoot.state);
            
            Assert.IsNotNull(geoRoot.local_names);
            Assert.AreEqual("Роли", geoRoot.local_names.ru);
            Assert.AreEqual("罗利 / 羅里 / 羅利", geoRoot.local_names.zh);
            Assert.AreEqual("ராலீ", geoRoot.local_names.ta);
            Assert.AreEqual("Raleigh", geoRoot.local_names.pl);
            Assert.AreEqual("Ралі", geoRoot.local_names.uk);
            Assert.AreEqual("Raleigh", geoRoot.local_names.en);
        }

        [Test]
        public void Serialize_GeoRoot_CorrectlyGeneratesJson()
        {
            // Arrange
            var geoRoot = new GeoRoot
            {
                name = "Raleigh",
                local_names = new LocalNames
                {
                    ru = "Роли",
                    zh = "罗利 / 羅里 / 羅利",
                    ta = "ராலீ",
                    pl = "Raleigh",
                    uk = "Ралі",
                    en = "Raleigh"
                },
                lat = 35.7803977,
                lon = -78.6390989,
                country = "US",
                state = "North Carolina"
            };

            // Act
            var serializedJson = JsonConvert.SerializeObject(geoRoot);

            // Assert
            Assert.IsNotNull(serializedJson);
            // This will check if the serialized JSON string contains the expected substrings.
            // Note: This is a very simple check. In a real-world scenario, you would likely want to perform a more thorough validation.
            StringAssert.Contains("\"name\":\"Raleigh\"", serializedJson);
            StringAssert.Contains("\"ru\":\"Роли\"", serializedJson);
            StringAssert.Contains("\"lat\":35.7803977", serializedJson);
            StringAssert.Contains("\"country\":\"US\"", serializedJson);
        }

        // Additional tests can be written to further verify the functionality, such as error handling, null values, etc.

        [TestFixture]
        public class WeatherModelTests
        {
            [Test]
            public void CurrentModel_HoldsDataCorrectly()
            {
                // Arrange
                var current = new Current
                {
                    dt = 1618317040,
                    sunrise = 1618282134,
                    sunset = 1618333901,
                    temp = 284.07,
                    feels_like = 283.58,
                    pressure = 1019,
                    humidity = 87,
                    // Other properties as needed...
                };

                // Act & Assert
                Assert.AreEqual(1618317040, current.dt);
                Assert.AreEqual(1618282134, current.sunrise);
                // Additional asserts for other properties...
            }

            [Test]
            public void DailyModel_HoldsDataCorrectly()
            {
                // Arrange
                var daily = new Daily
                {
                    dt = 1618308000,
                    sunrise = 1618282134,
                    sunset = 1618333901,
                    // Other properties as needed...
                };

                // Act & Assert
                Assert.AreEqual(1618308000, daily.dt);
                // Additional asserts for other properties...
            }

            // Tests for FeelsLike, Hourly, Minutely, Root, Temp, and Weather would follow a similar pattern...

            [Test]
            public void RootModel_HoldsDataCorrectly()
            {
                // Arrange
                var root = new Root
                {
                    lat = 35.6895,
                    lon = 139.6917,
                    timezone = "Asia/Tokyo",
                    timezone_offset = 32400,
                    // You would also instantiate and assign the nested objects like current, minutely, hourly, daily, and alerts here...
                };

                // Act & Assert
                Assert.AreEqual(35.6895, root.lat);
                // Additional asserts for other properties...
            }

            [Test]
            public void WeatherModel_HoldsDataCorrectly()
            {
                // Arrange
                var weather = new Weather
                {
                    id = 800,
                    main = "Clear",
                    description = "clear sky",
                    icon = "01d"
                };

                // Act & Assert
                Assert.AreEqual(800, weather.id);
                Assert.AreEqual("Clear", weather.main);
                // Additional asserts for other properties...
            }

            // Additional tests could include:
            // - Testing deserialization from JSON to ensure that the models can be correctly populated from a JSON string
            // - Testing serialization to JSON if you need to send data back to an API
            // - Testing any custom methods or business logic associated with these models
        }
    }
}
