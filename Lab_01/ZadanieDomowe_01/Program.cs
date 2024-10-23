using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZadanieDomowe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            //1----------------------------------------------
            //trzy kolejne pętle (for, while oraz do...while) wypisujące coś na ekran w taki sposób,
            //żeby rezultat działania każdej z nich wyglądał identycznie
            Console.WriteLine("Podpunkt 1:");

            for (number1 = 0; number1 < 5; number1++) { 
                Console.Write(number1); 
            }
            Console.WriteLine("\n");
            number1 = 0;

            while (number1 < 5)
            {
                Console.Write(number1);
                number1++;
            }
            Console.WriteLine("\n");
            number1 = 0;

            do {
                Console.Write(number1);
                number1++;
            } while (number1 < 5);
            Console.WriteLine();
            number1 = 2;
            //2----------------------------------------------
            //sprawdzenie określonego warunku przy pomocy instrukcji if...else if...else, a następnie
            //sprawdzenie tego samego warunku przy pomocy instrukcji switch...case ...default
            Console.WriteLine("Podpunkt 2:");

            switch (number1)
            {
                case 0:
                    Console.WriteLine(number1);
                    break;
                case 1:
                    Console.WriteLine(number1);
                    break;
                default:
                    Console.WriteLine(number1);
                    break;
            }

            if (number1 == 0) {
                Console.WriteLine(number1);
            } else if (number1 == 1) {
                Console.WriteLine(number1);
            } else {
                Console.WriteLine(number1);
            }
            Console.WriteLine();
            //3----------------------------------------------
            //zagnieżdżoną pętlę, a w jej środku jeden if sprawdzający dwa warunki naraz
            Console.WriteLine("Podpunkt 3:");

            for (number1 = 0; number1 < 4; number1++)
            {
                for (int number2 = 2; number2 <= 4; number2++)
                {

                    if (number1 > 0 && number1 < 3)
                    {
                        Console.WriteLine(number1);
                    }
                }
            }
            Console.WriteLine();
            //4----------------------------------------------
            //pętlę zawierającą w środku instrukcję break oraz inną pętlę z instrukcją continue
            Console.WriteLine("Podpunkt 4:");

            for (int number2 = 0; number2 < 4;) {
                for (int number3 = 0; number3 < 2; number3++) {
                    Console.WriteLine("continue");
                    continue;
                 }
                break;
            }
            //5----------------------------------------------
            //pętlę for, która wyświetli na ekranie liczby całkowite od 0 do 10, ale w swoim kodzie
            //nie będzie używała znaku +ani cyfry 1
            Console.Write("\n");
            Console.WriteLine("Podpunkt 5:");

            for (int number2 = 0; number2 >= -10; number2--) {
                Console.WriteLine(-number2);
            }
            //6----------------------------------------------
            //(na sam koniec) pętlę, która będzie wykonywać się w nieskończoność, dopóki
            //użytkownik nie zamknie programu ręcznie
            Console.WriteLine("Podpunkt 5: ");

            while(true) {}
        }
    }
}
