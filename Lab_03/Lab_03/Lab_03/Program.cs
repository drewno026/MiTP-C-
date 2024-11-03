namespace Lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RightTriangle mytriangle1 = new RightTriangle();
            mytriangle1.A = 3;
            mytriangle1.B = 4;
            mytriangle1.TriangleColor = Color.Red;
            Console.WriteLine(mytriangle1.CircumFerence);
            Console.WriteLine(mytriangle1.TriangleColor);
        }
    }
}
