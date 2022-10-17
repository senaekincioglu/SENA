using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace örnek_tekrarı_DİZİLER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string şehirler türünde bir dizi tanımlayıp onun indexlerini ekrana yazdıran program.
            //İki farklı şekilde yazdıracağım bu 1.
            //index sayısı=eleman sayısı - 1 
            //yani 8 elemanlı 7 indexli sehirler adlı dizi.

            // ***    //string[] sehirler = { "İstanbul,", "Ankara", "İzmit", "Aydın", "Erzincan", "Balıkesir", "Giresun", "Gümüşhane" };

            //Console.WriteLine(sehirler[0]);//0. indexi yani 1 elemanı. istanbul gibi.
            //Console.WriteLine(sehirler[1]);
            //Console.WriteLine(sehirler[2]);
            //Console.WriteLine(sehirler[3]);
            //Console.WriteLine(sehirler[4]);
            //Console.WriteLine(sehirler[5]);
            //Console.WriteLine(sehirler[6]);
            //Console.WriteLine(sehirler[7]);
            //Console.ReadLine();

            //2. yolla aynı bu dizinin yazılımı: 

            // ***   //string[] sehirler = new string[7];//7 elemanlı 6.index

            //Console.WriteLine( sehirler[0] = "İstanbul");
            //Console.WriteLine( sehirler[1] = "Ankara");
            //Console.WriteLine(sehirler[2] = "Erzincan");
            //Console.WriteLine(sehirler[3] = "Gümüşhane");
            //Console.WriteLine(sehirler[4] = "Aydın");
            //Console.WriteLine( sehirler[5] = "Balıkesir");
            //Console.WriteLine(sehirler[6] = "İzmit");

            //Console.ReadLine();

            ////int değişkenler ile 2 türlü dizi tanımlama.
            ////1. yol
            //int[] sayilar = { 1, 3, 5, 7, 9, 11, 13, 15 };//8 elemanlı 7 indexli int türünde sayilar dizisi.
            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);
            //Console.WriteLine(sayilar[3]);
            //Console.WriteLine(sayilar[4]);
            //Console.WriteLine(sayilar[5]);
            //Console.WriteLine(sayilar[6]);
            //Console.WriteLine(sayilar[7]);
            //Console.ReadLine();

            //2. yol
            //int[] sayilar = new int[7];//******* Burdaki 7 eleman sayısıdır. ****7 elemanlı 6 indexli int türünde sayilar dizisi.
            //Console.WriteLine(sayilar[0] = 1);
            //Console.WriteLine(sayilar[1] = 3);
            //Console.WriteLine(sayilar[2] = 5);
            //Console.WriteLine(sayilar[3]=7);
            //Console.WriteLine(sayilar[4]=9);
            //Console.WriteLine(sayilar[5]=11);
            //Console.WriteLine(sayilar[6]=13);
            //Console.ReadLine();

            //int değişkenler ile dizi kullanımını hepsini ayrı ayrı yazdırmak yerine for ile de yazdırabiliriz.
            //int[] sayilar = { 1, 3, 5, 7, 9, 11, 15, 17, 19, 20 };
            //for(int i=0;i<9;i++)// 0 dan 9 a kadar 10 elemanlı. 
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.ReadLine();
            //Veya dizide kaç eleman var saymak yerine dizi.lengt yapabilirsin. Örn:

            //int [] ciftsayilar = { 0, 2, 4, 6, 8, 10 };
            //for(int i=0;i<ciftsayilar.Length;i++)
            //{
            //    Console.WriteLine(ciftsayilar[i]);
            //}
            //Console.ReadLine();


            //Diziler ile beraber karar yapısı kullanımı:
            //int[] sayilar = { 10, 20, 30, 40, 50 };
            //for(int i=0;i<sayilar.Length;i++)
            //{
            //    if (sayilar[i]%20==0)//Eğer sayılar dizisindeki sayılardan 20 ile bölümünden kalan 0 olan varsa onları yaz demek.
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] isimler = { "Ali", "Veli", "Ahmet" };
            //for(int i=0;i<isimler.Length;i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            //Console.ReadLine();


            //Dizilerde toplama işlemi örneği:
            //int toplam = 0;
            //int[] sayilar = { 10,20,30,40,50,60,70,80,90 };
            //for(int i=0;i<sayilar.Length;i++)
            //{
            //    toplam = toplam + sayilar[i];
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            //            Dizi metotları,
            //Sort: diziyi küçükten büyüğe sıralar.
            //Reverse: diziyi tersten yazdırır.
            //Index of: aranan değerin index sırasını döndürür.
            //Max: dizideki en büyük elemanı verir.
            //Min: dizideki en küçük elemanı verir.
            //Lenght: dizinin boyutunu verir.

            //int[] sayilar = { 20, 11, 16, 32 };
            //Array.Sort(sayilar);//sayilar dizisindeki en küçükten sıralar.
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.ReadLine();


            //********UNUTMA DİZİLER FOR İLE.LENGHT(veya dizide ne kadar eleman varsa ) VEYA FOREACH İLE YAZDIRILABİLİR.***********
            // Foreach döngüsü, dizilerle beraber kullanılan döngü türüdür.
            //string türünde dizileri foreach ile yazdıran program
            //string[] aylar = { "OCAK ", "ŞUBAT ", "MART ", "NİSAN ", "MAYIS ", "HAZİRAN ", "TEMMUZ ", "AĞUSTOS ", "EYLÜL ", "EKİM ", 
            //    "KASIM ", "ARALIK " };
            //foreach(string ay in aylar)
            //{
            //    Console.WriteLine(ay);
            //}
            //Console.ReadLine();

            ////bunu for ile yazdırmak:
            //string[] aylar2 = { "OCAK ", "ŞUBAT ", "MART ", "NİSAN ", "MAYIS ", "HAZİRAN ", "TEMMUZ ", "AĞUSTOS ", "EYLÜL ", "EKİM ",
            //    "KASIM ", "ARALIK " };
            //for(int i=0;i<aylar2.Length;i++)
            //{
            //    Console.WriteLine(aylar2[i]);
            //}
            //Console.ReadLine();



        }

    }
}
