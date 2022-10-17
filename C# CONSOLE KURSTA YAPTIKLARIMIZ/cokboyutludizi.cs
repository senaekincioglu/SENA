using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBoyutluDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Çok boyutlu dizi tanımlama
            //string[,] dizi = { { "Mehmet", "salih" }, { "Sena", "esma" } };// bi böyle
            //int[,] dizi2 = new int[2, 3];// bi de böyle tanımlanabilir.
            //dizi2[0, 0] = 121 ;//içine böyle atanabilir.
            //dizi2[0, 1] = 147;
            //dizi2[1, 0] = 2;
            //dizi2[1, 1] = 1;
            ////Console.WriteLine(dizi2[0, 1]);
            ////Console.ReadLine();
            ////komple yazdırmak 
            //for (int i = 0; i < 2; i++)//satır için
            //{
            //    for (int j = 0; j < 3; j++)//sütun için
            //    {
            //        Console.WriteLine(dizi2[i,j]);//tüm satır ve sütunları yazdırdı
            //        Console.Write(" ");
            //    }
            //}
            //Console.ReadLine();


            //iki farklı dizi tanımla iki boyutlu

            /*int[,] diziler = new int[3, 5];*///3 satır 5 sütun
                                               //diziler[0, 0] = 14;
                                               //diziler[0, 1] = 17;
                                               //diziler[0, 2] = 18;
                                               //diziler[0,3]= 19;
                                               //diziler[0, 4] = 12;

            //diziler[1, 0] = 17;
            //diziler[1, 1] = 11;
            //diziler[1, 2] = 13;
            //diziler[1, 3] = 19;
            //diziler[1, 4] = 15;

            //diziler[2, 0] = 15;
            //diziler[2, 1] = 15;
            //diziler[2, 2] = 15;
            //diziler[2, 3] = 15;
            //diziler[2, 4] = 15;

            //diziler[3, 0] = 15;
            //diziler[3, 1] = 15;
            //diziler[3, 2] = 15;
            //diziler[3, 3] = 15;
            //diziler[3, 4] = 15;

            //int[,] dizi2 = { { 14, 17, 18, 19, 12 }, { 13, 17, 11, 13, 19 }, { 15, 18, 10, 14, 20 } };//bunlar satır oluyor. tüm rakamları yazdır.
            //for (int i = 0; i < 3; i++)//satır için
            //{
            //    for (int j = 0; j < 5; j++)//sütun için
            //    {
            //        Console.Write(dizi2[i, j]);//tüm satır ve sütunları yazdırdı. 1 den başladıığı için -1
            //        Console.Write(" ");
            //    }

            //    Console.WriteLine(" ");


            //3 e 5 dizi tanımla.
            //int[,] dizi2 = { { 14, 17, 18, 19, 12 }, { 13, 17, 11, 13, 19 }, { 15, 18, 10, 14, 20 } };
            //int[,] dizi1 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            //int[,] dizi3 = new int[3, 5];//matrislerde toplama yaparke satır sütun eşit olmalı.

            //for (int i = 0; i < 3; i++)//satır
            //{
            //    for (int j = 0; j < 5; j++)//sütun
            //zaten satır ve sütunlar eşit olucağı için
            //    {
            //        Console.Write(dizi1[i, j] + dizi2[i, j]);//dizi 1 deki satır ve sütunları, dizi2 deki satır ve sütunları yazdırdı.
            //        Console.Write(" ");

            //    }
            //    Console.WriteLine(" ");
            //}

            //Console.ReadLine();

            //Dışardan değer alarak toplamı yap.


            Console.Write("Satır sayısı girin= ");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısı girin= ");
            int sutun = Convert.ToInt32(Console.ReadLine());
            int[,] dizi = new int[satir, sutun];//dizi tanımla
            for (int i = 0; i < satir; i++)//satır sütun değeri bellekte tutar
            {
                for (int j = 0; j <sutun; j++)
                {
                    Console.WriteLine("satir {0}x{1} sütun", i+1 , j+1);
                    dizi[i, j] = Convert.ToInt32(Console.ReadLine());

                }
                
            }
            
            for (int k = 0; k < satir; k++)//bellekte bulunan değerleri ekrana yazdırıyor.
            {
                for (int n = 0; n < sutun; n++)
                {
                    Console.Write(dizi[k, n] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
            






            }
        }

    

