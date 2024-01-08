using System;

namespace or096
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] burslar = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };

            int b = 0;
            foreach (double burs in burslar)
            {
                if (burs >= 500)
                {
                    Console.WriteLine(burs);
                    continue;
                }

                burs = (burs * 0.1) + burs + 50;
                Console.WriteLine(burs);
                b++;
            }

            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}