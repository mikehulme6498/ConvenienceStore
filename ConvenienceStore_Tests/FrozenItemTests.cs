using ConvenienceStore;
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
            FrozenItem frozenItem = new FrozenItem("", 50, 10);
            frozenItem.DaysPast(2);
            Assert.AreEqual(48, frozenItem.GetQuality());
        }

        [Test]
        public void SellInShouldDecreaseByOneperDay()
        {
            FrozenItem frozenItem = new FrozenItem("", 50, 10);
            frozenItem.DaysPast(2);
            Assert.AreEqual(8, frozenItem.GetSellIn());
        }

        [Test]
        public void QualityShouldNotGoBelowZero()
        {
            FrozenItem frozenItem = new FrozenItem("", 5, 10);
            frozenItem.DaysPast(6);
            Assert.AreEqual(0, frozenItem.GetQuality());
        }

        [Test]
        public void QualityShouldNotBeAbleToBeSetBelowZero()
        {
            FrozenItem frozenItem = new FrozenItem("", -7, 10);
            Assert.AreEqual(0, frozenItem.GetQuality());
        }

        [Test]
        public void QualityShouldNotBeAbleToBeSetAbove50()
        {
            FrozenItem frozenItem = new FrozenItem("", 51, 10);
            Assert.AreEqual(50, frozenItem.GetQuality());
        }

        [Test]
        [TestCase(3, 45)]
        [TestCase(1, 49)]
        [TestCase(10, 31)]
        [TestCase(0, 50)]
        public void QualityShouldDecreaseDoubleWhenSellByDatePast(int daysPast, int expectedResult)
        {
            FrozenItem frozenItem = new FrozenItem("", 50, 1);
            frozenItem.DaysPast(daysPast);
            Assert.AreEqual(expectedResult, frozenItem.GetQuality());
        }
    }
}
