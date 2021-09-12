using GoogleApi.Entities.Common.Enums;
using GoogleApi.Entities.Common.Extensions;
using GoogleApi.Entities.Maps.Common.Enums;
using GoogleApi.Entities.Maps.StaticMaps.Request.Enums;
using NUnit.Framework;

namespace GoogleApi.UnitTests.Common.Extensions
{
    [TestFixture]
    public class EnumExtensionTest
    {
        [Test]
        public void ToEnumStringTest()
        {
            const AddressComponentType ENUM = AddressComponentType.Postal_Code;

            var result = ENUM.ToEnumString('|');
            Assert.AreEqual("postal_code", result);
        }

        [Test]
        public void ToEnumStringWhenFlagsTest()
        {
            const AvoidWay ENUM = AvoidWay.Highways | AvoidWay.Tolls;

            var result = ENUM.ToEnumString('|');
            Assert.AreEqual("tolls|highways", result);
        }

        [Test]
        public void ToEnumMemberStringTest()
        {
            const StyleFeature ENUM = StyleFeature.Transit;

            var result = ENUM.ToEnumMemberString();
            Assert.AreEqual("transit", result);
        }
    }
}