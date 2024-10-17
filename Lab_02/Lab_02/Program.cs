namespace Lab_02
{
    internal class Program
    {
        static double Pythagoras(double a, double b)
        {
            double result; // zmienna pomocnicza
            result = Math.Sqrt(a * a + b * b); // wykonaj dzialanie
            return result; // zwroc wartosc
                           // ponizej wersja skrocona do jednej linijki, rowniez skompiluje sie poprawnie:
                           // return Math.Sqrt(a*a+b*b);
        }
        static bool IsPrime(int number1)
        {
            if (number1 < 2)
                return false;
            for (int i = 2; i * i <= number1; i++)
            {
                if (number1 % i == 0)
                    return false;
            }
            return true;
        }


        static int Factorial(int number)
        {
            if (number == 0 || number ==1)
                return 1;
            else 
                return number * Factorial(number - 1);
        }

        static void PrintFactorial(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Number is lower than 0 ");
                return;
            } else
            {
                Console.WriteLine("Factorial of " + number + " is equal to: " + Factorial(number));
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Factorial of 5 is equal to:" + Factorial(5));
            PrintFactorial(5);
            PrintFactorial(6);
            PrintFactorial(4);




            //2-----------------------------------
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (IsPrime(i) == true)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else { }
            //}
        }
    }
}
