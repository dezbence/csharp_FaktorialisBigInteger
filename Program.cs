﻿using System;
using System.Numerics;

namespace FaktoriálisBigInteger
{
    class Program
    {
        static void Main(string[] args)

        {

           
            Console.WriteLine("Faktroiális meghatározása 20-40 között");
            for (int szám = 0; szám <= 40; szám++)
            {
                BigInteger faktor = 1;
                for (int i = 2; i <= szám; i++)
                {
                    faktor = faktor * i;
                }
                Console.WriteLine($"{szám}!={faktor}");
            }

            Console.ReadKey();
        }
    }
}
