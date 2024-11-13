using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_04
{
    internal class MenuItem
    {
        public string DishName { get; set; }
        public double Price { get; set; }
        public static double TotalOrder { get; private set; } = 0.0;
    
        public MenuItem(string dishName, double price)
        {
            DishName = dishName;
            Price = price;
            TotalOrder = TotalOrder + price;
        }
    
        public MenuItem(MenuItem other)
        {
            DishName = other.DishName;
            Price = other.Price;
            TotalOrder = TotalOrder + other.Price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{DishName}, Price: {Price:C}");
        }

    }
}
