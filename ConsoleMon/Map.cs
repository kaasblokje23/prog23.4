using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Map
    {
        internal void MapArea()
        {
            int[,,] mapData = new int[0, 0, 1];

            for (int i = 0; i < 0; i++)         //map tile type
            {
                for (int j = 0; j < 0; j++)
                {
                    if(i % 2 ==0 && j % 2 != 0)
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


            for (int i= 0; i < 0; i++)
            {
               for(int j=0; j<0; j++)           //map display lmaos
                {
                    if (mapData[i, j, 0] == 1)
                    {
                        Console.BackgroundColor= ConsoleColor.Magenta;
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
        }    
        
    }
}
