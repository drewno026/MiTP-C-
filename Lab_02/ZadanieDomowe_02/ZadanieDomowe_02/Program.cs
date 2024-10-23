namespace ZadanieDomowe_02
{
    internal class Program
    {
//G) Dowolna funkcja wykorzystująca do czegoś rekurencję, inna niż przykład z
//instrukcji.
        static int SumOfDigits(int number)
        {
            if (number < 10)
            {
                return number;
            }
            else
            {
                return (number % 10) + SumOfDigits(number / 10);
            }

        }
//H) Funkcja double Solution(double a, double b, double c), która zwróci dowolne
//rozwiązanie równania kwadratowego ax
//2 + bx + c = 0. Jeżeli równanie nie ma
//rzeczywistych rozwiązań, należy zwrócić wartość Double.NaN(skrót od Not a
//Number). 
        static double Solution(double a, double b, double c)
        {
            if (a == 0 && b != 0)
            {
                double x1;
                x1 = (-c) / b;
                return x1;
            }else if (a == 0 && b == 0)
            {
                return Double.NaN;
            }else
            {
                double x1;
                double x2;
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta > 0) 
                {
                    x1 = (-b - Math.Sqrt(delta))/(2 * a);
                    x2 = (-b + Math.Sqrt(delta))/(2 * a);

                    return x2;
                }else if(delta == 0)
                {
                    x1 = x2 = (-b) / (2 * a);
                    return x2;
                }
                else
                {
                    return Double.NaN;
                }
            }
        }
//I) Funkcja sumująca liczby od 1 do 40 podzielne przez 7, używająca rekurencji.
//Odpowiedź: 105.
     static int SumDivisibleBySeven(int number1)
        {
            if (number1 < 1)
            {
                return 0;
            } 
            if ((number1 % 7) == 0) { 
            
                return number1 + SumDivisibleBySeven(number1 - 1);
            }else
            {
                return SumDivisibleBySeven(number1 - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podpunkt G(suma cyfr 123456)");
            int wynikG = SumOfDigits(123456);
            Console.WriteLine(wynikG);

            Console.WriteLine("\nPodpunkt H(rozwiazanie rownania kwadratowego)");
            double wynikH = Solution(0, 2, -3);
            Console.WriteLine(wynikH);

            Console.WriteLine("\nPodpunkt I(suma liczb podzielnych przez 7 do 40)");
            int wynikI = SumDivisibleBySeven(40);
            Console.WriteLine(wynikI);
        }
    }
}
