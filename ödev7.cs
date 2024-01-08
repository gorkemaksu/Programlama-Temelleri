using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] B = new int[5];
        int a = 0, say = 0, toplam = 0;

        foreach (int al in B)
        {
            Console.Write(a + ". Elemanı Gir: ");
            B[a] = Int32.Parse(Console.ReadLine());

            if (B[a] % 10 == 0)
            {
                say++;
                toplam += B[a];
            }

            a++;
        }

        Console.WriteLine("Son Rakamı Sıfır Olan Sayı Adedi: " + say);

        if (say > 0)
        {
            double ortalama = (double)toplam / say;
            Console.WriteLine("Son Rakamı Sıfır Olan Sayıların Toplamı: " + toplam);
            Console.WriteLine("Son Rakamı Sıfır Olan Sayıların Ortalaması: " + ortalama);
        }
        else
        {
            Console.WriteLine("Son rakamı sıfır olan bir sayı girilmedi.");
        }

        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}