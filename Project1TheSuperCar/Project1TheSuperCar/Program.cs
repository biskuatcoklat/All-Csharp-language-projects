using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1TheSuperCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello The Super Car");

            Class1 lamborghini = new Class1();
            Console.WriteLine("current speed : " + lamborghini.speedCurrent);
            lamborghini.go();
            Console.WriteLine("current speed : " + lamborghini.speedCurrent);
            lamborghini.go();
            Console.WriteLine("current speed : " + lamborghini.speedCurrent);
            lamborghini.go();

        }
    }
}
