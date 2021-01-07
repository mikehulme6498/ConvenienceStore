using ConvenienceStore.StoreItemModels;
using NUnit.Framework;

namespace ConvenienceStore_Tests
{
    public class AgedBrieItemTests
    {
        [Test]
        public void QualityShouldIncreaseByOneperDay()
        {
            AgedBrieItem agedBrieItem = new AgedBrieItem("", 5, 5);
            agedBrieItem.DaysPast(2);
            Assert.AreEqual(7, agedBrieItem.GetQuality());
        }

        [Test]
        public void QualityShouldGoAboveMaxQualityLimit()
        {
            AgedBrieItem agedBrieItem = new AgedBrieItem("", 5, 5);
            agedBrieItem.DaysPast(56);
            Assert.AreEqual(50, agedBrieItem.GetQuality());
        }

        [Test]
        public void QualityShouldNotGoBelowMinimum()
        {
            AgedBrieItem agedBrieItem = new AgedBrieItem("", 5, -10);
            agedBrieItem.DaysPast(2);
            Assert.AreEqual(0, agedBrieItem.GetQuality());
        }

        [Test]
        public void TestInputFromTechTest()
        {
            AgedBrieItem agedBrieItem = new AgedBrieItem("", 1, 1);
            agedBrieItem.DaysPast(1);
            Assert.AreEqual(2, agedBrieItem.GetQuality());
            Assert.AreEqual(0, agedBrieItem.GetSellIn());
        }
    }
}
