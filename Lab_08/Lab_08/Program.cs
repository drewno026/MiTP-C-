using System.Linq;

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
            foreach (int number in squares) Console.WriteLine(number);
        }
    }
}
