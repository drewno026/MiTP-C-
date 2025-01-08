using B10;

namespace ZadanieDomowe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = Tree.ZadanieDomowe();
            tree.Print();

            Console.WriteLine($"Min value: {tree.MinValue()}");
            Console.WriteLine($"Max value: {tree.MaxValue()}");
            Console.WriteLine($"Sum od all values: {tree.SumValues()}");
            Console.WriteLine($"Number of all nodes: {tree.CountAllNodes()}");
            Console.WriteLine($"Number of all links: {tree.CountAllLinks()}");
        }
    }
}
