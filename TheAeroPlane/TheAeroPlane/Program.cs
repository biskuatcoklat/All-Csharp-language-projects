using System;

namespace TheAeroPlane_
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            Plane plane = new Plane(logger);
            plane.startEngine();
            plane.takeOff();
            plane.turbulance();
        }
    }
}
