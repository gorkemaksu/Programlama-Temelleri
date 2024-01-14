using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bir sayı girmesini istiyoruz
        Console.WriteLine("Bir sayı girin:");

        // Kullanıcının girişini alıp, sayıya dönüştürüyoruz
        if (int.TryParse(Console.ReadLine(), out int sayi))
        {
            // Kullanıcıdan TEK veya ÇİFT seçeneğini sormak için
            Console.WriteLine("TEK’leri mi ÇİFT’leri mi toplamak istersiniz? (TEK/ÇİFT)");

            // Kullanıcının girişini büyük harfe çeviriyoruz
            string tercih = Console.ReadLine().ToUpper();

            // Toplamı saklamak için bir değişken
            int toplam = 0;

            // Kullanıcının tercihine göre TEK veya ÇİFT sayıları topluyoruz
            for (int i = 1; i <= sayi; i++)
            {
                // TEK sayıları toplamak istiyorsa ve i TEK sayı ise veya ÇİFT sayıları toplamak istiyorsa ve i ÇİFT sayı ise
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
            // Eğer geçerli bir sayı girişi yapılmazsa kullanıcıya uyarı veriyoruz
            Console.WriteLine("Geçerli bir sayı giriniz.");
        }
    }
