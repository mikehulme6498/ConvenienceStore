using ConvenienceStore.ItemQualityLogicModels;

namespace ConvenienceStore.StoreItemModels
{
    public class SoapItem : StoreItemBase
    {
        public SoapItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            SetQualityLogic(new SoapQualityLogic());
        }
        internal override void AdjustSellIn(int daysPast)
        {
            // No logic needed for soap items
        }
        internal override void SetQualityLogic(IQualityAdjustmentLogic logic)
        {
            _qualityLogic = logic;
        }
    }
}
