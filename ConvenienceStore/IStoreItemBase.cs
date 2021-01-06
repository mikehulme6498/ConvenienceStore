namespace ConvenienceStore
{
    public interface IStoreItemBase
    {
        void DaysPast(int daysPast);
        void DisplayInfo();
        int GetQuality();
        int GetSellIn();
    }
}