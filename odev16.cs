using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan iki sayı girmesini istiyoruz
        Console.WriteLine("İki sayı girin:");

        // Kullanıcının girişini alıp, sayıya dönüştürüyoruz
        if (int.TryParse(Console.ReadLine(), out int sayi1) && int.TryParse(Console.ReadLine(), out int sayi2))
        {
            // Kullanıcıdan TEK veya ÇİFT seçeneğini sormak için
            Console.WriteLine("TEK’leri mi ÇİFT’leri mi toplamak istersiniz? (TEK/ÇİFT)");

            // Kullanıcının girişini büyük harfe çeviriyoruz
            string tercih = Console.ReadLine().ToUpper();

            // Toplamı saklamak için bir değişken
            int toplam = 0;

            // İki sayı arasındaki TEK veya ÇİFT sayıları topluyoruz
            for (int i = sayi1; i <= sayi2; i++)
            {
                // TEK sayıları toplamak istiyorsa ve i TEK sayı ise
                // veya
                // ÇİFT sayıları toplamak istiyorsa ve i ÇİFT sayı ise
                if ((tercih == "TEK" && i % 2 == 1) || (tercih == "ÇİFT" && i % 2 == 0))
                {
                    // Toplamı güncelliyoruz
                    toplam += i;
                }
            }

            // Sonucu ekrana yazdırıyoruz
            Console.WriteLine($"Toplam: {toplam}");
        }
        else
        {
            // İki sayı geçerli bir sayı değilse kullanıcıya uyarı veriyoruz
            Console.WriteLine("Geçerli iki sayı giriniz.");
        }
    }
}