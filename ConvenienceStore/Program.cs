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

           
            PrintTable(inventory, DateTime.Now);

            while (daysToJump == 0) 
            {
                Console.Write(" How Many days would you like to skip forward? : ");
                int.TryParse(Console.ReadLine(), out daysToJump);
            }           

            
            Console.WriteLine();
            foreach (var item in inventory)
            {
                item.DaysPast(daysToJump);
            }
            PrintTable(inventory, DateTime.Now.AddDays(daysToJump));
            
            Console.Read();

        }

        static void PrintTable(List<IStoreItem> items, DateTime date)
        {
            var table = new ConsoleTable(new string[] { "Item", "Sell In (Days)", "Quality" });
            foreach (var item in items)
            {
                table.AddRow(item.GetName(), item.GetSellIn(), item.GetQuality());
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
                new FreshItem("Fresh Item", 2, 2),
                new FreshItem("Fresh Item", -1, 5)
            };

            return output;
        }
    }
}
