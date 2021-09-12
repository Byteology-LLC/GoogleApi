using System;
using GoogleApi.Entities.Maps.Common;
using NUnit.Framework;

namespace GoogleApi.UnitTests.Maps.Common
{
    [TestFixture]
    public class PlaceTests
    {
        [Test]
        public void ConstructorTest()
        {
            var place = new Place("id");

            Assert.AreEqual("id", place.Id);
        }

        [Test]
        public void ConstructorWhenNullTest()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var address = new Place(null);
                Assert.IsNotNull(address);
            });
        }

        [Test]
        public void ToStringTest()
        {
            var place = new Place("id");

            var toString = place.ToString();
            Assert.AreEqual(place.Id, toString);
        }

        [Test]
        public void ToStringWhenPrefixTest()
        {
            var place = new Place("id");
            const string PREFIX = "place_id";

            var toString = place.ToString(PREFIX);
            Assert.AreEqual($"{PREFIX}:{place.Id}", toString);
        }
    }
}