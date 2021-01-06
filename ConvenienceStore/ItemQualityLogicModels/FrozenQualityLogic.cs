using System;

namespace ConvenienceStore.ItemQualityLogicModels
{
    public class FrozenQualityLogic : IQualityAdjustmentLogic
    {
        public int AdjustQuality(int currentQuality, int sellIn, int daysPast, int maxQuality, int minQuality)
        {

            if (currentQuality - daysPast > maxQuality)
            {
                return maxQuality;
            }

            if (currentQuality - daysPast < minQuality)
            {
                return minQuality;
            }

            if (daysPast > sellIn)
            {
                int doubleDaysReduction = Math.Abs((sellIn - daysPast) * 2);
                int singleDays = (sellIn - daysPast) + daysPast;
                currentQuality -= doubleDaysReduction + singleDays;
                return currentQuality;
            }

            return currentQuality -= daysPast;
        }
    }


}
