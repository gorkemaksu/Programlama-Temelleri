﻿using System;

class Program
{
    public static void Main(string[] args)
    {
        int i, j, gecici, EnBuyukYer;
        int[] A = { 78, 56, 23, 95, 68, 87, 61, 77, 45, 33 };

        for (i = 0; i < A.Length - 1; i++)
        {
            EnBuyukYer = i;

            for (j = i + 1; j < A.Length; j++)
            {
                if (A[j] > A[EnBuyukYer])
                {
                    EnBuyukYer = j;
                }
            }

            gecici = A[i];
            A[i] = A[EnBuyukYer];
            A[EnBuyukYer] = gecici;

            Console.WriteLine(A[i]);
        }

        Console.Write("Tuşa Bas. . . ");
        Console.ReadKey(true);
    }
}
