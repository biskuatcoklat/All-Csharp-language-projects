using System;
using System.Collections.Generic;
using System.Text;
namespace ResponsiPemograman
{
    class Dosen
    {

        int _id;
        string _nama;
        int _Nik;
        string _gender;
        string _course;

        public Dosen()
        {
            _id = 0;
            _nama = "Mr. Bayu Enka";
            _Nik = 999999999;
            _gender = "Laki-laki";
            _course = "Pemrograman";
        }

        // Method kedua dapat menambahkan/menginputkan nama dosen beserta dengan nik
        public void attDosen(string nama, int nik)
        {
            _nama = nama;
            _Nik = nik;
        }

        // Method ketiga berisi penambahan mata kuliah dari dosen yang diinputkan.
        public void addCourse(string course)
        {
            _course = course;
        }

        public void me()
        {
            Console.WriteLine("Nama saya Raden Kusuma Arya Dewa atau biasa dipanggil Raden oleh orang-orang disekitarnya. NIM saya 21.11.3833, saya memiliki hobi fotografi. Saat ini, saya menjadi mahasiswa di Universitas Amikom Yogyakarta Jurusan S1 Informatika. \n " +
                "Saya memiliki cita - cita menjadi seorang programmer.");
        }
    }

}