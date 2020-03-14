using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationStoreCrawler.Models
{
    public class GameSearchResult
    {
        public GameSearchResult(string gameName, double gameOriginalPrice, double gamePrice)
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
