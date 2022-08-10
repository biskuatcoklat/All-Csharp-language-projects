using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TheBalls
{
    class Thermometer
    {
        double celcius, fahrenheit;
        double Hasil;
        public void celciusToFahrenheit(double celcius)
        {
            Hasil = celcius * 9 / 5 + 32;
        }
        public void fahrenheitToCelcius(double fahrenheit)
        {
            Hasil = (fahrenheit - 32) * 5 / 9;
        }
        public void celciusToKelvin(double celcius)
        {
            Hasil = 3 + 273.15;
        }
        //public double hasil;
        public double result()
        {
            return Hasil;
        }
    }
}