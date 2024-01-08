using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Dizi Boyutunu Giriniz: ");
        int n = Int32.Parse(Console.ReadLine());

        int[] B = new int[n];

        Console.WriteLine("Dizi Elemanlarını Giriniz:");

        for (int i = 0; i < n; i++) 
        {
            Console.Write("B[" + i + "]: ");
            B[i] = Int32.Parse(Console.ReadLine());
        }

        int e = 1;

        for (int a = 2; a < B.Length; a++)
        {
            if (Math.Abs(B[0] - B[a]) < Math.Abs(B[0] - B[e]))
            {
                e = a;
            }
        }

        Console.WriteLine("İlk Sayıya En Yakın Sayı = " + B[e]);
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
