using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore.ItemQualityLogicModels
{
    public class AgedBrieQualityLogic : IQualityAdjustmentLogic
    {
        public int AdjustQuality(int currentQuality, int sellIn, int daysPast, int maxQuality, int minQuality)
        {

            if (currentQuality + daysPast > maxQuality)
            {
                return maxQuality;
            }
            if (currentQuality + daysPast < minQuality)
            {
                return minQuality;
            }
            
            return currentQuality += daysPast;
            
        }
    }
}
