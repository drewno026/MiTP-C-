using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ZadanieDomowe_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> result = new ConcurrentBag<int>();
            var ms1 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;

            Parallel.For(1, 1_000_000, x =>
            {
                if ((x + Factorial(x % 5) + Factorial(x % 7)) % 96800 == 0)
                    result.Add(x);
            });

            var ms2 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            Console.WriteLine("Calculation time: {0:0} milliseconds", (ms2 - ms1));

            List<int> solution = result.ToArray().OrderBy(i => i).ToList();
            foreach (int element in solution)
                Console.WriteLine(element);
        }

        static long Factorial(int n)
        {
            if (n <= 1) return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
