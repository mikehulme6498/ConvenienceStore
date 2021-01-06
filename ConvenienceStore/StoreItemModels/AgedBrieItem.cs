using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore.StoreItemModels
{
    public class AgedBrieItem : StoreItemBase
    {
        public AgedBrieItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }
        internal override void AdjustQuality(int daysPast)
        {
            
            if (_quality + daysPast > maxQuality)
            {
                _quality = maxQuality;
            }
            else if(_quality + daysPast < minQuality)
            {
                _quality = minQuality;
            }
            else
            {
                _quality+=daysPast;
            }
        }

        
    }
}
