using System;

namespace TheSuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor lgMonitor = new Monitor("1200x600", true, 32);
            Printer hpPrinter = new Printer("HP", "MP102", 50);
            Vga nvdiaVga = new Vga("Nvidia", 2054, 2054);
            Ram samsungRam = new Ram("DDR4", 5000, 8000);
            Processor intelProcessor = new Processor();
            intelProcessor.setCache(254);
            intelProcessor.setCore(8);
            intelProcessor.setSeries("CORE i7 8th Gen");
            Computer computer = new
            Computer.Builder(samsungRam, nvdiaVga, intelProcessor)//parameter wajib
            .withMonitor(lgMonitor)//parameter opsional
            .withPrinter(hpPrinter)//parameter opsional
            .build();
            Console.WriteLine(computer.ToString());
        }
    }
}
