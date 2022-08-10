using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MakeLuwakCoffee
{
    class BijiCoffeLuwak
    {
        private BlenderCoffee coffee;
        public BijiCoffeLuwak(BlenderCoffee coffee)
        {
            this.coffee = coffee;
        }
        public void startBlend()
        {
            this.coffee.onPreparation();
            ThreadStart makeluwakcoffe = new ThreadStart(BlenderPProcess);
            Thread childThread = new Thread(makeluwakcoffe);
            childThread.Start();
        }
        private void BlenderPProcess()
        {
            for (int counter=5; counter>=0; counter--)
            {
                Thread.Sleep(1000);
                this.coffee.onBlender("Blending. Tunggu..." + counter + "second.");
            }
            this.coffee.onReady("Selesai. CoffeLuwak");
        }
    }
}
