using ConvenienceStore.StoreItemModels;
using NUnit.Framework;

namespace ConvenienceStore_Tests
{
    public class SoapItemTests
    {
        [Test]
        public void QualityShouldNotChange()
        {
            SoapItem soapItem = new SoapItem("", 5, 5);
            Assert.AreEqual(5, soapItem.GetQuality());
        }

        [Test]
        public void SellInShouldNotChange()
        {
            SoapItem soapItem = new SoapItem("", 5, 5);
            Assert.AreEqual(5, soapItem.GetSellIn());
        }

        [Test]
        public void TestInputFromTechTest()
        {
            SoapItem soapItem = new SoapItem("", 2, 2);
            Assert.AreEqual(2, soapItem.GetQuality());
            Assert.AreEqual(2, soapItem.GetSellIn());
        }
    }
}
