using System;
using System.Collections.Generic;
using System.Text;

namespace TheAeroPlane_
{
    class Logger
    {
        public void info(string message)
        {
            Console.WriteLine("info : " + message);
        }
        public void warning(string message)
        {
            Console.WriteLine("warning : " + message);
        }
        public void error(string message)
        {
            Console.WriteLine("error : " + message);
        }
    }
}
