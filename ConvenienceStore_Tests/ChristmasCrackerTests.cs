using ConvenienceStore.StoreItemModels;
using NUnit.Framework;

namespace ConvenienceStore_Tests
{
    public class ChristmasCrackerTests
    {
        [Test]
        public void QualityShouldIncreaseBy3PerDay()
        {
            ChristmasCrackerItem crackerItem = new ChristmasCrackerItem("", 4, 2);
            crackerItem.DaysPast(3);
            Assert.AreEqual(11, crackerItem.GetQuality());
        }

        [Test]
        public void QualityShouldIncreaseBy2PerDay()
        {
            ChristmasCrackerItem crackerItem = new ChristmasCrackerItem("", 7, 2);
            crackerItem.DaysPast(3);
            Assert.AreEqual(8, crackerItem.GetQuality());
        }

        [Test]
        public void QualityShouldIncreaseBy1PerDay()
        {
            ChristmasCrackerItem crackerItem = new ChristmasCrackerItem("", 11, 2);
            crackerItem.DaysPast(3);
            Assert.AreEqual(5, crackerItem.GetQuality());
        }

        [Test]
        public void QualityShoulNotGoAboveMaximum()
        {
            ChristmasCrackerItem crackerItem = new ChristmasCrackerItem("", 11, 2);
            crackerItem.DaysPast(200);
            Assert.AreEqual(50, crackerItem.GetQuality());
        }

        [Test]
        public void QualityShouldGotoZeroAfterSellBy()
        {
            ChristmasCrackerItem crackerItem = new ChristmasCrackerItem("", 0, 20);
            crackerItem.DaysPast(1);
            Assert.AreEqual(0, crackerItem.GetQuality());
        }

        [Test]
        public void TestInputFromTechTest()
        {
            ChristmasCrackerItem crackerItem = new ChristmasCrackerItem("", -1, 2);
            crackerItem.DaysPast(1);
            Assert.AreEqual(-2, crackerItem.GetSellIn());
            Assert.AreEqual(0, crackerItem.GetQuality());

        }
        [Test]
        public void TestInputFromTechTest2()
        {
            ChristmasCrackerItem crackerItem = new ChristmasCrackerItem("", 9, 2);
            crackerItem.DaysPast(1);
            Assert.AreEqual(8, crackerItem.GetSellIn());
            Assert.AreEqual(4, crackerItem.GetQuality());
        }
    }
}
