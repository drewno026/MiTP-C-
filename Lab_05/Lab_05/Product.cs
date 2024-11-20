using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class Product
    {
        public int currentPrice {  get; set; }
        public string ProductName { get; private set; }
        private int mass;
        public int Mass 
        {
            get { return mass; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Mass cannot be negative.");
                mass = value;
            }
        }
        public Product(string Name)
        {
            ProductName = Name;
            Mass = 0;
            currentPrice = WorldMarket.GetInitialPricePerTon();
        }
        public Product(string Name, int mass)
        {
            ProductName = Name;
            if (mass <= 0)
                throw new ArgumentException("Mass cannot be nagative");
            Mass = mass;
            currentPrice = WorldMarket.GetInitialPricePerTon();
        }
        public int GetCurrentValue()
        {
            int newPrice = WorldMarket.GetNewPricePerTon(currentPrice);
            return Mass * newPrice;
        }

    }
}
