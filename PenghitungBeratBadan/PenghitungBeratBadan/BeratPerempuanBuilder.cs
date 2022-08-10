using System;
using System.Collections.Generic;
using System.Text;

namespace PenghitungBeratBadan
{
    internal class BeratPerempuanBuilder : BeratBadan
    {
        private BeratPerempuan beratPerempuan;
        private double berat;
        private int tinggi;

        // public BeratPerempuanBuilder() adalah constructor
        public BeratPerempuanBuilder(BeratPerempuan beratPerempuan)
        {
            // (BeratLaki beratLaki) adalah teknik dependency
            // yaitu menggunakan class yang lain di dalam suatu class
            this.beratPerempuan = beratPerempuan;
        }

        public void setBeratTinggiPerempuan(double berat, int tinggi)
        {
            this.berat = berat;
            this.tinggi = tinggi;
            sendBeratTinggiPerempuan();
        }

        public void sendBeratTinggiPerempuan()
        {
            this.beratPerempuan.setBeratTinggiPerempuan(this.berat, this.tinggi);
        }

        public void printBeratTinggiPerempuan()
        {
            this.beratPerempuan.showBeratTinggiPerempuan();
        }
    }
}
