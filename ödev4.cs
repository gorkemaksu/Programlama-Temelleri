using System;

namespace or094
{
    class Program
    {
        public static void Main(string[] args)
        {
            int b;

            Console.WriteLine("Lütfen bir sayı girin:");
            bool isValidInput = int.TryParse(Console.ReadLine(), out b);

            if (!isValidInput)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
                return;
            }

            String s = "b Sayısı Asal Sayı";

            if (b == 1)
            {
                Console.WriteLine("ASAL DEĞİL!");
                goto bitir;
            }

            for (int a = 2; a <= b / 2; a++)
            {
                if (b % a == 0)
                {
                    s = "b Sayısı Asal Sayı Değil!";
                    break;
                }
            }

            Console.WriteLine(s);

        bitir:
            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }