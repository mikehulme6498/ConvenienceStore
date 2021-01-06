using System;

namespace ConvenienceStore
{
    class Program
    {
        static void Main(string[] args)
        {
            IStoreItemBase frozenItem = new FrozenItem("Frozen Item", 2, 2);
            frozenItem.DaysPast(1);
            frozenItem.DisplayInfo();
            Console.Read();

        }
    }
}
