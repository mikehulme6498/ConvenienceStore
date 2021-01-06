using ConvenienceStore.StoreItemModels;
using System;
using System.Collections.Generic;

namespace ConvenienceStore
{
    class Program
    {
        static void Main()
        {
            List<IStoreItem> inventory = PopulateInventory();

            foreach (var item in inventory)
            {
                item.DaysPast(1);
                item.DisplayInfo();
            }
            Console.Read();

        }

        static List<IStoreItem> PopulateInventory()
        {
            List<IStoreItem> output = new List<IStoreItem>()
            {
                new AgedBrieItem("Aged Brie", 1, 1),
                new ChristmasCrackerItem("Christmas Cracker", -1, 2),
                new ChristmasCrackerItem("Christmas Cracker", 9, 2),
                new SoapItem("Soap", 2, 2),
                new FrozenItem("Frozen Item", -1, 55),
                new FrozenItem("Frooze Item", 2 , 2),
                new FreshItem("Fresh Item", 2, 2),
                new FreshItem("Fresh Item", 2, 2)
            };

            return output;
        }
    }
}
