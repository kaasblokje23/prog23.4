using System;

namespace ja
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,,] mapData = new int[0, 0, 1];

            for (int i = 0; i < 0; i++)         //map tile type
            {
                for (int j = 0; j < 0; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        mapData[i, j, 0] = 1;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        mapData[i, j, 0] = 1;
                    }
                    else
                    {
                        mapData[i, j, 0] = 2;
                    }
                }
            }


            for (int i = 0; i < 0; i++)
            {
                for (int j = 0; j < 0; j++)           //map display lmaos
                {
                    if (mapData[i, j, 0] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Write("   ");
                    }
                    if (mapData[i, j, 0] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("   ");
                    }
                    Console.Write("\n");
                }
            } //map display lmaos
            Console.ReadLine();
















            string text = "Lisa heeft psychologische hulp nodig waarbij ze het uit moet maken met Peter om soep te gaan eten waarbij ze water groen gaat eten geel zwart maakt en gras kaas is";

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Lisa get help");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();
            Console.ResetColor();

            foreach (char words in text)
            {
                Console.Write(words);
                Thread.Sleep(100);
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ReadLine();
            Console.ResetColor();
        }


        internal void Soup ()
        {
        }
    }
}