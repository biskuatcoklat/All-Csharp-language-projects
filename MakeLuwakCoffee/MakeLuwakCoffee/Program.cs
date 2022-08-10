/*---------------------------------
 * -Demo Program Luwak White Coffe-
 *-Author : Wahyu Aprilliandhika  -
 *---------------------------------
 */



using System;

namespace MakeLuwakCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi welcome to amikom cafe");
            BijiCoffeLuwak bijicoffeluwak = new BijiCoffeLuwak(new BijiCoffeLuwakBlenderCoffee());
            bijicoffeluwak.startBlend();
            Console.WriteLine("Please wait !");
        }
    }
    class BijiCoffeLuwakBlenderCoffee : BlenderCoffee
    {
        public void onBlender(string message)
        {
            Console.WriteLine(message);
        }
        public void onPreparation()
        {
            Console.WriteLine("Prepare Coffe Luwak");
        }
        public void onReady(string message)
        {
            Console.WriteLine(message);
        }
    }



}
