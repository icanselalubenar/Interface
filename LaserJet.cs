using System;
namespace Interface
{
    public class LaserJet : IPrinter
    {
        public void Speak(PrinterWindows printerWindows)
        {
            Console.WriteLine("LaserJet printer printing...");
            Console.WriteLine("Printer windows display dimension : 10*11");
        }
    }
}

