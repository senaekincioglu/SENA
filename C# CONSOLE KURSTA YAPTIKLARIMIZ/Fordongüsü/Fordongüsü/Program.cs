using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordongüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 DEN 50 YE KADAR OLAN SAYILARIN TOPLAMI FOR İLE 
            //int toplam=0;
            //for(int i=1;i<=50;i++)
            //{
            //    toplam = toplam + i;                              
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            #region
            //1 DEN 50 YE KADAR OLAN TEK SAYILARIN TOPLAMI

            //int toplam = 0;
            //for (int i = 1; i <= 50; i+=2)
            //{

            //    toplam = toplam + i;//toplam+=i dir.

            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();
            #endregion
            #region
            //77 ye kadar olan 9 a tam bölünen sayılar
            //for(int i =0;i<77;i++)
            //{
            //    if(i%9==0)
            //    {

            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();
            #endregion


            #region
            ////fibonacci
            //int a=1, b=1, c;
            //for(int i = 1; i <10; i++)
            //{
            //    c =a + b;
            //    a = b;
            //    b = c;
            //    Console.Write(c);
            //}
            //Console.ReadLine();
            #endregion

            //asal sayıları yazdıran program

            int sayi = Convert.ToInt32(Console.ReadLine());
            bool durum = true;
            for (int i = 2; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    durum = false;//asal değildir
                }

            }
            if (durum)

            {

                Console.WriteLine("Sayı asaldır");


            }
            else
            {
                Console.WriteLine("Sayı asal değildir");
            }
            Console.ReadLine();

            //1 ile 100 arası asal sayıların toplamını yazdıran program

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;
            //bool durum = true;
            //for (int i = 2; i <=10; i++)
            //{
            //    if (i % i == 0)
            //    {
            //        durum = false;//asal değildir

            //    }
            //    if (durum == true)

            //    {
            //        
            //        Console.WriteLine("Sayı asaldır");

            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.ReadLine();


            //int total = 0;
            //for (int number = 2; number < 100; number++)
            //{
            //    bool isPrime = true;

            //    for (int i = 2; i < number; i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            isPrime = false;
            //        }
            //    }
            //    if (isPrime == true)
            //    {
            //        total += number;
            //    }
            //}
            //Console.WriteLine("toplam: " + total);

            //Console.ReadLine();


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 6; j > i; j--)
            //    {
            //        Console.Write(i);
            //    }
            //}
            //    //555554444333221
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        for (int j = 0; j < i; j++)
            //        {
            //            Console.Write(i);
            //        }
            //    }
            //    Console.ReadLine();
            //    Console.ReadLine();
            //}

        }
    }
}

