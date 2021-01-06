using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore
{
    public class FrozenItem : StoreItemBase
    {
        public FrozenItem(string name, int quality, int sellIn) : base(name, quality, sellIn)
        {
            
        }
        internal override void AdjustQuality(int daysPast)
        {
            int tempSellIn = _sellIn;
           
            for (int i = 0; i < daysPast; i++)
            {
                tempSellIn--;

                if(_quality - 1 < minQuality)
                {
                    _quality = 0;
                    return;
                }
                else if(tempSellIn < 0)
                {
                    _quality -= 2;
                }
                else
                {                    
                    _quality--;
                }
            }
        }

        internal override void AdjustSellIn(int daysPast)
        {
            for (int i = 0; i < daysPast; i++)
            {
                _sellIn--;
            }
        }
    }
}
