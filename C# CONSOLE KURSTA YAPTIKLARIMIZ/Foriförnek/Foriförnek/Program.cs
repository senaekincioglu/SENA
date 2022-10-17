using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foriförnek
{
    internal class Program
    {
        private void Carp(int a, int b)
        {

            //çarpım tablosunda çift sayıları ayrı, tek sayıları ayrı topla.

            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}*{1}={2}   ", i, j, i * j);
                    
                    Console.Write(toplam);
                }
                Console.WriteLine();

                for (int k = 1; k < 99; k++)
                {
                    if(i%2==0)
                    {
                        toplam += i;
                    }
                }

            }
        }

            static void Main(string[] args)
        {
            //metot kullan girilen iki sayının birincisini ikincisine kadar çarp. mesela 5 i 6 ya kadar çarp. 5*1,5*2...5*6
            Program prg = new Program();
            prg.Carp(5,6);
            Console.ReadLine();
        }
    }
}
