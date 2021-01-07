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
            ConsoleKey key;
            DateTime currentDate = DateTime.Now;

            do
            {
                Console.Clear();
                PrintTable(inventory, currentDate);

                while (daysToJump == 0)
                {
                    Console.Write(" How many days would you like to skip forward? : ");
                    int.TryParse(Console.ReadLine(), out daysToJump);
                }

                SkipDaysForward(inventory, daysToJump);
                currentDate = currentDate.AddDays(daysToJump);
                PrintTable(inventory, currentDate);
                
                Console.Write(" Press (C)ontinue, (S)tart again, (E)xit : ");
                key = Console.ReadKey(true).Key;

                switch (key) 
                {
                    case ConsoleKey.S :
                        inventory = PopulateInventory();
                        currentDate = DateTime.Now;
                        daysToJump = 0;
                        break;
                    case ConsoleKey.C:
                        daysToJump = 0;
                        break;
                    default:
                        break;
                }

            } while (key != ConsoleKey.E);           
        }

        static void SkipDaysForward(List<IStoreItem> items, int daysToSkip)
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
            Console.WriteLine();
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
