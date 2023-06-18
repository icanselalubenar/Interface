using Interface;

internal class Program
{
    static void Main(string[] args)
    {
        PrinterWindows printerWindows = new PrinterWindows();
        Console.WriteLine("Daftar printer yang tersedia:");
        Console.WriteLine("1. Epson");
        Console.WriteLine("2. Canon");
        Console.WriteLine("3. LaserJet");

        Console.Write("Pilih printer 1..3 : ");
        int pilihan = Convert.ToInt32(Console.ReadLine());
        printerWindows.Jenis = pilihan;

        IPrinter speak;
        IPrinter show;

        if (printerWindows.Jenis == 1)
        {
            speak = new Epson();
        } else if (printerWindows.Jenis == 2)
        {
            speak = new Canon();
        } else
        {
            speak = new LaserJet();
        }

        speak.Speak(printerWindows);
        Console.ReadKey();
    }
}