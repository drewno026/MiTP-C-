using System.Linq;
using System.Runtime.InteropServices.Marshalling;

namespace Lab_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------Zad_01----------------------------
            List<int> numbers = new List<int>();  
            for (int i = -20; i <= 20; i++)
            {
                numbers.Add(i);
            }
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            ////}
            //List<int> answer = numbers.FindAll(x => x * x * x + x * x - 44 * x + 96 == 0);
            //foreach(int number in answer) Console.WriteLine(number);
            //----------------------------Zad_02----------------------------
            List<int> squares = numbers.Select(x => x *(x+1)).ToList();
            squares = squares.Distinct().ToList();
            squares = squares.OrderBy(x => x).ToList();
            squares = squares.Select(x => x * (x - 1)).ToList();
            //foreach (int number in squares) Console.WriteLine(number);
            //----------------------------Zad_03----------------------------
            Console.WriteLine("What is the average of these numbers?");
            Console.WriteLine(Math.Round(squares.Average(), 1));
            Console.WriteLine();

            if (squares.All(number => number % 2 == 0))
                Console.WriteLine("All numbers are even.");
            else
                Console.WriteLine("Not all numbers are even.");
            Console.WriteLine();

            Console.WriteLine("Is there a number divisible by 7?");
            if (squares.Any(number => number % 7 == 0))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
          
            Console.WriteLine("\nHow many numbers are divisible by seven: "+ squares.Count(number => number % 7 == 0));

            Console.WriteLine("\nLast number divisible by seven: " + squares.Last(number => number % 7 == 0));
            //----------------------------Zad_04----------------------------
            List<int> numbers2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double geomAvg = numbers2.Aggregate(1.0, (agg, x) => agg * x, ans => Math.Pow(ans, 1.0 / numbers2.Count));
            Console.WriteLine($"\n{geomAvg:F2}\n");
            //----------------------------Zad_05----------------------------
            //List<int> nums = new List<int>() { 1, 2, 3, 5, 8, 13, 21 };
            //List<string> strings = new List<string>() { "a", "b", "c" };
            //List<string> result = nums.Zip(strings, (num, str) => (num.ToString() + "," + str)).ToList();
            //foreach (string str in result) Console.WriteLine(str);
            IEnumerable<string> result = squares.Zip(squares.Select(x => x % 9), (num, mod) => $"{num,6}  {mod,2}");
            foreach (string item in result) Console.WriteLine(item);
        }
    }
}
