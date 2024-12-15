using System.Collections.Concurrent;
using System.Data;
using System.Linq;

namespace Lab_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------Zad_01-------------------
            double x, y;
            int sum = 0;
            Console.WriteLine("Zad_01");
            var ms1 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            for (int i = 0; i < 1000000; i++)
            {
                Random rnd = new Random();
                x = rnd.NextDouble();
                y = rnd.NextDouble();
                if (x * x + y * y < 1.0) sum++;
            }
            var ms2 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            Console.WriteLine("Calculation time: {0:0} miliseconds: ", (ms2 - ms1));
            Console.WriteLine("Approximate pi valour: " + 4.0 * sum / 1000000.0);

            //-------------------Zad_02-------------------
            Console.WriteLine("\nZad_02");
            int sum1 = 0;
            var msr1 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            Parallel.For(0, 1000000, i =>
            {
                Random rnd = new Random();
                x = rnd.NextDouble();
                y = rnd.NextDouble();
                if ((x * x + y * y) <= 1.0)
                    Interlocked.Add(ref sum1, 1);
            });
            var msr2 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            Console.WriteLine("Calculation time: {0:0} miliseconds: ", (msr2 - msr1));
            Console.WriteLine("Approximate pi valour: " + 4.0 * sum1 / 1000000.0);

            //-------------------Zad_03-------------------
            Console.WriteLine("\nZad_03");
            ConcurrentBag<int> tmp = new ConcurrentBag<int>();
            var msp1 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            Parallel.For(1, 1000000, i =>
            {
                if (i % 56789 == 0)
                    tmp.Add(i);
            });
            var msp2 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            Console.WriteLine("Calculation time: {0:0} miliseconds: ", (msp2 - msp1));
            List<int> solution = tmp.ToArray().OrderBy(i => i).ToList();
            Console.WriteLine("Numbers divisible by 56789: ");
            foreach (int element in solution)
                Console.WriteLine(element);
        }
    }
}
