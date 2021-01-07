using ConvenienceStore.ItemQualityLogicModels;

namespace ConvenienceStore.StoreItemModels
{
    public class InvalidItem : StoreItemBase
    {
        public InvalidItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            SetQualityLogic(new SoapQualityLogic());
        }
        internal override void SetQualityLogic(IQualityAdjustmentLogic logic)
        {
            _qualityLogic = logic;
        }
    }
}
