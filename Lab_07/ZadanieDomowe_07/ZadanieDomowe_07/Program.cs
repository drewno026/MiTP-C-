namespace ZadanieDomowe_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeSheet gradeSheet = new GradeSheet("Jan Kowalski", GradeSheet.StudentGroup.Group_01);

            gradeSheet.Grades.Add("Matematyka", 4.5);
            gradeSheet.Grades.Add("Religia", 5.0);
            gradeSheet.Grades.Add("Fizyka", 3.5);

            string file = "grades.json";
            gradeSheet.Serialize(file);
            Console.WriteLine("Informacje zapisywane do pliku:");
            gradeSheet.PrintInfromations(file);

            GradeSheet deserializedGradeSheet = GradeSheet.Deserialize(file);

            if (deserializedGradeSheet != null)
            {
                Console.WriteLine("\nInformacje z pliku:");
                deserializedGradeSheet.PrintInfromations(file);
            }
            else
            {
                Console.WriteLine("Nie udało się wczytać danych z pliku.");
            }
        }
    }
}
