using DesafioPOO.Models;
class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("13 99999-9999", "G60 5G", "111111111111111", 64);
        Smartphone iphone = new Iphone("11 97777-7777", "15 Pro", "222222222222222", 128);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}