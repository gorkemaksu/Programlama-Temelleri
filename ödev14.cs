﻿using System;

class Program
{
    public static void Main(string[] args)
    {
        int m, t, r, enbuyuk = -1500;
        string s = "";
        int[,,] Araba = new int[3, 3, 3];
        string[] isim = { "Molo", "Metta", "Massat", "Sedan", "Station", "Hatchback", "Kırmızı", "Beyaz", "Mavi" };
        Random rastgele = new Random();

        for (m = 0; m <= 2; m++)
        {
            for (t = 0; t <= 2; t++)
            {
                for (r = 0; r <= 2; r++)
                {
                    Araba[m, t, r] = rastgele.Next(11);
                }
            }
        }

        for (m = 0; m <= 2; m++)
        {
            for (t = 0; t <= 2; t++)
            {
                for (r = 0; r <= 2; r++)
                {
                    if (Araba[m, t, r] > enbuyuk)
                    {
                        enbuyuk = Araba[m, t, r];
                        s = isim[m + 0] + " " + isim[t + 3] + " " + isim[r + 6] + " " + enbuyuk + " Adet";
                    }
                    else if (Araba[m, t, r] == enbuyuk)
                    {
                        s += ", " + isim[m + 0] + " " + isim[t + 3] + " " + isim[r + 6] + " " + enbuyuk + " Adet";
                    }
                }
            }
        }

        Console.Write("En yüksek adete sahip arabalar: ");
        Console.WriteLine(s);
        Console.Write("Tuşa Bas . . . ");
        Console.ReadKey(true);
    }
}
