using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello The Super car");

            Car lamborghini = new Car();
            Console.WriteLine("current speed : " + lamborghini.speedCurrent);
            lamborghini.go();
            Console.WriteLine("current speed : " + lamborghini.speedCurrent);
            lamborghini.go();
            Console.WriteLine("current speed : " + lamborghini.speedCurrent);
            lamborghini.go();
            Console.WriteLine("current speed : " + lamborghini.speedCurrent);
        }
    }
}
