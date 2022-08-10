using System;


namespace Project1TheSuperCar
{
    class Class1
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


