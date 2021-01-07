using ConvenienceStore.StoreItemModels;
using NUnit.Framework;

namespace ConvenienceStore_Tests
{
    public class InvalidItemTests
    {
        [Test]
        public void NameShouldChangeToNoSuchItem()
        {
            InvalidItem item = new InvalidItem("INVALID ITEM", 2, 2);
            item.DaysPast(1);
            Assert.AreEqual("NO SUCH ITEM", item.GetName());
        }
    }
}
