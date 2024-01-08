using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kaç adet sayı girmek istiyorsunuz?");
        int adet = Convert.ToInt32(Console.ReadLine());

        int toplam = 0;

        for (int i = 1; i <= adet; i++)
        {
            Console.WriteLine("Lütfen {0}. sayıyı girin:", i);
            int sayi = Convert.ToInt32(Console.ReadLine());
            toplam += sayi;
        }

        double ortalama = (double)toplam / adet;

        Console.WriteLine("Girdiğiniz {0} sayının toplamı: {1}", adet, toplam);
        Console.WriteLine("Girdiğiniz {0} sayının ortalaması: {1}", adet, ortalama);

        Console.ReadLine();
    }
}