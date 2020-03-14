namespace PlaystationStoreCrawler.Core.Search.Queries
{
    public class GameSearchRequestResult
    {
        public GameSearchRequestResult(string gameName, double gameOriginalPrice, double gamePrice)
        {
            GameName = gameName;
            GameOriginalPrice = gameOriginalPrice;
            GamePrice = gamePrice;
        }

        public string GameName { get; private set; }
        public double GameOriginalPrice { get; private set; }
        public double GamePrice { get; private set; }
    }
}