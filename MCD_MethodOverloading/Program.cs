﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine(true);
            decimal toplam = Topla(12M, 45M);
            EkrandaGoster(toplam);

            EkrandaGoster(Topla(12, 33));

        }
        static void EkrandaGoster(object o)
        {
            Console.WriteLine(o.ToString());
        }
        static int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        static decimal Topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }
        static string Topla(string metin1, string metin2)
        {
            return metin1 + " " + metin2;
        }
    }
}
