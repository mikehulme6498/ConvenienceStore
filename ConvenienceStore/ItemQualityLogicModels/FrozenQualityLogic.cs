using System;

namespace ConvenienceStore.ItemQualityLogicModels
{
    public class FrozenQualityLogic : IQualityAdjustmentLogic
    {
        private bool _doubleResult;
        public FrozenQualityLogic(bool doubleResult = false)
        {
            _doubleResult = doubleResult;
        }
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

            if(sellIn < 0)
            {
                return _doubleResult ? currentQuality = currentQuality - (daysPast * 4) : currentQuality - (daysPast * 2);
            }

            if (daysPast > sellIn && !_doubleResult)
            {
                int doubleDaysReduction = Math.Abs((sellIn - daysPast) * 2);
                int singleDays = (sellIn - daysPast) + daysPast;
                currentQuality -= doubleDaysReduction + singleDays;
                return currentQuality;
            }

            return _doubleResult ? currentQuality -= daysPast * 2 : currentQuality -= daysPast ;
        }
    }


}
