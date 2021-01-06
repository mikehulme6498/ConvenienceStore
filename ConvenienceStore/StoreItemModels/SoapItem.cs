using ConvenienceStore.ItemQualityLogicModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore.StoreItemModels
{
    public class SoapItem : StoreItemBase
    {
        public SoapItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            SetQualityLogic(new SoapQualityLogic());
        }
        internal override void AdjustSellIn(int daysPast)
        {
            
        }

        internal override void SetQualityLogic(IQualityAdjustmentLogic logic)
        {
            _qualityLogic = logic;
        }
    }
}
