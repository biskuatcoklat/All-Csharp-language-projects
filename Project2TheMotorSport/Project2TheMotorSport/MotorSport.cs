using System;
using System.Collections.Generic;
using System.Text;

namespace Project2TheMotorSport
{
    class MotorSport
    {
        String color = "red";
        int transmissionState = 0;
        Double speedMax = 250;
        public Double speedCurrent = 0;
        
         public void go() 
        {
            speedCurrent += 10;
        }

        public void turnLeft()
        {
            speedCurrent -= 2;
        }
    }
}
