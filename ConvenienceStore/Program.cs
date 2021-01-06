using ConvenienceStore.StoreItemModels;
using System;

namespace ConvenienceStore
{
    class Program
    {
        static void Main()
        {
            IStoreItem frozenItem = new FrozenItem("Frozen Item", -1, 55);
            frozenItem.DaysPast(1);
            frozenItem.DisplayInfo();
            Console.Read();

        }
    }
}
