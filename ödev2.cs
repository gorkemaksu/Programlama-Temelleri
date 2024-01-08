using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir ikili sayı girin: ");
        string ikiliSayiString = Console.ReadLine();

        if (!IsBinary(ikiliSayiString))
        {
            Console.WriteLine("Geçersiz giriş! Lütfen ikili bir sayı girin.");
            return;
        }

        int sayi = Convert.ToInt32(ikiliSayiString);
        int onluDeger = 0, tabanDeger = 1, basamakDeger;

        while (sayi > 0)
        {
            basamakDeger = sayi % 10;
            onluDeger = onluDeger + basamakDeger * tabanDeger;
            sayi = sayi / 10;
            tabanDeger = tabanDeger * 2;
        }

        Console.WriteLine("Girilen İkili (Binary) Sayı: " + ikiliSayiString);
        Console.WriteLine("Onlu (Decimal) Sayı: " + onluDeger);
        Console.ReadLine();
    }

    static bool IsBinary(string input)
    {
        foreach (char digit in input)
        {
            if (digit != '0' && digit != '1')
            {
                return false;
            }
        }
        return true;
    }
}
