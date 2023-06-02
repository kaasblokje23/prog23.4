using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Arena
    {
        internal void Fight(ConsoleMon fighterA, ConsoleMon fighterB)
        {
            fighterA.skills[0].UseOn(fighterB, fighterA);
            Thread.Sleep(1000);
            Console.WriteLine($"{fighterA.name} valt {fighterB.name} aan!");
            Thread.Sleep(1000);
            // Vechter 2 valt vechter 1 aan
            fighterB.skills[0].UseOn(fighterA, fighterA);
            Console.WriteLine($"{fighterB.name} valt {fighterA.name} aan !");
            Thread.Sleep(1000);
            // Console-uitvoer van het resultaat van de aanvallen
            Console.WriteLine($"{fighterA.name} heeft nu {fighterA.health} HP.");
            Thread.Sleep(1000);
            Console.WriteLine($"{fighterB.name} heeft nu {fighterB.health} HP.");
        }
    }
}
