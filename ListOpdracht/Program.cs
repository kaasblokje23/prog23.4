using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> birds = new List<string>() {"uil", "kraai", "hond", "papegaai"};
           List<string> birds2 = new List<string>() {"meeuw", "duif"};

            Console.WriteLine("Hello, World!");

            birds.AddRange(birds2);
            birds.Remove("hond");

            for(var i = 0;i < birds.Count; i++)
            {
                
                Console.WriteLine(birds[i]);
            }      
        }
    }
}