using ConvenienceStore.ItemQualityLogicModels;

namespace ConvenienceStore.StoreItemModels
{
    public class FreshItem : StoreItemBase
    {
        
        public FreshItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            SetQualityLogic(new FrozenQualityLogic(true));
        }
        internal override void SetQualityLogic(IQualityAdjustmentLogic logic)
        {
            _qualityLogic = logic;
        }
    }


}
