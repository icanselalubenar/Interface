using System;
namespace Interface
{
    public class Epson : IPrinter
    {
        public void Speak(PrinterWindows printerWindows)
        {
            Console.WriteLine("Epson printer printing...");
            Console.WriteLine("Printer windows display dimension : 10*11");
        }
    }
}

