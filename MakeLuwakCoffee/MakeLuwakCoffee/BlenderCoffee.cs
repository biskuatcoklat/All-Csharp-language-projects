using System;
using System.Collections.Generic;
using System.Text;

namespace MakeLuwakCoffee
{
    interface BlenderCoffee
    {
        void onPreparation();
        void onBlender(String message);
        void onReady(String message);


    }
}
