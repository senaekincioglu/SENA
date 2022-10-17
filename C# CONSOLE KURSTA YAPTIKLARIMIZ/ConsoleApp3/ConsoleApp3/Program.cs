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
            int[] dizi = new int[20];
            Random rnd = new Random();
            double toplam = 0;
            double aritmetik = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 100);
                Console.WriteLine( ((i + 1), "sayı= " + dizi[i]));
                toplam += dizi[i];
                aritmetik = toplam / dizi.Length;
            }
            Console.WriteLine("\nToplam=  " + toplam);
            Console.WriteLine("\nAritmetik ortalama=  " + aritmetik);
            Console.WriteLine("aritmetik ortalamadan büyük olan sayılar");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]>aritmetik)
                {
                    Console.Write(dizi[i] + " ");
                }
            }
            Console.WriteLine("Aritmetik ortalamadan küçük olan sayılar: ");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < aritmetik)
                {
                    Console.Write(dizi[i] + " ");
                }
            }Console.ReadLine();
        }
    }
}
