using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sayı girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = sayi; i >= 1; i--)

            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
            }

            Console.Write("sayı gir");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int a = 1; a <= sayi; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    Console.Write(a);
                }
            }
            Console.ReadLine();


        }
    }
}
