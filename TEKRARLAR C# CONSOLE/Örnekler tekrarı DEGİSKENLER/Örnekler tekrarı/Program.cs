using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Örnekler_tekrarı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Sena");
            //Console.Write("Ekincioğlu");//Write yan yana yazar

            //Console.WriteLine("Sena");//WriteLine alt alta yazar
            //Console.WriteLine("Ekincioğlu");
            //Console.ReadLine();//Readline tüm console da yazdıklarını siyah ekranda gösterir.

            //string deger = "Merhaba";
            //Console.WriteLine(deger);
            //string sehir = "İstanbul";
            //string ilce = "Ümraniye";
            //Console.Write(sehir +" "+ ilce);
            //Console.ReadLine();

            //sayi1 ile sayi2 yi toplayıp ekrana yazdıran program
            //int sayi1 = 12;
            //int sayi2 = 13;
            //int toplam = 0;
            //Console.Write(toplam);
            //Console.ReadLine();

            //ÖNEMLİ!!!Ama değerler kullanıcıdan girilecekse string ise mesela string ilce=convert.tostring(console.ReadLine()); yazılır. console
            //ReadLine yazılmasının sebebi de yazılanı ekranda tanıması ve göstermesi için.
            //Ve ilk başta kullanıcının karşısına çıkan yazı mesela sayı girin yazısı yazılmalı sonra sayı tanımlanıp convert edilip
            //readline yazılmalı.

            //Örnek: Kullanıcıdan iki sayı isteyen ve girilen iki sayısı toplayan program.7

            //Console.Write("Lütfen 1. sayıyı giriniz= ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz= ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;           
            //toplam = sayi1 + sayi2;
            //Console.WriteLine("İki sayının toplamı= "+toplam);
            //Console.ReadLine();

            //Aritmetik işlem yapan program(toplam, fark, çarpım, bölüm) İLK SAYILAR HAZIR OLSUN.
            /*Console.WriteLine("*******Aritmetik İşlemler*********");*///WriteLine bir sonraki satırın alt satırda olması için yazılır
                                                                        //Yazılan satırın alt satırda olması için değil.
                                                                        //Console.WriteLine();
                                                                        //int sayi1 = 10, sayi2 = 5, toplam, fark, carpim, bolum;
                                                                        //toplam = sayi1 + sayi2;
                                                                        //fark = sayi1 - sayi2;
                                                                        //carpim = sayi1 * sayi2;
                                                                        //bolum = sayi1 / sayi2;
                                                                        //Console.WriteLine("Sayıların toplamı= " + toplam);
                                                                        //Console.WriteLine("Sayıların farkı= " + fark);
                                                                        //Console.WriteLine("Sayıların çarpımı= " + carpim);
                                                                        //Console.WriteLine("Sayıların bölümü= " + bolum);
                                                                        //Console.WriteLine();
                                                                        //Console.Write("*******Aritmetik İşlemler*********");

            //Console.ReadLine();

            //Aritmetik işlem yapan program(toplam, fark, çarpım, bölüm) Sayılar kullanıcıdan istensin.
            //Console.Write("Lütfen 1. sayıyı giriniz= ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz= ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam, fark, carpim, bolum;
            //Console.WriteLine();
            //toplam = sayi1 + sayi2;
            //fark = sayi1 - sayi2;
            //carpim = sayi1 * sayi2;
            //bolum = sayi1 / sayi2;
            //Console.WriteLine("Sayıların toplamı= " + toplam);
            //Console.WriteLine("Sayıların farkı= " + fark);
            //Console.WriteLine("Sayıların çarpımı= " + carpim);
            //Console.WriteLine("Sayıların bölümü= " + bolum);
            //Console.WriteLine();
            //Console.ReadLine();


            //string ad = "Sena";
            //string soyad = "Ekincioğlu";
            //string bolum = "Yönetim Bilişim Sistemleri";
            //string ders = "Yazılım";
            //int sınav1 = 65;
            //int sınav2 = 50;
            //int ortalama = (sınav1 + sınav2) / 2;

            //Console.WriteLine("///////Öğrenci Bilgi Sistemi///////");
            //Console.WriteLine();
            //Console.WriteLine("AD= " + ad);
            //Console.WriteLine("SOYAD= " + soyad);
            //Console.WriteLine("BÖLÜM= " + bolum);
            //Console.WriteLine("DERS= " + ders);
            //Console.WriteLine("SINAV1= " + sınav1);
            //Console.WriteLine("SINAV2= " + sınav2);
            //Console.WriteLine("ORTALAMA= " + ortalama);
            //Console.WriteLine();
            //Console.WriteLine("///////Öğrenci Bilgi Sistemi///////");
            //Console.ReadLine();


            //Double sayılarda arasına nokta koyulur, virgül kabul etmez.
            //double sayi = 24.5;
            //Console.WriteLine(sayi);
            //Console.ReadLine();

            //Ondalıklı iki sayının ortalamasını bulan program

            //double sayi1=20.5;
            //double sayi2=62.4;
            //double ortalama;
            //ortalama = (sayi1 + sayi2) / 2;
            //Console.WriteLine(ortalama);
            //Console.ReadLine();

            //Kullanıcı tarafından girilen iki tane ondalıklı sayının ortalamasını bulan program.

            //Console.Write("Lütfen birinci sayı giriniz= ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz= ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());            
            //double ortalama;
            //ortalama = (sayi1 + sayi2) / 2;
            //Console.WriteLine(ortalama);
            //Console.ReadLine();

            //ReadLine(), kullanıcıdan alınan metinsel ifadeyi hafızada tutar.
            //        Tür: string
            //ReadKey(), klavyeden basılan tuşun bilgisini verir.
            //Read(), girilen parametrenin sadece ilk karakterinin ascii karşılığını verir.

            //Kullanıcı tarafından şehir isteyen ve ekrana yazdıran program.

            //Console.Write("Lütfen bir şehir giriniz= ");
            //string sehir = Convert.ToString(Console.ReadLine());
            //Console.WriteLine(sehir);
            //Console.ReadLine();


            //Klavyeden girilen şehir ve ilçeyi ekrana yazdıran program.

            //Console.Write("Lütfen şehir giriniz= ");
            //string sehir=Convert.ToString(Console.ReadLine());
            //Console.Write("Lütfen ilçe giriniz= ");
            //string ilce = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Şehir= " + sehir +"  "+  "ilce= " + ilce);
            //Console.ReadLine();

            //Console.Write("Lütfen bir sayı giriniz= ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi);
            //Console.ReadLine();

            //Not: sayi =Convert.ToInt32(Console.ReadLine()); bu şu demek 
            //parantez içindeki ifadeyi ToInt32 aralığına dönüştür. 
            //Parantez içindeki ifade ise benim klavyeden girdiğim değeri tutar.
            //ToInt32 metod olduğu için yazdıktan sonra parantez açmayı asla unutma

            //Klavyeden kısa ve uzun kenarı girilen dikdörtgenin alan ve çevresini hesaplayan program.
            //Console.Write("Lütfen 1. kenarı giriniz= ");
            //double kenar1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Lütfen 2. kenarı giriniz= ");
            //double kenar2 = Convert.ToDouble(Console.ReadLine());
            //double alan, cevre;
            //alan = kenar1 * kenar2;
            //cevre = (kenar1 + kenar2) * 2;
            //Console.WriteLine("Dikdörtgenin alanı= " + alan + " " +  "Çevresi= " + cevre);
            //Console.ReadLine();


            //Klavyeden girilen ondalıklı sayıyı ekrana yazan program 
            //Console.Write("Lütfen bir sayı giriniz= ");
            //double sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Girdiniz sayı= "+sayi);
            //Console.ReadLine();

            //Klavyeden girilen iki tane ondalıklı sayıyı toplayıp ekrana yazdıran program.

            //Console.Write("Lütfen bir sayı girin= ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı girin= ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //double toplam = 0;
            //toplam = sayi1 + sayi2;
            //Console.WriteLine("Girilen sayıların toplamı= " + toplam);
            //Console.ReadLine();

            //Char= Şifreleme ve şifre çözme işlemlerinde çokça kullanılır.

            //char degisken = 'a';
            //degisken = Convert.ToChar(Console.ReadLine());
            //Console.Write(degisken);
            //Console.ReadLine();

            //char deger = '6';
            //Console.WriteLine(deger);
            //Console.ReadLine();

            //Console.Write("Lütfen bir seçim yapınız= ");
            //char secım = Convert.ToChar(Console.ReadLine());
            //Console.Write("Seçiminiz= "+secım);
            //Console.ReadLine();

            //byte sayi = 255;
            //Console.Write(sayi);
            //Console.ReadLine();

            //Byte ile iki sayının toplamını bulan program.
            //byte sayi1 = 24;
            //byte sayi2 = 36;
            //byte toplam ;
            //toplam = Convert.ToByte(sayi2 + sayi1);
            //Console.WriteLine("Toplam= " + toplam);
            //Console.ReadLine();

            //Klavyeden girilen iki sayının çarpımını byte türünde bulan program.

            //Console.Write("Lütfen bir sayı giriniz= ");
            //byte sayi1 = Convert.ToByte(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz= ");
            //byte sayi2 = Convert.ToByte(Console.ReadLine());
            //byte carpim;
            //carpim = Convert.ToByte(sayi1 * sayi2);
            //Console.WriteLine("Çarpım sonucu= " + carpim);
            //Console.ReadLine();

            //Not = Float değişkenlerde kod kısmına ondalıklı bir değişken gönderirken sonuna f harfi eklememiz gerekiyor.
            //float sayi=24.5f;
            //Console.WriteLine(sayi);
            //Console.ReadLine();


            //Klavyeden girilen iki sayının toplamını float ile toplayan program.

            //Console.Write("Lütfen birinci sayıyı giriniz= ");
            //float sayi1 = float.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz= ");
            //float sayi2=float.Parse(Console.ReadLine());
            //float toplam;
            //toplam = sayi1 + sayi2;
            //Console.WriteLine("İki sayının toplamı= "+ toplam);
            //Console.ReadLine();

            //Decimal, double değişkenlere göre daha geniş bir aralığı bulunan ve ondalıklı sayısal işlemlerde kullanılan değişken
            //türüdür.




            //decimal sayi = 20.5m;
            //Console.WriteLine(sayi);
            //Console.WriteLine();
            //Console.ReadLine();

            //Klavyeden bir kenar girilerek karenin alanı ve çevresini hesaplayan program.

            //Console.Write("Lütfen kenarı giriniz=  ");
            //decimal kenar = Convert.ToDecimal(Console.ReadLine());
            //decimal alan, cevre;
            //alan = kenar * kenar;
            //cevre = kenar * 4;
            //Console.WriteLine("alan= " + alan + " " + "Çevre " + " " + cevre);
            //Console.ReadLine();


            // Bool, True - False şeklinde değer alan değişken türüdür.Bool ifadesi boolean ifadesinin takma adıdır. (alias)
            // Evli mi bekar mı? Çalışıyor mu işsiz mi? Geçti mi kaldı mı?

            //bool durum = true;
            //Console.Write("Sınavı geçti mi? "+ durum);
            //Console.ReadLine();

            //Console.Write("Kullanıcı sisteme üye mi? ");
            //bool uyemi = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("Kullanıcının sistemdeki durumu= " + uyemi);
            //Console.ReadLine();

//            Console.WriteLine(byte.MaxValue);
//            255
//Console.WriteLine(byte.MinValue);
//            0
//Console.WriteLine(int.MaxValue);
//            2147483647
//Console.WriteLine(int.MinValue);
//            -2147483648
//Console.WriteLine(float.MaxValue);
//            3,402823E+38
//Console.WriteLine(float.MinValue);
//            -3,402823E+38
//Console.WriteLine(sbyte.MaxValue);
//            127
//Console.WriteLine(sbyte.MinValue);
//            -128
//Console.ReadLine()






        }

    }
}
