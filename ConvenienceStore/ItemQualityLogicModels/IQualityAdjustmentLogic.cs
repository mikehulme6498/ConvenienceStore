namespace ConvenienceStore.ItemQualityLogicModels
{
    public interface IQualityAdjustmentLogic
    {
        int AdjustQuality(int currentQuality, int sellIn, int daysPast, int maxQuality, int minQuality);
    }
}
