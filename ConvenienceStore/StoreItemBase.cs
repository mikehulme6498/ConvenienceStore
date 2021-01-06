﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore
{
    public abstract class StoreItemBase : IStoreItemBase
    {
        internal int _quality;
        internal int _sellIn;
        internal string _name;
        internal const int minQuality = 0;
        internal const int maxQuality = 50;


        public StoreItemBase(string name, int sellIn, int quality)
        {
            SetQuality(quality);
            _sellIn = sellIn;
            _name = name;
        }

        private void SetQuality(int quality)
        {
            // TODO: Waiting on reply from Sam to see if this logic is needed - Remove if not

            //if (quality > maxQuality)
            //{
            //    _quality = 50;
            //}
            //else if(quality < minQuality)
            //{
            //    _quality = minQuality;
            //}
            //else
            //{
                _quality = quality;
            //}
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
