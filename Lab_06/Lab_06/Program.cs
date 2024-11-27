namespace Lab_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------Zad_01-------------------
            Console.WriteLine("Zad_01");
            string[] array = new string[5] { "A0", "A1", "A2", "A3", "A4" };
            Console.WriteLine("Petla for:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Petla foreach:");
            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
            //-------------------Zad_02-------------------
            Console.WriteLine("\nZad_02");
            List<string> list = new List<string>()
            {
                "L0",
                "L1",
                "L2",
                "L3",
                "L4",
                "L5"
            };
            Console.WriteLine("Petla for:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("\nPetla foreach:");
            foreach(string element in list)
            {
                Console.WriteLine($"{element}");
            }
            Console.WriteLine();
            Console.WriteLine("Number of elements before modifications: " + list.Count);
            
            list.Add("L7");
            list.Insert(6, "L6");
            foreach (string element in list)
            {
                Console.WriteLine($"{element}");
            }
            Console.WriteLine("Number of elements after adding L7 and L6: " + list.Count + "\n");

            list.Remove("L4");
            Console.WriteLine("List after removing L4");
            foreach (string element in list)
            {
                Console.WriteLine($"{element}");
            }
            Console.WriteLine();

            list.RemoveAt(1);
            Console.WriteLine("List after removing element 1");
            foreach (string element in list)
            {
                Console.WriteLine($"{element}");
            }
            Console.WriteLine("Does element L5 exist in list?");
            if (list.IndexOf("L5") == 3)
                Console.WriteLine("Element exist");
            Console.WriteLine("Does element L1 exist in list?");
            if (list.IndexOf("L1") == -1)
                Console.WriteLine("Element doesn't exist");
            Console.WriteLine("List:");
            foreach (string element in list) { Console.WriteLine(element); }
            //-------------------Zad_03-------------------
            Console.WriteLine("\nZad 3");

            Dictionary<string, int> myDict = new Dictionary<string, int>()
            {
                { "Nowak", 4381},
                { "Robinson", 2922}
            };
            Console.WriteLine(myDict["Robinson"]);

            foreach (KeyValuePair<string, int> kvp in myDict)
            {
                Console.WriteLine("Index: {0}\tValue:{1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine();

            myDict.Add("Ptak", 2056);
            myDict.Add("Pawel", 2137);
            foreach (KeyValuePair<string, int> kvp in myDict)
            {
                Console.WriteLine("Index: {0}\tValue:{1}", kvp.Key, kvp.Value);
            }

            myDict.Remove("Ptak");
            Console.WriteLine("\nDoes element Ptak exist in dictionary?");
            if (myDict.ContainsKey("Ptak"))
                Console.WriteLine("WTF");
            else
                Console.WriteLine("The element doesnt exist");
            Console.WriteLine("myDict:");
            foreach (KeyValuePair<string, int> kvp in myDict) 
            { 
                Console.WriteLine("Index: {0}\tValue: {1}", kvp.Key, kvp.Value); 
            }
        }
    }
}
