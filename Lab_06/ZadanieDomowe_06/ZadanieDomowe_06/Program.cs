using B6;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

namespace ZadanieDomowe_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Proszę sprawdzić, jaki jest najwyższy szczyt Austrii i wyświetlić jego dane na
            //ekranie
            List<HighestPeak> highestPeaksOfEurope = Homework.CreateList();
            Console.WriteLine("Highest peak of Austria: ");
            HighestPeak highestPeakOfAustria = highestPeaksOfEurope.Find(peak => peak.Country == "Austria");
            highestPeakOfAustria.ShowInfo();

            //Proszę sprawdzić, jaki szczyt znajduje się na przedostatniej pozycji listy i
            //wyświetlić jego dane na ekranie.
            Console.WriteLine("Second last peak on the list: ");
            HighestPeak SecondLastPeakOnList = highestPeaksOfEurope[highestPeaksOfEurope.Count - 2];
            SecondLastPeakOnList.ShowInfo();

            //Proszę obliczyć średnią arytmetyczną wysokości szczytów zapisanych na liście
            //i wyświetlić ją na ekranie.
            double totalElevation = 0;
            foreach(var peak in highestPeaksOfEurope)
            {
                totalElevation += peak.Elevation;
            }
            double averageElevation = totalElevation / highestPeaksOfEurope.Count;
            Console.WriteLine("\nAvarage elevation of peaks: " + Math.Round(averageElevation, 2));

            //Proszę wypisać na ekranie wszystkie szczyty o wysokości pomiędzy 4000
            //metrów a 5000 metrów
            Console.WriteLine("\nAll peaks between 4000 and 5000 meters: ");
            foreach(var peak in highestPeaksOfEurope)
            {
                if (peak.Elevation <= 5000 && peak.Elevation >= 4000)
                    Console.WriteLine(peak.Name);
            }

            // Proszę posortować elementy listy od najniższej do najwyższej wysokości.
            //Następnie proszę wyświetlić na ekranie dziesięć pierwszych pozycji tak posortowanej
            //listy.
            Console.WriteLine("\n10 lowest elevations: ");
            highestPeaksOfEurope = highestPeaksOfEurope.OrderBy(peak => peak.Elevation).ToList();
            for (int i = 0; i < 10; i++)
            {
                highestPeaksOfEurope[i].ShowInfo();
            }

            //Proszę odnaleźć kraj o liczbie mieszkańców 5.5 miliona i wyświetlić jego
            //nazwę na ekranie.
            Dictionary<string, double> myDict = Homework.CreateDictionary();
            Console.Write("\nCountry which has a population of 5.5 millions: ");
            var country = myDict.FirstOrDefault(entry => entry.Value == 5.5);
            Console.WriteLine(country.Key);

        }
    }
}
