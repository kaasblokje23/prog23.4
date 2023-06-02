using System.IO;
namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string content = File.ReadAllText("stringsplit.txt");


            string[] keyvalue = content.Split(':');

            foreach (string key in keyvalue)
            {
                Console.WriteLine(key);
            }

            string[] cijfersPerVak = keyvalue[1].Split(',');

            foreach (string cijfer in cijfersPerVak)
            {
                Console.WriteLine(cijfer);

            }
        }
    }
}