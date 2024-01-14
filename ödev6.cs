using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 11;
            Console.WriteLine("değer giriniz ");
            int b = Convert.ToInt32(Console.ReadLine());
            String s = "b Sayısı Asal Sayı";
            if (b == 1) { Console.WriteLine("ASAL DEĞİL!"); goto bitir; }
            for (a = 2; a <= b / 2; a++)
            {
                if (b % a == 0)
                {
                    s = "b Sayısı Asal Sayı Değil!";
                    break;
                }
            }
            Console.WriteLine(s);
        bitir: Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}
