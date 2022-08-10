using System;

namespace TheRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the restaurant!");
            Egg egg = new Egg(new EggCookingListener());
            egg.startCooking();
            Console.WriteLine("Please wait. Enjoy your table");
        }
    }
    class Program
    {
        class Program
        {
            static void Main(string[] args)
            {
                //....
            }
        }
        class EggCookingListener : CookListener
        {
            public void onCooking(string message)
            {
                Console.WriteLine(message);
            }
            public void onPreparation()
            {
                Console.WriteLine("prepared...");
            }

            public void onReady(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
