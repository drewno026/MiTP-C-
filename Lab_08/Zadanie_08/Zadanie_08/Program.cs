using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = ZadanieDomowe.Read();

            //(1 pkt) Proszę znaleźć i wypisać na ekran wszystkie słowa składające się z dokładnie
            //trzynastu liter.
            // A 
            Console.WriteLine("Podpunkt A:\n");
            List<string> answerA = words.Where(word => word.Length == 13).ToList();
            foreach (string word in answerA) Console.WriteLine(word);
            Console.WriteLine();

            //(2 pkt) Proszę zastąpić każde słowo w tekście jego pierwszą literą i wypisać na ekran
            //dwadzieścia pierwszych rezultatów.
            // B
            Console.WriteLine("Podpunkt B:\n");
            List<char> answerB = words.Select(word => word.First()).ToList();
            for (int i = 0; i < 20; i++) Console.WriteLine(answerB[i]);
            Console.WriteLine();

            //(2 pkt) Proszę obliczyć średnią długość wszystkich słów w tekście, zakładając, że
            //powtarzające się słowa liczymy tylko raz. Wynik należy podać jako liczbę
            //zmiennoprzecinkową.
            // E
            Console.WriteLine("Podpunkt E:\n");
            double answerE = words.Distinct().Average(word => word.Length);
            Console.WriteLine("{0:0.0}", answerE);
            Console.WriteLine();

            //(2 pkt) Proszę sprawdzić, czy wszystkie słowa o długości większej niż dziesięć liter
            //zawierają małą literę 'z'.Odpowiedź należy podać jako typ logiczny True/ False.
            //Pomocna może okazać się metoda String.Contains.
            // F
            Console.WriteLine("Podpunkt F:\n");
            bool answerF = words.All(word => word.Length <= 10 || word.Contains('z'));
            Console.WriteLine(answerF);
            Console.WriteLine();

            //(3 pkt) Proszę obliczyć, ile jest wszystkich liter w tekście
            // G
            Console.WriteLine("Podpunkt G:\n");
            int answerG = words.Sum(word => word.Length);
            Console.WriteLine(answerG);
            Console.WriteLine();

        }

    }
}
