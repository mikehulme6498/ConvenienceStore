using ConvenienceStore.ItemQualityLogicModels;
using ConvenienceStore.StoreItemModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore_Tests
{
    public class FreshItemTests
    {
        [Test]
        public void QualityShouldDecreaseByOneperDay()
        {
            FreshItem freshItem = new FreshItem("", 10, 50);
            freshItem.DaysPast(2);
            Assert.AreEqual(46, freshItem.GetQuality());
        }

        [Test]
        public void SellInShouldDecreaseByOneperDay()
        {
            FreshItem freshItem = new FreshItem("", 10, 50);
            freshItem.DaysPast(2);
            Assert.AreEqual(8, freshItem.GetSellIn());
        }

        [Test]
        public void QualityShouldNotGoBelowZero()
        {
            FreshItem freshItem = new FreshItem("", 10, 5);
            freshItem.DaysPast(6);
            Assert.AreEqual(0, freshItem.GetQuality());
        }

        [Test]
        public void QualityShouldBeAtMaxQualityIfResultIsGreaterThanMaxQuality()
        {
            FreshItem freshItem = new FreshItem("", -1, 60);
            freshItem.DaysPast(1);
            Assert.AreEqual(50, freshItem.GetQuality());
        }

        [Test]
        public void QualityShouldBeNotGoBelowMinQuality()
        {
            FreshItem freshItem = new FreshItem("", 5, 5);
            freshItem.DaysPast(9);
            Assert.AreEqual(0, freshItem.GetQuality());
        }

        [Test]
        public void TestInputFromTechTest1()
        {
            FreshItem freshItem = new FreshItem("", 2, 2);
            freshItem.DaysPast(1);
            Assert.AreEqual(0, freshItem.GetQuality());
            Assert.AreEqual(1, freshItem.GetSellIn());
        }

        [Test]
        public void TestInputFromTechTest2()
        {
            FreshItem freshItem = new FreshItem("", -1, 5);
            freshItem.DaysPast(1);
            Assert.AreEqual(1, freshItem.GetQuality());
            Assert.AreEqual(-2, freshItem.GetSellIn());
        }

        //[Test]
        //[TestCase(3, 45)]
        //[TestCase(1, 49)]
        //[TestCase(10, 31)]
        //[TestCase(0, 50)]
        //public void QualityShouldDecreaseDoubleWhenSellByDatePast(int daysPast, int expectedResult)
        //{
        //    FrozenItem frozenItem = new FrozenItem("", 1, 50);
        //    frozenItem.DaysPast(daysPast);
        //    Assert.AreEqual(expectedResult, frozenItem.GetQuality());
        //}
    }
}
