using System;
namespace TheBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Thermometer thermometer = new Thermometer();
            thermometer.celciusToFahrenheit(32);
            Console.WriteLine("hasil : " + thermometer.result());
            //(32°C × 9/5) + 32 = 89.6°F
            thermometer.fahrenheitToCelcius(140);
            Console.WriteLine("hasil : " + thermometer.result());
            //(140°F − 32) × 5/9 = 60°C
            thermometer.celciusToKelvin(3);
            Console.WriteLine("hasil : " + thermometer.result());
            //3°C + 273.15 = 276.15K
        }
    }
}
