using B7;
using System.Text.Json;

namespace Lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleClass example1 = new ExampleClass();
            JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };
            string exaple1AsJson = JsonSerializer.Serialize(example1, options);
            //Console.WriteLine(exaple1AsJson);
            string fileName = @"C:\Users\student\Desktop\Nowy folder\example1.json";
            //try
            //{
            //    File.WriteAllText(fileName, exaple1AsJson);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            try
            {
                string jsonFromFile = File.ReadAllText(fileName);
                ExampleClass objectFromJson = JsonSerializer.Deserialize<ExampleClass>(jsonFromFile);
                objectFromJson.ShowElements();
                //Console.WriteLine("\n" + jsonFromFile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
