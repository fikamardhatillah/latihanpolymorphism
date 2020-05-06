using System;

namespace LatihanPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;
            Console.WriteLine("Pilih Printer :");
            Console.WriteLine("1. Canon");
            Console.WriteLine("2. Epson");
            Console.WriteLine("3. LaserJet\n");
        
            Console.Write("Nomor Printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Canon();
            else if (nomorPrinter == 2)
                printer = new Epson();
            else 
                printer = new LaserJet();

            printer.ShowPrint();

            Console.ReadKey();
        }
    }
}
