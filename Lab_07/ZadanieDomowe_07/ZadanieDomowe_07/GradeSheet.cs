using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ZadanieDomowe_07
{
    internal class GradeSheet
    {
        public enum StudentGroup
        {
            Group_01,
            Group_02,
            Group_03,
            Group_04
        }
        public string StudentName { get; set; }
        public StudentGroup Group { get; set; }
        public Dictionary<string, double> Grades { get; set; }

        public GradeSheet(string  studentName, StudentGroup group)
        {
            StudentName = studentName;
            Group = group;
            Grades = new Dictionary<string, double>();
        }
        public double AverageGrade()
        {
            if (Grades.Count == 0)
            {
                Console.WriteLine("Brak ocen");
                return 0.0;
            }
            else
                return Grades.Values.Average();
        }
        public void Serialize(string file)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(this, options);
                File.WriteAllText(file, jsonString);
                Console.WriteLine($"Dane zapisane do pliku o nazwie: {file}, \nsciezka do pliku {Path.GetFullPath(file)} \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas zapisywania do pliku: {ex.Message}");
            }
        }
        public static GradeSheet Deserialize(string file)
        {
            try
            {
                if (!File.Exists(file))
                {
                    Console.WriteLine($"Plik o tej nazwie '{file}' nie istnieje.");
                    return null;
                }
                string jsonString = File.ReadAllText(file);
                GradeSheet gradeSheet = JsonSerializer.Deserialize<GradeSheet>(jsonString);
                Console.WriteLine("Dane zostały wczytane z pliku.");
                return gradeSheet;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas wczytywania z pliku: {ex.Message}");
                return null;
            }
        }
        public void PrintInfromations(string file = null)
        {
            Console.WriteLine($"Student: {StudentName}");
            Console.WriteLine($"Grupa: {Group}");
            Console.WriteLine("Oceny:");
            foreach (KeyValuePair<string, double> grade in Grades)
            {
                Console.WriteLine($"{grade.Key}: {grade.Value}");
            }
            Console.WriteLine($"Średnia ocen: {AverageGrade():F2}");
            if (!string.IsNullOrEmpty(file))
            {
                Console.WriteLine($"Ścieżka pliku: {Path.GetFullPath(file)}");
            }
        }
    }
}
