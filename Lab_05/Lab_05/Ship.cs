using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class Ship
    {
        public Engine Engine { get; set; }
        private int MassOfUnloadedShip {  get; set; }
        public Ship()
        {
            Engine = new Engine(Fuel.Diesel);
            MassOfUnloadedShip = 25;
        }
        public Ship(Engine engine, int massOfUnloadedShip)
        {
            if (massOfUnloadedShip <= 0)
                throw new ArgumentException("Mass must be greater of 0");
            Engine = engine;
            MassOfUnloadedShip = massOfUnloadedShip;
        }
        public bool TravelOffer(Destination destination, Product product1, Product product2)
        {
            int totalMass = MassOfUnloadedShip + product1.Mass + product2.Mass;
            int totalPrice = product1.GetCurrentValue() + product2.GetCurrentValue();
            int travelCost = Engine.travelCost(destination.Distance, totalMass);
            bool isProfitable = (totalPrice - travelCost) >= 100;
            if (isProfitable)
            {
                int travelTime = Engine.travelTime(destination.Distance, totalMass);
                Console.WriteLine($"Destination: {destination.PortName}");
                Console.WriteLine($"Cargo details: \n Product 1: {product1.ProductName} \n Product 2: {product2.ProductName}");
                Console.Write($"Total cargo mass: {product1.Mass + product2.Mass}");
                Console.WriteLine($", Travel time: {travelTime} hours, Total sale price: {totalPrice}");
                Console.WriteLine($"Travel cost: {travelCost}, Income: {totalPrice - travelCost}\n");
            }
            else
            {
                Console.WriteLine($"Traveling to {destination.PortName} is too expnsive\n");
            }
            return isProfitable;
        }
    }
}
