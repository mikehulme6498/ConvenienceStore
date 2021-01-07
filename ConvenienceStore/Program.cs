using ConsoleTables;
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
            int daysToJump = 0;
            DateTime currentDate = DateTime.Now;

            InvalidItem invalidItem = new InvalidItem("INVALID ITEM", 2, 2);
            invalidItem.DaysPast(3);
            
            PrintTable(inventory, currentDate);

            while (daysToJump == 0) 
            {
                Console.Write(" How many days would you like to skip forward? : ");
                int.TryParse(Console.ReadLine(), out daysToJump);
            }

            SkipForward(inventory, daysToJump);
            currentDate = currentDate.AddDays(daysToJump);
            Console.WriteLine();
           
            PrintTable(inventory, currentDate);
            
            Console.Read();

        }

        static void SkipForward(List<IStoreItem> items, int daysToSkip)
        {
            foreach (var item in items)
            {
                item.DaysPast(daysToSkip);
            }
        }

        static void PrintTable(List<IStoreItem> items, DateTime date)
        {
            var table = new ConsoleTable(new string[] { "Item", "Sell In (Days)", "Quality" });
            foreach (var item in items)
            {
                string sellIn = item.GetSellIn() == int.MaxValue ? "" : item.GetSellIn().ToString();
                string quality = item.GetQuality() == int.MaxValue ? "" : item.GetQuality().ToString();
                table.AddRow(item.GetName(), sellIn, quality);
            }
            Console.WriteLine($" Current Inventory - {date.ToShortDateString()}");
            Console.WriteLine(" ==============================");
            Console.WriteLine();
            table.Write(Format.Alternative);

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
                new FrozenItem("Frozen Item", 2 , 2),
                new InvalidItem("INVALID ITEM", 2, 2),
                new FreshItem("Fresh Item", 2, 2),
                new FreshItem("Fresh Item", -1, 5)
            };

            return output;
        }
    }
}
