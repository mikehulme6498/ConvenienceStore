namespace ConvenienceStore.ItemQualityLogicModels
{
    public class AgedBrieQualityLogic : IQualityAdjustmentLogic
    {
        public int AdjustQuality(int currentQuality, int sellIn, int daysPast, int maxQuality, int minQuality)
        {
            return currentQuality += daysPast;
        }
    }
}
