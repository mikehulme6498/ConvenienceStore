using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore.StoreItemModels
{
    public class FrozenItem : StoreItemBase
    {
        public FrozenItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }
        internal override void AdjustQuality(int daysPast)
        {
            if (_quality - daysPast > maxQuality)
            {
                _quality = maxQuality;
                return;
            }

            if (_quality - daysPast < minQuality)
            {
                _quality = minQuality;
                return;
            }

            if(daysPast > _sellIn)
            {
                int doubleDaysReduction = Math.Abs((_sellIn - daysPast) * 2);
                int singleDays = (_sellIn - daysPast) + daysPast;
                _quality -= doubleDaysReduction + singleDays;
                return;
            }

            _quality -= daysPast;
        }

    }
}
