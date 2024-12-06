using System;
using System.Collections.Generic;

namespace B7
{
    class ExampleClass
    {
        public int MyNumber { get; set; }
        public string MyString { get; set; }
        public List<string> MyList { get; set; }
        public ExampleClass()
        {
            MyNumber = 2;
            MyString = "abc";
            MyList = new List<string>() { "sinus", "cosinus", "tangens", "cotangens" };
        }
        public void ShowElements()
        {
            // przy okazji, jesli jeszcze nie znaja Panstwo ponizszego zapisu dla stringow
            // ogolna zasada: $"tekst + {nazwaZmiennej}"
            Console.WriteLine($"The current number is {MyNumber} and the current string is {MyString}");
            Console.WriteLine("Here are the elements of the list:");
            foreach (string s in MyList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

        }

    }
}
