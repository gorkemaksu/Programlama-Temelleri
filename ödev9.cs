using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Araç türünü girin \n otomobil \n kamyon \n iş makinası: "); // araç türü tanımlıyoruz
        string aracTuru = Console.ReadLine().ToLower(); // araç türü girilmesini istiyoruz

        Console.WriteLine("Kalma süresini saat cinsinden girin: "); // kalma süresini saat cinsinden olarak tanımlıyoruz
        int kalmaSuresi = Convert.ToInt32(Console.ReadLine()); // kalınan sürenin girilmesini istiyoruz

        double toplamUcret = OtoparkUcretHesapla(aracTuru, kalmaSuresi); // araç türüne göre ücret hesaplayan formülü tanımlıyoruz

        Console.WriteLine("Çıkış ücreti: " + toplamUcret.ToString("0.00") + " TL"); // çıkış ücretini TL cinsinden ondalıklı biçimde yazmasını istiyoruz
    }

    static double OtoparkUcretHesapla(string aracTuru, int kalmaSuresi)
    {
        double ilkIkiSaatUcret = 0;
        double sonrakiSaatBasiUcret = 0;
        double gunlukSabitUcretSaat = 0;

        if (aracTuru == "otomobil") { ilkIkiSaatUcret = 5; sonrakiSaatBasiUcret = 1; gunlukSabitUcretSaat = 10; } // otomobil ücret formülünü tanımlıyoruz
        else if (aracTuru == "kamyon") { ilkIkiSaatUcret = 8; sonrakiSaatBasiUcret = 2; gunlukSabitUcretSaat = 8; } // kamyon ücret formülünü tanımlıyoruz
        else if (aracTuru == "iş makinası") { ilkIkiSaatUcret = 12; sonrakiSaatBasiUcret = 3; gunlukSabitUcretSaat = 8; } // iş makinası ücret formülünü tanımlıyoruz
        else { Console.WriteLine("Geçersiz araç türü."); return 0; } // geçersiz araç türü girilirse ekrana "geçersiz araç türü girmesini istiyoruz"

        double toplamUcret = 0;

        if (kalmaSuresi <= 2) { toplamUcret = ilkIkiSaatUcret; }
        else if (kalmaSuresi <= 24) { toplamUcret = ilkIkiSaatUcret + (kalmaSuresi - 2) * sonrakiSaatBasiUcret; } // kaç saat kadığını bulmak için <=24 işlemini kullanıyoruz
        else { toplamUcret = ilkIkiSaatUcret + 22 * sonrakiSaatBasiUcret + Math.Ceiling((kalmaSuresi - 24) / 24.0) * gunlukSabitUcretSaat; } // kaç gün kaldığını bulmak için /24 işlemini kullanıyoruz

        return toplamUcret;
    }
}
