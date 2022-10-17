using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizilerrdevamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] dizi = { "Mehmet", "Bedir", "Bedirhan", "Sena" };
            //for(int i=0;i<dizi.Length;i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //foreach(var deger in dizi)//koleksiyon veya dizi içindeki hepsini yazdırır.//var ne tanımlıyorsan onu kabul eder.
            //{
            //    Console.WriteLine(deger);

            //}
            //Console.ReadLine();

            //string[] dizi = { "Mehmet", "Bedir", "Bedirhan", "Sena" };
            //for(int i=0;i<dizi.Length;i++)//for ile çekmek
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            //Console.WriteLine("*****");
            //Console.WriteLine(dizi[0]);//bu direkt çekmek
            //Console.WriteLine(dizi[1]);
            //Console.WriteLine(dizi[2]);
            //Console.WriteLine(dizi[3]);

            //foreach (var a in dizi)//foreach ile çekmek**en önemlisi bu
            //{
            //    Console.WriteLine(a);
            //}

            //int j = 0;
            //while (j<dizi.Length)//while ile çekmek
            //{
            //    j++;
            //    Console.WriteLine(dizi[j]);

            //}
            //Console.ReadLine();


            // bu yazılanı sonsuz döngü olarak goto ile veya while ile yazılır.
            //bool durum = true;//açık bırakmak
            //while(durum)
            //{
            //    Console.Write("Lütfen adınızı girin= ");
            //    string ad = Convert.ToString(Console.ReadLine());
            //    Console.Write("Lütfen soyadınızı giriniz= ");
            //    string soyad = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine(ad + " " + soyad + " " + "Hoşgeldiniz");

            //}

            //Console.ReadLine();

            //cinsiyete göre boy kilo indexini hesaplayan program.
            //KIZLAR VE ERKEKLER İÇİN 18.5 den küçükse zayıf, 18.5 ve 24.9 arası ise
            //normal, 24.9 ile 29.9 arası ile aşırı kilolu


            //bool durum = true;
            //while (durum)
            //{
            //    Console.Write("Lütfen cinsiyetini giriniz= ");
            //    string cinsiyet = Convert.ToString(Console.ReadLine());
            //    Console.Write("Lütfen boyunuzu girin= ");
            //    double boy = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Lütfen kilonuzu girin= ");
            //    double kilo = Convert.ToDouble(Console.ReadLine());
            //    double index;
            //    index = ((kilo) / (boy * boy)) * 10000;
            //    if (cinsiyet == "kadın")
            //    {
            //        if (index < 18.5)
            //        {
            //            Console.Write(index + "Zayıf" + cinsiyet);
            //        }
            //        else if (index > 18.5 && index < 24.9)
            //        {
            //            Console.Write(index + "Normal" + cinsiyet);
            //        }
            //        else if (index > 24.9 && index < 29.9)
            //        {
            //            Console.Write(index + "Kilolu" + cinsiyet);
            //        }
            //        else
            //        {
            //            Console.Write("çok kilolu" + cinsiyet);
            //        }
            //    }
            //    else if (cinsiyet == "erkek")
            //    {
            //        if (index < 18.5)
            //        {
            //            Console.Write(index + "Zayıf " + cinsiyet);
            //        }
            //        else if (index > 18.5 && index < 24.9)
            //        {
            //            Console.Write(index + "Normal " + cinsiyet);
            //        }
            //        else if (index > 24.9 && index < 29.9)
            //        {
            //            Console.Write(index + "Kilolu " + cinsiyet);
            //        }
            //        else
            //        {
            //            Console.Write("çok kilolu " + cinsiyet);
            //        }
            //    }
            //}
            //Console.ReadLine();


            //string cinsiyet;
            //double boy, kilo, index;
            //while (true)
            //{
            //    Console.Clear();
            //    Console.Write("Lütfen cinsiyetini giriniz= ");
            //    cinsiyet = Convert.ToString(Console.ReadLine());
            //    Console.Write("Lütfen boyunuzu girin= ");
            //    boy = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Lütfen kilonuzu girin= ");
            //    kilo = Convert.ToDouble(Console.ReadLine());

            //    switch (cinsiyet)
            //    {
            //        case "erkek":
            //            index = ((kilo) / (boy * boy)) * 10000;
            //            if (index < 18.5)
            //            {
            //                Console.WriteLine("zayıf" + index);
            //            }



            //            else if (index > 18.5 && index < 24.9)
            //            {
            //                Console.WriteLine("Normal" + index);
            //            }
            //            else if (index > 24.9 && index < 29.9)
            //            {
            //                Console.WriteLine("Kilolu" + index);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Aşırı kilolu" + index);


            //            }
            //            break;
            //        case "kadın":
            //            index = ((kilo) / (boy * boy)) * 10000;
            //            if (index < 18.5)
            //            {
            //                Console.WriteLine("zayıf" + index);
            //            }



            //            else if (index > 18.5 && index < 24.9)
            //            {
            //                Console.WriteLine("Normal" + index);
            //            }
            //            else if (index > 24.9 && index < 29.9)
            //            {
            //                Console.WriteLine("Kilolu" + index);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Aşırı kilolu" + index);


            //            }
            //            break;


            //    Console.ReadLine();
            //(fonksiyonlar)  sayının mutlak değeri
            // Console.WriteLine("Lütfen bir sayı giriniz= ");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Mutlak hali " + Math.Abs(sayi));//math matematik formülü abs mutlağı demek
            // Console.ReadLine();

            //(fonksiyonlar)  sayının yuvarlama değeri
            //Console.WriteLine("Lütfen bir sayı giriniz= ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("yuvarlanmış hali " + Math.Ceiling(sayi2));//math matematik formülü ceilinh yuvarlanmış hali demek
            //Console.ReadLine();//hepsini mesela mat. yazınca çıkıyor.
            //Random rnd = new Random();
            //int b = rnd.Next(0,100);
            //Console.WriteLine(b);
            //Console.ReadLine();

            //dizi tanımla şehirleri yaz randomla çağır

            //string[] sehirler = { "iSTANBUL", "ERZİNCAN", "GİRESUN", "AYDIN", "BALIKESİR" };

            //Random rnd = new Random();

            //foreach (string s in sehirler)
            //{

            //    int b = rnd.Next(0, sehirler.Length);
            //    Console.Write(b);
            //}
            //Console.ReadLine();


            //Örnek bu doğrusu
            //string[] sehirler = { "iSTANBUL", "ERZİNCAN", "GİRESUN", "AYDIN", "BALIKESİR" };
            //Random rnd = new Random();
            //int b = rnd.Next(0, sehirler.Length);
            //Console.Write(b);
            //Console.Write(sehirler[b]);
            //Console.ReadLine();








        }


            }


        }

    


