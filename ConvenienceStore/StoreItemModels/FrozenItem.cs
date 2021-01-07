using ConvenienceStore.ItemQualityLogicModels;

namespace ConvenienceStore.StoreItemModels
{
    public class FrozenItem : StoreItemBase
    {
        public FrozenItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            SetQualityLogic(new FrozenQualityLogic());
        }
        internal override void SetQualityLogic(IQualityAdjustmentLogic logic)
        {
            _qualityLogic = logic;
        }
    }
}
