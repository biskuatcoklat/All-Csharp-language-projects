using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Car
    {
        String color = "red";
        int transmissionState = 0;
        Double speedMax = 250;
        public Double speedCurrent = 0;

        public void go()
        {
            speedCurrent += 10;
        }
    }
}
