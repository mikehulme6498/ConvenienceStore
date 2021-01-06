using ConvenienceStore;
using ConvenienceStore.StoreItemModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore_Tests
{
    public class FrozenItemTests
    {
       [Test]
        public void QualityShouldDecreaseByOneperDay()
        {
            FrozenItem frozenItem = new FrozenItem("", 10, 50);
            frozenItem.DaysPast(2);
            Assert.AreEqual(48, frozenItem.GetQuality());
        }

        [Test]
        public void SellInShouldDecreaseByOneperDay()
        {
            FrozenItem frozenItem = new FrozenItem("", 10, 50);
            frozenItem.DaysPast(2);
            Assert.AreEqual(8, frozenItem.GetSellIn());
        }

        [Test]
        public void QualityShouldNotGoBelowZero()
        {
            FrozenItem frozenItem = new FrozenItem("", 10, 5);
            frozenItem.DaysPast(6);
            Assert.AreEqual(0, frozenItem.GetQuality());
        }

        [Test]
        public void QualityShouldBeAtMaxQualityIfResultIsGreaterThanMaxQuality()
        {
            FrozenItem frozenItem = new FrozenItem("", -1, 55);
            frozenItem.DaysPast(1);
            Assert.AreEqual(50, frozenItem.GetQuality());
        }

        [Test]
        public void QualityShouldBeNotGoBelowMinQuality()
        {
            FrozenItem frozenItem = new FrozenItem("", 5, 5);
            frozenItem.DaysPast(9);
            Assert.AreEqual(0, frozenItem.GetQuality());
        }

        [Test]
        public void TempTest()
        {
            FrozenItem frozenItem = new FrozenItem("", -2, 50);
            frozenItem.DaysPast(5);
            Assert.AreEqual(40, frozenItem.GetQuality());
        }

        [Test]
        public void TestInputFromTechTest1()
        {
            FrozenItem frozenItem = new FrozenItem("", -1, 55);
            frozenItem.DaysPast(1);
            Assert.AreEqual(50, frozenItem.GetQuality());
            Assert.AreEqual(-2, frozenItem.GetSellIn());
        }

        [Test]
        public void TestInputFromTechTest2()
        {
            FrozenItem frozenItem = new FrozenItem("", 2, 2);
            frozenItem.DaysPast(1);
            Assert.AreEqual(1, frozenItem.GetQuality());
            Assert.AreEqual(1, frozenItem.GetSellIn());
        }

        [Test]
        [TestCase(3, 45)]
        [TestCase(1, 49)]
        [TestCase(10, 31)]
        [TestCase(0, 50)]
        public void QualityShouldDecreaseDoubleWhenSellByDatePast(int daysPast, int expectedResult)
        {
            FrozenItem frozenItem = new FrozenItem("", 1, 50);
            frozenItem.DaysPast(daysPast);
            Assert.AreEqual(expectedResult, frozenItem.GetQuality());
        }
    }
}
