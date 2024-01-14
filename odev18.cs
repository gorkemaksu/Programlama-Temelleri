using System;

namespace or211
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] isimler = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
            int[] notlar = { 56, 78, 95, 23, 95, 87, 61, 77, 45, 33 };

            int enYuksekNot = int.MinValue, enDusukNot = int.MaxValue;

            // En yüksek ve en düşük notu alan kişilerin indekslerini tutacak diziler
            int[] enYuksek = new int[isimler.Length];
            int[] enDusuk = new int[isimler.Length];

            for (int i = 0; i < notlar.Length; i++)
            {
                // En yüksek notu alan kişilerin indekslerini kontrol etme
                if (notlar[i] > enYuksekNot)
                {
                    enYuksekNot = notlar[i];
                    enYuksek = new int[] { i };
                }
                else if (notlar[i] == enYuksekNot)
                {
                    Array.Resize(ref enYuksek, enYuksek.Length + 1);
                    enYuksek[enYuksek.Length - 1] = i;
                }

                // En düşük notu alan kişilerin indekslerini kontrol etme
                if (notlar[i] < enDusukNot)
                {
                    enDusukNot = notlar[i];
                    enDusuk = new int[] { i };
                }
                else if (notlar[i] == enDusukNot)
                {
                    Array.Resize(ref enDusuk, enDusuk.Length + 1);
                    enDusuk[enDusuk.Length - 1] = i;
                }
            }

            // Aynı notu alan birden fazla kişiyi ekrana yazdırma
            Console.WriteLine("En Yüksek Notu Alan Kişiler: ");
            foreach (var indeks in enYuksek)
            {
                Console.WriteLine(isimler[indeks]);
            }

            Console.WriteLine("\nEn Düşük Notu Alan Kişiler: ");
            foreach (var indeks in enDusuk)
            {
                Console.WriteLine(isimler[indeks]);
            }

            Console.Write("Devam etmek için bir tuşa basınız. . . ");
            Console.ReadKey(true);
        }
    }
}