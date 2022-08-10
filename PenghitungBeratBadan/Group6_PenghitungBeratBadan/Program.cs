using System;

namespace Group6_PenghitungBeratBadan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            while(true)
            {
                Console.WriteLine("\nSilahkan Pilih");
                Console.WriteLine("\n1. Hitung Berat Badan Laki-Laki");
                Console.WriteLine("2. Hitung Berat Badan Perempuan");
                Console.WriteLine("3. Keluar");
                Console.Write("\nMasukkan Pilihan\t: ");
                int angka = Convert.ToInt32(Console.ReadLine());

                if(angka == 1)
                {
                    beratLaki();
                }
                else if(angka == 2)
                {
                    beratPerempuan();
                }
                else if (angka==3)
                {
                    break;
                }   
            }
        }

        static void beratLaki()
        {
            
            BeratLaki beratLaki = new BeratLaki();
            // beratLaki adalah object
            BeratLakiBuilder beratLakiBuilder = new BeratLakiBuilder(beratLaki);

            Console.Write("\nBerat Badan\t: ");
            double berat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tinggi Badan\t: ");
            int tinggi = Convert.ToInt32(Console.ReadLine());

            beratLakiBuilder.setBeratTinggiLaki(berat, tinggi);
            beratLakiBuilder.printBeratTinggiLaki();
        }

        static void beratPerempuan()
        {
            
        }

    }
}
