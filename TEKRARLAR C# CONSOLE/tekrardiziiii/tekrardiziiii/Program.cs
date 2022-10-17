using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tekrardiziiii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programlarımız üzerinden değişkenler oluştururuz. Oluşturduğumuz bu değişkenlerin
            //içerisinde verileri tutmayı amaçlarız. Ancak benzer tipte ortak değerler için sürekli 
            //değişken oluşturmak yerine dizi tanımlaması yaparak değerlerimizi programımıza
            //tanıtabiliriz.

            //Değişken türü [] dizinin ismi = {dizi elemanları}
            //dizide index 0 dan başlar yani aşağıdaki örnek için 6 indisli 7 elemanlı bir dizi
            //olur.
            //int[] sayilar = { 1, 2, 3, 4, 5,6,7};
            /*Console.WriteLine(sayilar[0]);*///0. index yani 1. elemanı soruyor yani cevap 1.
                                              //Console.WriteLine(sayilar[10]);//HATA VERİR (dizin dizi sınırlarının
                                              //dışında ). çünkü 10. index yok 
                                              //string[] isimler = { "sena", "beyza", "şeyma", "mısra", "neval", "büşra" };
                                              //Console.WriteLine(isimler[3]);//3. indexi yani 4 elemanı soruyor. mısrayı getirir.
                                              //Console.ReadLine();

            //klavyeden 5 sayı girilecek ve diziye atanacak. sayıların en byüğünü bulup
            //yazdıran program.
            //int[] sayilar = new int[5];//5 elemanlı 4 indexli dizi.
            //for (int i = 0; i < 5; i++)//index olarak alır
            //{
            //    Console.Write((i + 1).ToString() + ".Sayıyı girin= ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int eb = sayilar[0];
            //for (int i = 1; i < 5; i++)
            //{
            //    if (eb < sayilar[i])
            //    {
            //        eb = sayilar[i];
            //    }
            //}
            //Console.WriteLine("girilen dizideki en büyük eleman= "+eb);
            //Console.ReadLine();

            //dizi tanımla ve kullanıcıya sor kaç elemalı olsun. bunu forla yazdır.

            //Console.Write("Kaç elemanlı olsun= ");
            //int eleman = Convert.ToInt32(Console.ReadLine());
            //int[]sayilar=new int[eleman];
            //for (int i = 0; i < eleman; i++)
            //{
            //     Console.WriteLine(i + ".nci elemanı gir: ");

            //      sayilar[i] = eleman;
            //}
            // string olarak dizi tanımla iiçine yazı yaz ve yazılanları forla yazdır

            //string[] dizi = { "beyza","hüseyin","şeyma","elif" };
            //for (int i = 0; i < dizi.Length; i++)//index 0 dan başladığı için i=0 yapıldı.
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            //Console.ReadLine();


        }
    }
}
