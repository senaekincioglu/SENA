using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatchödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //122333444455555'i yazdırma
            //111112222333445'i yazdırma
            //try
            //{
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        for (int k = 0; k < i; k++)
            //        {
            //            Console.Write(i);
            //        }
            //    }
            //    Console.WriteLine();
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        for (int k = 5; k >= i; k--)
            //        {

            //            Console.Write(i);
            //        }

            //    }
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}



            // sayi'nin için de 9 a tam bölünen sayıların toplamı
            //start:
            //    bool isTrue = true;
            //    int toplam = 0;
            //    while (isTrue)
            //    {

            //        try
            //        {

            //            Console.WriteLine("Pozitif Bir Tam Sayı Giriniz....");
            //            int number = int.Parse(Console.ReadLine());
            //            if (number > 0)
            //            {
            //                for (int i = 0; i < number; i++)
            //                {

            //                    if (i % 9 == 0)
            //                    {
            //                        toplam += i;
            //                        Console.WriteLine("-" + i);
            //                    }

            //                    isTrue = false;

            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Lütfen Pozitif Bir Tam Sayı Giriniz...");
            //                goto start;
            //            }
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("!!!Hatalı girdi...");
            //            goto start;
            //        }
            //        Console.WriteLine("Sayıların toplamı : " + toplam);
            //        Console.ReadLine();

            ////Fibonacci
            //try
            //{
            //    int a = 1;
            //    int b = 1;
            //    int c;
            //    for (int i = 0; i < 10; i++)
            //    {
            //        c = a + b;
            //        a = b;
            //        b = c;
            //        Console.WriteLine(c);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadLine();

            //// Klavyeden girilen asal sayının asal olup olmadığını kontrol etme
            //try
            //{
            //    int kontrol = 0;
            //    Console.Write("Lütfen bir sayı giriniz0: ");
            //    int sayi = Convert.ToInt16(Console.ReadLine());
            //    for (int i = 2; i < sayi; i++)
            //    {
            //        if (sayi % i == 0)
            //            kontrol++;
            //    }

            //    if (kontrol != 0)
            //        Console.WriteLine("Sayı asal değildir.");
            //    else
            //        Console.WriteLine("sayı asaldır.");

            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("ben hata yaptım");
            //}
            //Console.ReadLine();
            ////Faktorıyel hesabı:
            //try
            //{
            //    Console.Write("Lütfen bir sayı giriniz: ");
            //    int fac = Convert.ToInt16(Console.ReadLine());
            //    int fakt = 1;
            //    for (int i = 1; i <= fac; i++)
            //    {
            //        fakt *= i;
            //    }
            //    Console.WriteLine(fakt);
            //}
            //catch (Exception hata)
            //{
            //    Console.WriteLine(hata.Message);
            //}
            // Kullanıcı tarafından klavyeden girilen 3 farklı sayıdan en küçüğünü bulmak

            //int a, b, c;
            //bool durum = true;
            //while (durum)
            //{
            //    try
            //    {
            //    start:
            //        Console.WriteLine("lütfen bir sayı giriniz: ");
            //        a = Convert.ToInt16(Console.ReadLine());
            //        Console.WriteLine("lütfen bir sayı giriniz: ");
            //        b = Convert.ToInt16(Console.ReadLine());
            //        Console.WriteLine("lütfen bir sayı giriniz: ");
            //        c = Convert.ToInt16(Console.ReadLine());

            //        if (a < b && a < c)
            //        {
            //            Console.WriteLine("{0} sayısı en küçüktür", a);
            //        }
            //        if (b < a && b < c)
            //        {
            //            Console.WriteLine("{0} sayısı en küçüktür", b);
            //        }
            //        if (c < a && c < b)
            //        {
            //            Console.WriteLine("{0} sayısı en küçüktür", c);
            //        }
            //        durum = false;
            //        goto start;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    Console.ReadLine();

            // Bir dizi tanımla int olarak. klavyeden sor kaç elemanlı olsun.sonra tekrar sorsun.

            //Console.WriteLine("Kaç elemanlı olsun");

            //   try
            //   {
            //       int deger = Convert.ToInt32(Console.ReadLine()); // dizi boyutu belirliyoruz

            //       int[] sayi = new int[deger]; //dizinin boyutunu belirliyoruz

            //       for (int i = 0; i < deger; i++)
            //       {
            //           Console.WriteLine(i + ".ci elemanı gir."); //dizi elemanlarını belirliyoruz.
            //           int eleman = Convert.ToInt16(Console.ReadLine());
            //           sayi[i] = eleman;
            //       }
            //       Console.WriteLine("dizi girme işlemi tamamlandı. \n dizi elemanları");

            //       for (int j = 0; j < deger; j++)

            //       {
            //           Console.WriteLine(sayi[j]);
            //       }
            //   }
            //   catch (Exception)
            //   {
            //       Console.WriteLine("Hatalı Giriş");
            //   }
            //   Console.ReadLine();

            //18,5 > zayıf 18,5 - 24,9 normal 24,9 ile 29,9 kilolu erkek-kadın için

            //bool durum = true;
            //while (durum)
            //{
            //    double index;
            //    double kilo;
            //    double boy;
            //    string cinsiyet;
            //    try
            //    {
            //        Console.WriteLine("Cinsiyetinizi girin");
            //        cinsiyet = (Console.ReadLine());
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Hatali giriş");
            //    }
            //    try
            //    {
            //        Console.WriteLine("Lütfen kilo giriniz :");
            //        kilo = Convert.ToDouble(Console.ReadLine());
            //    }

            //    catch (Exception)
            //    {
            //        Console.WriteLine("Hatali giriş");
            //    }
            //    try
            //    {
            //        Console.WriteLine("Lütfen boy giriniz :");
            //        boy = Convert.ToDouble(Console.ReadLine());
            //    }

            //    catch (Exception)
            //    {
            //        Console.WriteLine("Hatali giriş");
            //    }

            //    Console.WriteLine(index = ((kilo) / (boy * boy)) * 10000);

            //    if (index < 18.5)
            //    {
            //        Console.WriteLine("Boy Kilo index'iniz: ");
            //        Console.WriteLine(index = ((kilo) / (boy * boy)) * 10000);
            //        Console.WriteLine("Zayıfsınız");
            //    }
            //    else if (18.5 < index && index < 24.9)
            //    {
            //        Console.WriteLine("Boy Kilo index'iniz: ");
            //        Console.WriteLine(index = ((kilo) / (boy * boy)) * 10000);
            //        Console.WriteLine("Kilonuz Normal");
            //    }
            //    else if (24.9 < index)
            //    {
            //        Console.WriteLine("Boy Kilo index'iniz: ");
            //        Console.WriteLine(index = ((kilo) / (boy * boy)) * 10000);
            //        Console.WriteLine("Aşırı Kilolu");
            //    }


        }
    }
}


        
    





