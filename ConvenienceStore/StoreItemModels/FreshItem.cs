using ConvenienceStore.ItemQualityLogicModels;

namespace ConvenienceStore.StoreItemModels
{
    public class FreshItem : StoreItemBase
    {
        IQualityAdjustmentLogic qualityAdjustmentLogic;

        public FreshItem(string name, int sellIn, int quality, IQualityAdjustmentLogic qualityLogic) : base(name, sellIn, quality)
        {
            qualityAdjustmentLogic = qualityLogic;
        }

        internal override void AdjustQuality(int daysPast)
        {
            _quality = qualityAdjustmentLogic.AdjustQuality(_quality, _sellIn, daysPast, maxQuality, minQuality);
            _quality = qualityAdjustmentLogic.AdjustQuality(_quality, _sellIn, daysPast, maxQuality, minQuality);
        }


    }


}
