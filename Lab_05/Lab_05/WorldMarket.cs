using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class WorldMarket
    {
        private static Random rnd = new Random();
        public int Price {  get; set; }
        public WorldMarket(int price)
        {
            Price = price;
        }
        public static int GetInitialPricePerTon()
        {
            return rnd.Next(100, 1000);
        }
        public static int GetNewPricePerTon(int currentPrice)
        {
            int change = rnd.Next(-50, 200);
            return currentPrice + change;
        }
    }
}
