using ConvenienceStore.ItemQualityLogicModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore.StoreItemModels
{
    public class AgedBrieItem : StoreItemBase
    {
        public AgedBrieItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            SetQualityLogic(new AgedBrieQualityLogic());
        }
        internal override void SetQualityLogic(IQualityAdjustmentLogic logic)
        {
            _qualityLogic = logic;
        }
    }
}
