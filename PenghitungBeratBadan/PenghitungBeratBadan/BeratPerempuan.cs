using System;
using System.Collections.Generic;
using System.Text;

namespace PenghitungBeratBadan
{
    internal class BeratPerempuan
    {
        private double berat;
        private int tinggi;
        private double ideal;

        /*
         *  Encapsulaption Menyembunyikan 
         *  Data Yang Penting atau Kompleks 
         *  Menggunakan method
         *  Setter and Getter
         */

        public void setBeratTinggiPerempuan(double berat, int tinggi)
        {
            this.berat = berat;
            this.tinggi = tinggi;
            process();
        }

        public void process()
        {
            this.ideal = ((this.tinggi - 100) - (((this.tinggi - 100) * 10) / 100));
        }

        public double getBeratTinggiPerempuan()
        {
            return this.berat;
        }
        public void showBeratTinggiPerempuan()
        {
            if (this.berat > (this.ideal - 3) && this.berat < (this.ideal + 3))
            {
                Console.WriteLine("\nBerat Badan Perempuan\t: ", this.getBeratTinggiPerempuan(), " Kg");
                Console.WriteLine("Berat Badan Anda Adalah Ideal");
            }
            else if (this.berat < (this.ideal - 3))
            {
                Console.WriteLine("\nBerat Badan Perempuan\t: ", this.getBeratTinggiPerempuan(), " Kg");
                Console.WriteLine("Berat Badan Anda Adalah Kurang Ideal");
            }
            else if (this.berat > (this.berat + 3))
            {
                Console.WriteLine("\nBerat Badan Perempua\t: ", this.getBeratTinggiPerempuan(), " Kg");
                Console.WriteLine("Berat Badan Anda Adalah Berlebihan");
            }
        }
    }

}