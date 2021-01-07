namespace ConvenienceStore.StoreItemModels
{
    public interface IStoreItem
    {
        void DaysPast(int daysPast);
        int GetQuality();
        int GetSellIn();
        string GetName();
    }
}