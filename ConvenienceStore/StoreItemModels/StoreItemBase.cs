using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore.StoreItemModels
{
    public abstract class StoreItemBase : IStoreItem
    {
        internal int _quality;
        internal int _sellIn;
        internal string _name;
        internal const int minQuality = 0;
        internal const int maxQuality = 50;


        public StoreItemBase(string name, int sellIn, int quality)
        {
            _quality = quality;
            _sellIn = sellIn;
            _name = name;
        }       

        public void DaysPast(int daysPast)
        {
            AdjustQuality(daysPast);
            AdjustSellIn(daysPast);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Quality : {_quality} - Sell In {_sellIn} days.");
        }

        internal abstract void AdjustQuality(int daysPast);
        internal virtual void AdjustSellIn(int daysPast)
        {
            _sellIn -= daysPast;
        }

        public int GetQuality()
        {
            return _quality;
        }

        public int GetSellIn()
        {
            return _sellIn;
        }

        
       
    }
}
