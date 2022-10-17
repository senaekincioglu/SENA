using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach dizinin veya koleksiyonu sıralar

            //diziler : aynı türden değişkenlerin bir arada bulunduğu saklama alanıdır.
            //Aynı türden değişkenlerin bir arada bulunduğu saklanma alanı dizidir. 
            //            Diziler tek ve iki boyutlu olabilir.  İki boyutlu dizler matris mantığındadır.Dizi tanımlanırken önce
            //            değişkenin türü sonra köşeli parantezler “[ ]” sonrasında değişkenin tanımı yapılır.
            //            Eğer köşeli parantez içine “[ ,]” virgül koyulursa bu dizinin 2 boyutlu olduğu anlamına gelir.
            //            Virgül ile birlikte dizi boyutu belirlenir.
            //Dizi elemanları indekslerle tanımlar. Ve bu indeks 0’dan başlar. Bu indeks değerlerini kullanarak o indekse gelen dizi elmanı ile işlem yapılabilir.
            //Örnek 1: int[] sınıf = new int[10](burada sınıf dizinin 10 elemandan oluştuğu, tüm elemanlarının int değerinde olduğu ve
            //tek boyutlu dizi olduğu anlaşılır.Bu dizi 9 indeks değerine sahiptir.)
            //Örnek 2: int[,] okul = new int[3, 2]; (burada okul dizisi 3x2 yani 3 satır 2 sütundan oluşan bir dizidir.
            //İnt değerindedir. Dizi elemanları şu[0, 0], [0,1], [1,0], [1,1], [2,0], [2,1] .
            //Diziler kod blokları içinde “Foreach” döngüsü ile ya da iç içe “For” döngüsü ile kullanılır.Aynı zamanda
            //döngülerde kullanırken dizinin uzunluğu ile işlem yapılır.
            //Array tüm dizi türlerinin soyut temel türüdür.Array dizisini kullanmak için ayrıca kütüphane eklenmelidir.

            //Tek boyutlu diziler 
            //int[] sayilar = { 1, 2, 3, 4 };
            //Console.WriteLine(sayilar.Length);//sayilar.lengt 4 verir uzunluğunu 
            //Console.ReadLine();
            //veya
            //int[] sayilar = new int[6];//6 elemanlı 5. index
            //sayilar[0] = 5;
            //sayilar[1] = 6;
            //sayilar[2] = 7;
            //sayilar[3] = 10;
            //sayilar[4] = 9;
            //sayilar[5] = 12;
            //Console.WriteLine(sayilar[3]);/*sayilar.Lengthuzunluğu verir*/
            //Console.ReadLine();

            //string[] isimler = { "Sena", "Öznur", "Ali" };
            //veya 
            //string [] isimler = new string [6];
            //isimler[0] = "Sena";
            //isimler[1] = "Betül";
            //isimler[2] = "elif";
            //Console.WriteLine(isimler[2]);//elifi verir.
            //Console.ReadLine();

            //char[] karakter = new char[5];
            //karakter[0] = 'a';
            //karakter[0] = 'B';
            //karakter[0] = 'C';
            //karakter[0] = 'C';
            //karakter[0] = 'E';
            //Console.WriteLine(karakter[3]);
            //Console.ReadLine();



            //char[] karakter = {'a','b','c'};

            //dizi tanımla ve kullanıcıya sor kaç elemalı olsun. bunu forla yazdır
            //int[] sayilar;
            //Console.WriteLine("Kaç elemannlı olsun");
            //int deger = Convert.ToInt32(Console.ReadLine());
            //sayilar = new int[deger];//int[ değer ]dizinin boyutunu belirler
            //for(int i = 0; i < deger; i++)
            //{
            //    Console.WriteLine(i + ".nci elemanı gir: ");
            //    int eleman = Convert.ToInt32(Console.ReadLine());
            //    sayilar[i] = eleman;
            //}
            //Console.WriteLine("dizi girme işlemi tamamlandı. \n dizi elemanları,");

            //for (int j = 0; j < deger; j++)
            //{
            //    Console.WriteLine(sayilar[j]);
            //}


            //Console.ReadLine();

            //string olarak dizi tanımla iiçine yazı yaz ve yazılanları forla yazdır

            string[] dizi = { "Sena", "Esma", "Öznur", "Betül" };
            for (int i = 0; i < dizi.Length; i++)//index 0 dan başladığı için i=0 yapıldı.
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();



        }
    }
}
