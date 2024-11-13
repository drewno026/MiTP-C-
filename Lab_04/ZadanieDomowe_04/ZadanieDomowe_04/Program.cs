namespace ZadanieDomowe_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem item1 = new MenuItem("Pizza", 25.50);
            item1.DisplayInfo();
            Console.WriteLine($"Total Order Value: {MenuItem.TotalOrder:C}");

            MenuItem item2 = new MenuItem("Beer", 7.50);
            item2.DisplayInfo();
            Console.WriteLine($"Total Order Value: {MenuItem.TotalOrder:C}");


            MenuItem item3 = new MenuItem(item2);
            item3.DisplayInfo();
            Console.WriteLine($"Total Order Value: {MenuItem.TotalOrder:C}");
        }
    }
}
