﻿namespace Lab_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // statki
            Ship myShip = new Ship(new Engine(Fuel.Diesel), 25);
            Ship mySubmarine = new Ship(new Engine(Fuel.Nuclear), 15);

            // produkty
            Product p1 = new Product("Corn", 4);
            Product p2 = new Product("Cocoa", 5);
            Product p3 = new Product("Coconut", 9);
            Product p4 = new Product("Coffee", 2);

            // chetni do kupienia
            Destination aberdeen = new Destination(2100, "Aberdeen");
            Destination bilbao = new Destination(800, "Bilbao");
            Destination ceuta = new Destination(1200, "Ceuta");

            // jednorazowa oferta przewozu
            mySubmarine.TravelOffer(ceuta, p1, p2);
            // ta oferta bedzie skladana do skutku
            bool accepted = false;
            while (!accepted)
            {
                accepted = myShip.TravelOffer(aberdeen, p3, p4);
            }
            // wymiana silnika na nowy model i kolejna oferta
            myShip.Engine = new Engine(Fuel.Hydrogen);
            myShip.TravelOffer(bilbao, p2, p4);
        }
    }
}
