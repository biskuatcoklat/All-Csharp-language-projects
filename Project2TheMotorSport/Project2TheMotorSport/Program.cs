using System;

namespace Project2TheMotorSport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello The Motor Sport");

            MotorSport motorSport = new MotorSport();
            Console.WriteLine("current speed : " + motorSport.speedCurrent);
            motorSport.go();
            Console.WriteLine("current speed : " + motorSport.speedCurrent);
            motorSport.turnLeft();
            Console.WriteLine("current speed : " + motorSport.speedCurrent);
            motorSport.go();
            Console.WriteLine("current speed : " + motorSport.speedCurrent);
        }
    }
}
