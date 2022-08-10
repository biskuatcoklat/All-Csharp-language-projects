using System;

namespace MyBiodata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mahasiswa = new Mahasiswa();

            mahasiswa.attMahasiswa("Wahyu Aprilliandhika", 21113869);
            mahasiswa.addProdi("Informatika");
            mahasiswa.me();
           
        }
    }
}
