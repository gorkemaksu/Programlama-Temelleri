using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen cinsiyetinizi girin (Erkek için 'E', Kadın için 'K'): ");
        char cinsiyet = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Yeni bir satıra geçmek için

        Console.WriteLine("Lütfen boyunuzu (cm cinsinden) girin: ");
        double boy = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Lütfen kilonuzu (kg cinsinden) girin: ");
        double kilo = Convert.ToDouble(Console.ReadLine());

        double idealKilo = 0;

        if (cinsiyet == 'E')
        {
            idealKilo = 50 + 2.3 * ((boy / 2.54) - 60);
        }
        else if (cinsiyet == 'K')
        {
            idealKilo = 45.5 + 2.3 * ((boy / 2.54) - 60);
        }
        else
        {
            Console.WriteLine("Geçersiz cinsiyet girişi.");
            return;
        }

        Console.WriteLine("Girilen bilgilere göre ideal kilo: " + idealKilo.ToString("F2") + " kg");

        if (kilo < idealKilo)
        {
            Console.WriteLine("Şu anda ideal kilonun altındasınız.");
        }
        else if (kilo > idealKilo)
        {
            Console.WriteLine("Şu anda ideal kilonun üstündesiniz.");
        }
        else
        {
            Console.WriteLine("Şu anda ideal kilodasınız.");
        }
    }
}