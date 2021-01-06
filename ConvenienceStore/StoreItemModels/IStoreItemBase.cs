namespace ConvenienceStore.StoreItemModels
{
    public interface IStoreItem
    {
        void DaysPast(int daysPast);
        void DisplayInfo();
        int GetQuality();
        int GetSellIn();
    }
}