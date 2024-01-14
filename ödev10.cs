using System;

class Program
{
    public static void Main(string[] args)
    {
        byte a;
        string s = "";
        string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
        string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };

        Console.Write("Bir Sayı Giriniz (1-99): ");
        a = Byte.Parse(Console.ReadLine());

        if (a < 1 || a > 99)
        {
            Console.WriteLine("Girdiğiniz sayı 1-99 arasında olmalıdır.");
        }
        else
        {
            if (a / 10 >= 1)
            {
                s = Onlar[(a / 10) - 1];
            }

            if (a % 10 != 0)
            {
                s = s + Birler[(a % 10) - 1];
            }

            Console.WriteLine(s);
        }

        Console.Write("Tuşa Bas . . . ");
        Console.ReadKey(true);

       
    }
}
