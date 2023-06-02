using System.IO;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] content = File.ReadAllLines("leesdezefile.txt");

            foreach (string line in content)
                Console.WriteLine(line);

            string[] content2 = new string[] { "aangepast omdat cool" };
            File.WriteAllText("C:\\Users\\ginos\\OneDrive\\Documenten\\2023P4ProgCs2\\FileIOOpdracht\\bin\\Debug\\net7.0\\output\\mijnnieuwefile.txt", "hallo");

            string[] lines = {"", "New line 1", "New line 2" };
            File.AppendAllLines("C:\\Users\\ginos\\OneDrive\\Documenten\\2023P4ProgCs2\\FileIOOpdracht\\mijnnieuwefile.txt", lines);

            Directory.CreateDirectory("output"); 
        }
    }
}