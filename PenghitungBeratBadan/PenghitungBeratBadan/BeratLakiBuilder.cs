using System;
using System.Collections.Generic;
using System.Text;

namespace PenghitungBeratBadan
{
    internal class BeratLakiBuilder : BeratBadan
    {
        private BeratLaki beratLaki;
        private double berat;
        private int tinggi;

        // public BeratLakiBuilder() adalah constructor
        public BeratLakiBuilder(BeratLaki beratLaki)
        {
            // (BeratLaki beratLaki) adalah teknik dependency
            // yaitu menggunakan class yang lain di dalam suatu class
            this.beratLaki = beratLaki;
        }

        public void setBeratTinggiLaki(double berat, int tinggi)
        {
            this.berat = berat;
            this.tinggi = tinggi;
            sendBeratTinggiLaki();
        }

        public void sendBeratTinggiLaki()
        {
            this.beratLaki.setBeratTinggiLaki(this.berat, this.tinggi);
        }

        public void printBeratTinggiLaki()
        {
            this.beratLaki.showBeratTinggiLaki();
        }
    }
}

