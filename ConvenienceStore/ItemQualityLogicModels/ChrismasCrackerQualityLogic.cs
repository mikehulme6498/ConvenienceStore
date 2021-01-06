namespace ConvenienceStore.ItemQualityLogicModels
{
    public class ChrismasCrackerQualityLogic : IQualityAdjustmentLogic
    {
        public int AdjustQuality(int currentQuality, int sellIn, int daysPast, int maxQuality, int minQuality)
        {

            if (sellIn < 0)
            {
                return 0;
            }
            if (sellIn < 5)
            {
                return currentQuality += (3 * daysPast);
            }

            if (sellIn < 10)
            {
                return currentQuality += (2 * daysPast);
            }

            return currentQuality += daysPast;
        }
    }
}
