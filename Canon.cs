using System;
namespace Interface
{
    public class Canon : IPrinter
    {
        public void Speak(PrinterWindows printerWindows)
        {
            Console.WriteLine("Canon printer printing...");
            Console.WriteLine("Printer windows display dimension : 10*11");
        }
    }
}

