using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tekrar_2.Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   atama işlemleri
            //   = atama
            //   == eşittir
            //   >= büyük eşit
            //   <=küçük eşit
            //   < küçüktür
            //   >büyüktür
            //   ++ arttırma
            //   --azaltma
            //   && Ve
            //   ||veya


            //if(eğer böyleyse)
            //{
            //    bunu yap
            //}
            //else (değilse)
            //        {
            //    bunu yap
            //}

            //console ekranında bir string tanımlansın.
            //tanımlanan değer girdiğin console ekranındaki
            //değere eşitse doğru yazsın. değilse yanlış yazsın
            //eğer dendiği için if else

            //string isim = "aa";
            //if (isim == "Sena") 
            //{
            //    Console.Write("Doğru");
            //}
            //else
            //{
            //    Console.Write("Yanlış");
            //}
            //Console.ReadLine();

            //Kullanıcıdan string değer isteyip eğer doğru ise
            //doğru yazmasını, yanlış ise yanlış yazmasınını
            //isteyen program.

            //Console.Write("Lütfen isim giriniz= ");
            //string isim = Convert.ToString(Console.ReadLine());
            //if (isim == "Sena")
            //{
            //    Console.Write("Doğru isim girdiniz");
            //}
            //else
            //{
            //    Console.Write("Yanlış isim girdiniz");
            //}
            //Console.ReadLine();

            //Kullanıcıya klavyeden değer girdiricez, eğer
            //ankara ise doğru, değilse yanlış yazdıran program.

            //Console.Write("Lütfen şehir girin= ");
            //string sehir = Convert.ToString(Console.ReadLine());
            //if(sehir=="Ankara"|| sehir=="ankara"||sehir=="ANKARA")
            //{
            //    Console.Write(sehir + " Doğru bildiniz");
            //}
            //else
            //{
            //    Console.Write(sehir + " Yanlış girdiniz");
            //}
            //Console.ReadLine();

            //Klavyeden girilen sayının negatif mi pozitif mi olduğunu
            //bulan program.

            //Console.Write("Lütfen bir sayı girin= ");
            //double sayi = Convert.ToDouble(Console.ReadLine());
            //if(sayi<0)
            //{
            //    Console.Write("Girilen sayı 0 dan küçük" + sayi);
            //}
            //else if(sayi==0)
            //{
            //    Console.Write("Girilen sayı 0 a eşittir");
            //}
            //else
            //{
            //    Console.Write("Girilen sayı 0 dan büyüktür.");
            //}
            //Console.ReadLine();

            //klavyeden girilen iki notun ortalamasını hesaplayıp
            //50 den büyükse geçti,50 den küçükse kaldı yazdıran
            //program.

            //Console.Write("1. notu girin= ");
            //int not1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. notu girin= ");
            //int not2 = Convert.ToInt32(Console.ReadLine());
            //int ortalama = (not1 + not2) / 2;
            //if(ortalama<50)
            //{
            //    Console.Write(ortalama + " kaldı");
            //}
            //else
            //{
            //    Console.Write(ortalama + " geçti");
            //}
            //Console.ReadLine();

            //klavyeden girilen sayının bölümünden kalan eğer 2 ise 
            //bölümden kalan 2 yazdırsın
            //değilse hatalı yazdırsın

            //Console.Write("Lütfen bir sayı giriniz= ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if(sayi%2==1)
            //{
            //    Console.Write(sayi + " sayısı tektir");
            //}
            //else
            //{
            //    Console.Write(sayi + " sayıdı" +
            //        " çifttir");
            //}
            //Console.ReadLine();


            //klavyeden girilen sayının asal olup olmadığını bulan
            //program.

            //Console.Write("Sayı girin= ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //bool sayi1 = true;
            //for (int i = 2; i < sayi; i++)
            //{
            //    if (sayi%i==0)
            //    {
            //        sayi1 = false;
            //    }

            //}
            //if(sayi1)
            //{
            //    Console.Write("Sayı asaldır");
            //}
            //else
            //{
            //    Console.Write("Sayı asal değildir");
            //}
            //Console.ReadLine();


            //Klavyeden girilen sayının tek mi çift mi olduğunu gösteren program.
            //Console.Write("BİR SAYI GİRİN= ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if(sayi%2==0)
            //{
            //    Console.Write(sayi +" sayısı çifttir");
            //}
            //else
            //{
            //    Console.Write(sayi + " sayısı tektir");
            //}
            //Console.ReadLine();

            //Klavyeden girilen karenin alan ve çevresini hesaplayan program.
            //Console.Write("Karenin kenarını girin");
            //double kenar = Convert.ToDouble(Console.ReadLine());
            //double alan = kenar * kenar;
            //double cevre = kenar * 4;
            //Console.WriteLine("Karenin alanı= " + alan + " Karenin çevresi " + cevre);
            //Console.ReadLine();

            //bir manav bölümünde satılan elma armut ve muz( elma=3, armut=5, muz=7 tl)
            // kaç kg almak istediğini ve hangi üründen almak istediğini sorup
            // ödeyeceği ücretin hesaplanması 

            //int elma = 3, armut = 5, muz = 7;
            //Console.Write("kaç kg almak istiyorsunuz= ");
            //int kg = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Hangi üründen almak istiyorsunuz= ");
            //string urun = Convert.ToString(Console.ReadLine());
            //int toplamfiyat;
            //if (urun == "elma")
            //{
            //    Console.WriteLine(toplamfiyat = kg * elma);

            //}
            //else if (urun == "armut")
            //{
            //    Console.WriteLine(toplamfiyat = kg * armut);

            //}
            //else

            //{
            //    Console.WriteLine(toplamfiyat = kg * muz);
            //}
            //Console.ReadLine();

            //hangi mevsimi girince o mevsime ait ayları yazdıran program.
            //Console.Write("Mevsim girin= ");
            //string mevsim = Convert.ToString(Console.ReadLine());
            //if(mevsim=="ilkbahar"||mevsim=="İLKBAHAR"||mevsim=="İlkbahar")
            //{
            //    Console.WriteLine("mart, nisan , mayıs");
            //}
            //else if(mevsim == "yaz" || mevsim == "YAZ" || mevsim == "Yaz")
            //{
            //    Console.WriteLine("haziran, temmuz , ağustos");
            //}
            //else if (mevsim == "sonbahar" || mevsim == "SONBAHAR" || mevsim == "Sonbahar")
            //{
            //    Console.WriteLine("eylül, ekim , kasım");
            //}
            //else if(mevsim == "kis" || mevsim == "KİS" || mevsim == "Kis")
            //{
            //    Console.WriteLine("aralık", "ocak", "şubat");
            //}
            //else
            //{
            //    Console.Write("Hatalı giriş yaptınız");
            //}
            //Console.ReadLine();


            //C# programlama dilinde switch-case komutu if ile yapılacak işlemlerin karışık
            //olduğu durumlarda daha sade ve anlaşılır bir kod yapısı oluşturmak için
            //kullanılmaktadır.//
            //switch : koşul için gerekli olan değişken girilir.
            //case : durumları kontrol etmek için kullanılır ve karşılaşılacak durumlar
            //girilir.
            //break : döngüden çıkmak için kullanılır.(döngüyü durdurur)
            //default : durumlardan herhangi birisi yoksa kullanılır.(else gibi)

            //klavyeden kullanıcı bir ay giricek onun kaçıncı ay olduğunu bize
            //söyleyen program (switch case ile)

            //Console.Write("Lütfen bir ay girin= ");
            //string ay = Convert.ToString(Console.ReadLine());

            //switch (ay)
            //{
            //    case "ocak":
            //        Console.WriteLine("1. ay");
            //        break;
            //    case "şubat":
            //        Console.WriteLine("2. ay");
            //        break;
            //    case "mart":
            //        Console.WriteLine("3. ay");
            //        break;
            //    case "nisan":
            //        Console.WriteLine("4. ay");
            //        break;
            //    case "mayıs":
            //        Console.WriteLine("5. ay");
            //        break;
            //    case "haziran":
            //        Console.WriteLine("6. ay");
            //        break;
            //    case "temmuz":
            //        Console.WriteLine("7. ay");
            //        break;
            //    case "ağustos":
            //        Console.WriteLine("8. ay");
            //        break;
            //    case "eylül":
            //        Console.WriteLine("9. ay");
            //        break;
            //    case "ekim":
            //        Console.WriteLine("10. ay");
            //        break;
            //    case "kasım":
            //        Console.WriteLine("11. ay");
            //        break;
            //    case "aralık":
            //        Console.WriteLine("12. ay");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş yaptınız");
            //        break;

            //        Console.ReadLine();



            // switch case ile 4 işlem girilen iki sayının çarpımı toplamı bölümü farkı


            //Console.Write("Lütfen birinci sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı girin");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen seçim yapın");
            //string secim = Convert.ToString(Console.ReadLine());
            //int sonuc;
            //switch(secim)
            //{
            //    case "+":
            //        sonuc = sayi1 + sayi2;
            //        Console.Write("toplam değeriniz"+ sonuc);
            //        break;
            //    case "-":
            //        sonuc = sayi1 - sayi2;
            //        Console.Write("çıkarma değeriniz" + sonuc);
            //        break;
            //    case "*":
            //        sonuc = sayi1 * sayi2;
            //        Console.Write("çarpım değeriniz" + sonuc);
            //        break;
            //    case "/":
            //        sonuc = sayi1 / sayi2;
            //        Console.Write("bölüm değeriniz" + sonuc);
            //        break;
            //    default:Console.Write("Hatalı seçim yaptınız");
            //        break;



            //}
            //Console.ReadLine();

            //FOR DÖNGÜSÜ: 
            //kodların tekrar sayısı belli olduğunda kullanılır. Döngü için tanımlanan şart ifadesi her
            //sağlandığında döngüdeki kodlar tekrar çalışır. Yani tekrar edilmesi gereken kod bloglarını tekrar yazmak
            //yerine for döngüsü kullanarak istediğimiz adette çalışmasını sağlayabiliriz.

            //for(döngü değişkeni başlangıç değeri; döngü şart ifadesi;döngü değişken sayacı;
            //{
            //    yazılacak kodlar
            //}
            //ör: for(int i =0;i<10;i++)
            //{
            //yazılacak kodlar
            //}

            //ekrana 10 defa merhaba dünya yazdıran program
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Merhaba dünya");
            //}
            //Console.ReadLine();

            //1 ile 10 arasındaki sayıları(1 ve 10 dahil)ekrana listeleten program.
            //for (int i = 1; i <=10; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //1 ile 10 arasındaki sayıları(1 ile 10 dahil) toplatan program.

            //int toplam = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    toplam = toplam + i;

            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            ////1 DEN 50 YE KADAR OLAN SAYILARIN TOPLAMI FOR İLE 

            //int toplam = 0;
            // for (int i = 0; i < 50; i++)
            // {
            //     toplam = toplam + i;
            // }
            // Console.WriteLine(toplam);
            // Console.ReadLine();

            //1 DEN 50 YE KADAR OLAN TEK SAYILARIN TOPLAMI for ile

            //int toplam = 0;
            //for (int i = 1; i < 50; i+=2)
            //{
            //    toplam = toplam + i;
            //}
            //Console.Write(toplam);

            //int toplam2 = 0;
            //for (int i = 0; i < 50; i+=2)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            //77 ye kadar olan 9 a tam bölünen sayılar

            //for (int i = 0; i < 77; i++)
            //{
            //    if(i%9==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.ReadLine();

          
            //iç içe for
            //her satırda  artarak veya azalarak gitmesi isteniyorsa kullanılır.

            //for(int i=0;i<10;i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            


            //Console.ReadLine();





            }




        }

    }


