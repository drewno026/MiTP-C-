using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    public enum Color
    {
        Green,
        Blue, 
        Red
    }
    class RightTriangle
    {
        // pola klasy przechowujace dlugosci przyprostokatnych
        private double a;
        private double b;
        // wlasciwosci klasy odpowiadajace powyzszym polom
        public double A
        {
            get { return a; } // prosty getter - tylko zwraca wartosc
            set // setter - pozwoli ustawic wartosc tylko jesli jest dodatnia
            {
                if (value > 0) a = value; // prosze zwrocic uwage na slowo kluczowe value
            }
        }
        public double B
        {
            get { return b; } // prosty getter - tylko zwraca wartosc
            set // setter - pozwoli ustawic wartosc tylko jesli jest dodatnia
            {
                if (value > 0) b = value;
            }
        }
        public string Name { get; set; }
        public Color TriangleColor { get; set; }  

        // metoda klasy obliczajaca tangens kata w trojkacie A/B
        // zwyczajowa kolejnosc podawania elementow klasy: pola, własciwosci, metody
        public double ComputeTangent()
        {
            return A / B;
        }
        public double ComputeC()
        {
            return Math.Sqrt(A * A + B * B);
        }
        public double ComputeSine()
        {
            double C = ComputeC();
            return A / C;
        }
        public double CircumFerence
        {
            get { return A + B + ComputeC(); }
        }
    }
}
