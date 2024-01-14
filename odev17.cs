using System;

namespace eksiködevimmm
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz (1-999): ");
            int sayi;

            if (sayi < 1 && sayi > 999)
            {
                if (sayi >= 1 && sayi <= 999)
                {
                    string s = " ";
                    string[] birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
                    string[] onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
                    string[] yuzler = { "Yüz", "İkiYüz", "ÜçYüz", "DörtYüz", "BeşYüz", "AltıYüz", "YediYüz", "SekizYüz", "DokuzYüz" };

                    int birlerBasamagi = sayi % 10;
                    int onlarBasamagi = (sayi / 10) % 10;
                    int yuzlerBasamagi = (sayi / 100) % 10;

                    if (yuzlerBasamagi > 0)
                    {
                        s += yuzler[yuzlerBasamagi - 1];

                        if (onlarBasamagi > 0 || birlerBasamagi > 0)
                            s += " ";
                    }

                    if (onlarBasamagi > 0)
                    {
                        s += onlar[onlarBasamagi - 1];

                        if (birlerBasamagi > 0)
                            s += " ";
                    }

                    if (birlerBasamagi > 0)
                    {
                        s += birler[birlerBasamagi - 1];
                    }

                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("Uygun değer girmediniz. Lütfen 1-999 arasında bir sayı giriniz.");
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı giriniz.");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}