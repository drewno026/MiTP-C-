namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zad_06------------------------------------------------
            //for (int number1 = 0; number1 <= 10; number1++)
            //{

            //    for (int number2 = 0; number2 <= 10; number2++)
            //    {
            //        Console.WriteLine(number1 + "*" + number2 + " = " + (number2 * number1));
            //    }
            //}
            //Zad_07------------------------------------------------
            //for (int number1 = 0; number1 <= 100; number1++) {
            //    if (number1 % 7 == 0){
            //    }
            //    else
            //    {
            //        Console.WriteLine(number1);
            //    }
            //}
            //Zad_08------------------------------------------------

            for (int number1 = 0; number1 <= 100; number1++) {
                if (number1 % 7 == 0)
                {
                    continue;
                }else {
                    Console.WriteLine(number1);
                }
            }
        }
    }
}
