using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatchhh
{
    internal class Program
    {
        public void Topla()
        {
            Console.Write("1. Sayıyı girin= ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı girin= ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int[,] dizi = new int[sayi1, sayi2];//dizi tanımla
            for (int i = 0; i < sayi1; i++)//satır sütun değeri bellekte tutar
            {
                for (int j = 0; j < sayi2; j++)
                {
                    try
                    {
                        Console.WriteLine("satir {0}x{1} sütun", i + 1, j + 1);
                        dizi[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Hatalı giriş");
                    }
                    

                }

            }

            for (int k = 0; k < sayi1; k++)//bellekte bulunan değerleri ekrana yazdırıyor.
            {
                for (int n = 0; n < sayi2; n++)
                {
                    Console.Write(dizi[k, n] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }


    
    static void Main(string[] args)
        {
            //klavyeden iki değer al c dizi tanımla
            //a ve b yi c ye ata try catch ile yap
            Program prg = new Program();
            prg.Topla();
            Console.ReadLine();

        }
    }
}
