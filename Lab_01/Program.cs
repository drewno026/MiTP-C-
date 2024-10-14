namespace Lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;

            for (number1 = 0; number1 < 101; number1++)
            {
                if (number1 % 7 == 0){}
                else {
                    Console.WriteLine(number1);
                }
            }          
        }
    }
}
