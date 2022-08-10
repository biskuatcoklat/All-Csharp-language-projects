using System;
using System.Collections.Generic;
using System.Text;

namespace MyBiodata
{
    class Mahasiswa
    {
        int Id;
        string Nama;
        int Nim;
        string Gender;
        string Prodi;


        public void biodata()
        {
            Id = 0;
            Nama = "Wahyu Aprilliandhika";
            Nim = 21113869;
            Gender = "Laki-laki";
            Prodi = "Informatika";
        }

        public void attMahasiswa(string Nama, int Nim)
        {
            Nama = Nama;
            Nim = Nim;
        }

        public void addProdi(string Prodi )
        {
            Prodi = Prodi;
        }

        public void me()
        {
            Console.WriteLine("Nama saya wahyu" + "i am a programmer");
        }
    }

}

