using System;

namespace TheWayang
{
    class Program
    {
        static void Main(string[] args)
        {
            Duryodana duryodana = new Duryodana();
            Dursasana dursasana = new Dursasana();
            Karna karna = new Karna();
            Bima bima = new Bima();
            duryodana.hit();
            dursasana.kick();
            karna.defend();
            bima.dead();
            
        }
    }
}
