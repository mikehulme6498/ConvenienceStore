using ConvenienceStore.ItemQualityLogicModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore.StoreItemModels
{
    public class ChristmasCrackerItem : StoreItemBase
    {
        public ChristmasCrackerItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            SetQualityLogic(new ChrismasCrackerQualityLogic());
        }
        internal override void SetQualityLogic(IQualityAdjustmentLogic logic)
        {
            _qualityLogic = logic;
        }
    }
}
