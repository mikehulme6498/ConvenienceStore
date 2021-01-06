using ConvenienceStore.StoreItemModels;
using System;

namespace ConvenienceStore
{
    class Program
    {
        static void Main()
        {
            IStoreItemBase frozenItem = new FrozenItem("Frozen Item", 55, -1);
            frozenItem.DaysPast(1);
            frozenItem.DisplayInfo();
            Console.Read();

        }
    }
}
