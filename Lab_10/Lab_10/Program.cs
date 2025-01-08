using B10;
using System.Globalization;

namespace Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------Zad_01----------------------------
            Random rnd = new Random();
            var ms1 = (DateTime.UtcNow - DateTime.MinValue).TotalMicroseconds;

            List<int> list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {

                list.Add(rnd.Next(0, 99999));
            }
            
            for (int i = 0; i <= 99999; i++)
            {
                list.Find(x => x == 1);
            }

            var ms2 = (DateTime.UtcNow - DateTime.MinValue).TotalMicroseconds;
            double calcTimeForList = ms2 - ms1;
            Console.WriteLine("Calculation time: {0:0} milliseconds", calcTimeForList);
            //----------------------------Zad_02----------------------------
            var m1 = (DateTime.UtcNow - DateTime.MinValue).TotalMicroseconds;
            Tree tree_02 = new Tree();

            for (int i = 0; i < 1000; i++)
            {
                tree_02.Add(rnd.Next(0, 99999));
            }

            for (int i = 0; i <= 99999; i++)
            {
                bool exists = tree_02.Search(i);
            }

            var m2 = (DateTime.UtcNow - DateTime.MinValue).TotalMicroseconds;
            double calcTimeForTree = m2 - m1;
            Console.WriteLine("Calculation time: {0:0} milliseconds", calcTimeForTree);
            Console.WriteLine("\nDiffrence(calculation time for list minus tree): {0:0} miliseconds longer ", (calcTimeForList - calcTimeForTree));

        }
    }
}
