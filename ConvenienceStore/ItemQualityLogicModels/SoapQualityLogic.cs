using System;
using System.Collections.Generic;
using System.Text;

namespace ConvenienceStore.ItemQualityLogicModels
{
    public class SoapQualityLogic : IQualityAdjustmentLogic
    {
        public int AdjustQuality(int currentQuality, int sellIn, int daysPast, int maxQuality, int minQuality)
        {
            return currentQuality;
        }
    }
}
