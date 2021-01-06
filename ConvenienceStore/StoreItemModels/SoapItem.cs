using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore.StoreItemModels
{
    public class SoapItem : StoreItemBase
    {
        public SoapItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }
        internal override void AdjustQuality(int daysPast)
        {
            
        }

        internal override void AdjustSellIn(int daysPast)
        {
            
        }
    }
}
