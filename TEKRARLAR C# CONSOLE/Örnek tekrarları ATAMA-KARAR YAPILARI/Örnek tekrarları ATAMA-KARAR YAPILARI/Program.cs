using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Örnek_tekrarları_ATAMA_KARAR_YAPILARI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Şehir adı: Adana yaz enter’a bas eğer doğruysa aşağıdaki sonuç gelir. Doğru şehir
            //Şehir adı: İstanbul yaz enter’a bas değilse aşağıdaki sonuç gelir. Yanlış şehir. //KLAVYEDEN GİRİLECEK.
            //ab:
            // Console.Write("Şehir adı giriniz= ");
            // string sehir = Convert.ToString(Console.ReadLine());
            // if (sehir == "adana")
            // {
            //     Console.Write("Doğru bildiniz");
            // }
            // else
            // {
            //     Console.Write("Yanlış bildiniz");
            // }
            // goto ab;
            // Console.ReadLine();
            //goto yazınca sormaya devam eder veya işleme devam eder.


            //Klavyeden girilen sayı 23 e eşitse doğru girildi, değilse yanlış girildi yazdıran program.
            //Console.Write("Lütfen bir sayı girin= ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if(sayi==23)
            //{
            //    Console.WriteLine("Sayıyı doğru bildiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Sayıyı yanlış bildiniz");
            //}
            //Console.ReadLine();


            //Klavyeden iki sayı girilecek ve sayıların ortalaması 65 ve üzeri ise geçti, altı ise kaldı yazdıran program.
            //Console.Write("1. NOTU GİRİNİZ= ");
            //int not1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. NOTU GİRİNİZ= ");
            //int not2 = Convert.ToInt32(Console.ReadLine());
            //int ort = (not1 + not2) / 2;
            //Console.WriteLine("ORTALAMANIZ= " + ort);
            //if(ort>=65)
            //{
            //    Console.WriteLine("Geçtiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Kaldınız");
            //}
            //Console.ReadLine();


            //Kullanıcıdan kullanıcı adı ve şifre istenecek. Eğer kullanıcı adı ve şifre doğru ise Hoşgeldiniz, eğer yanlış ise hata
            //yazdıran program.

            //Console.Write("Lütfen kullanıcı adını giriniz= ");
            //string kullanici = Convert.ToString(Console.ReadLine());
            //Console.Write("Lütfen şifre giriniz= ");
            //string sifre = Convert.ToString(Console.ReadLine());
            //if(kullanici=="admin"&& sifre=="123456")
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Hata! tekrar deneyiniz");
            //}
            //Console.ReadLine();
            //Not: Sadece şifre hatalı olmasına rağmen & (ve) olduğu için yanlış sonuç verdi.

            //Kullanıcıdan sınav1, sınav2 ve sınav3 notları istenecek. Eper bu üç sınavın ortalaması 49 ve 49 dan küçük ise kötü,
            //Ortalama 50ve 50den büyük ve 65 ve 65 den küçük ise ORTA, Ortalama 66 ve 66 dan büyük veya 79 ve 79 dan küçükse İyi,
            //Ortalama 80 ve 80 den büyükse iyi yazdıran program.
            //Console.Write("1. Sınav notunu giriniz : ");
            //int not1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sınav notunu giriniz : ");
            //int not2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("3. Sınav notunu giriniz : ");
            //int not3 = Convert.ToInt32(Console.ReadLine());
            //int ort = (not1 + not2 + not3) / 3;
            //Console.WriteLine("Not ortalamanız : " + ort);
            //if(ort<=49)
            //{
            //    Console.WriteLine("Kötü");
            //}
            //else if(ort>=50&&ort<=65)
            //{
            //    Console.WriteLine("Orta");
            //}
            //else if(ort>=66&&ort<=79)
            //{
            //    Console.WriteLine("İYİ");
            //}
            //else
            //{
            //    Console.WriteLine("Çok İyi");
            //}
            //Console.ReadLine();

            //Kullanıcıdan karakter istenecek ve karakter a ya eşit değilse tebrikler a girmeniz diyecek, eğer a ya eşitse hata mesajı
            //veren program.

            //Console.Write("Lütfen karakter giriniz= ");
            //char karakter = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("KARAKTER= "+ karakter);  
            //if(karakter!='a')
            //{
            //    Console.WriteLine("Tebrikler a girmediniz");
            //}
            //else
            //{
            //    Console.WriteLine("Hata- a girdiniz");
            //}
            //Console.ReadLine();


            //switch case ile klavyeden girdiğin plakaya göre şehir ismi yazan program.
            //Console.Write("Lütfen plaka giriniz=  ");
            //int plaka = Convert.ToInt32(Console.ReadLine());

            //switch(plaka)
            //{
            //    case 1: Console.Write("Merhaba Adana");
            //        break;
            //    case 24: Console.Write("Merhaba Erzincan");
            //        break;
            //    case 34: Console.Write("Merhaba İstanbul");
            //        break;

            //    default: Console.Write("Şehir plakası girmediniz");
            //        break;       
            //}
            //Console.ReadLine();

            //Kullanıcıdan mevsim istenecek ve girilen mevsime göre ayları yazdıran program.
            //Console.Write("Lütfen mevsim giriniz= ");
            //string mevsim = Convert.ToString(Console.ReadLine());
            //switch(mevsim)
            //{
            //    case "yaz": Console.Write("haziran,temmuz, ağustos ");
            //       break;
            //    case "kış": Console.Write("aralık, ocak,şubat");
            //        break;
            //    case "ilkbahar": Console.Write("mart, nisan, mayıs");
            //        break;
            //    case "sonbahar":Console.Write("eylül ekim kasım");
            //        break;
            //    default: Console.WriteLine("Mevsim hatalı");
            //        break;
            //}
            //Console.ReadLine();

            //Döngü, belirtilen işlemlerin belli şartlar aralığında tekrar tekrar olmasıdır.

            //for döngüsü ile ekrana merhaba dünya yazdırmak

            //for(int i=0;i<100;i++)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //}
            //Console.ReadLine();

            // For döngüsü ile 1 den 10 a kadar olan sayıları yazdıran program.

            //for(int i=0;i<10;i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //for döngüsü ile 1 den 10 a kadar l-olan çift sayıları yazdıran program.

            //for(int i=0;i<10;i=i+2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //24 ün 9 ile bölümünden kalanı yazdıran program.

            //int sayi = 24 % 9;
            //Console.Write(sayi);
            //Console.ReadLine();

            //Klavyeden girilen sayı eğer çift ise çift yazdıran, tek ise tek yazdıran program.

            //Console.Write("Lütfen bir sayı giriniz= ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if(sayi%2==0)
            //{
            //    Console.Write(sayi+ " Sayı çifttir.");
            //}
            //else
            //{
            //    Console.Write(sayi+ " Sayı tektir.");
            //}
            //Console.ReadLine();

            //1 ile 10 arasındaki yalnızca 3 e bölünebilen sayıları yazdıran program.
            //for(int i=1;i<10;i++)
            //{
            //    if(i%3==0)
            //    {
            //        Console.WriteLine("3 e bölünebilen sayılar "+i);
            //    }
            //}
            //Console.ReadLine();

            //1 den klavyeden girilen sayıya kadar olan sayıların tam bölenlerini bulan program.
            //Console.Write("Lütfen bir sayı girin= ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for(int i=1;i<=10;i++)
            //{
            //    if(sayi%i==0)
            //            {
            //        Console.WriteLine(i);
            //            }
            //}
            //Console.ReadLine();

            //1 ile 5 arasındaki tüm sayıların faktöriyelini bulan program.

            //int sayi, faktoriyel = 1;//faktoriyel sürekli çarpılacağı için 1 atanır.

            //Console.Write("Lütfen sayı giriniz= ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //for(int i=1;i<=sayi;i++)
            //{
            //    //5 den 1 e kadar olan bütün sayıları çarpıp ekrana yazdırmak.
            //    faktoriyel = faktoriyel * i;

            //}
            //Console.Write("Faktöriyelinizin sonucu= "+faktoriyel);
            //Console.ReadLine();


            //1 den klavyeden girilecek olan sayıya kadar olan sayının faktörliyelini hesaplayan program.

            //Console.Write("Lütfen sayı girin= ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int faktoriyel = 1;
            //for(int i=1;i<=sayi;i++)
            //{
            //    faktoriyel = faktoriyel * i;
            //    //1*1=1
            //    //2*1=2
            //    //3*1=3
            //    //4/1=4
            //    //5*1=5

            //}
            //Console.Write("Faktoriyel = " + faktoriyel);
            //Console.ReadLine();

            //While döngüsü iken demektir doğru olduğu sürece döngü devam eder.

            //sayaç 10 ve 10 dan küçük olana kadar merhaba dünya yazdıran program.

            //int sayac = 1;
            //while(sayac<=10)
            //{
            //    Console.WriteLine("Merhaba dünya");
            //    sayac++;
            //}
            //Console.WriteLine(sayac);
            //Console.ReadLine();

            //sayı 5 ve 5 ten küçük olan sayıları yazdıran program.
            //int sayi = 1;
            //while(sayi<=5)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //Console.ReadLine();

            //sayı <=5 olana kadar olan sayıları toplayıp ekrana yazdıran program.

            //int sayi = 1,toplam=0;
            //while(sayi<=5)
            //{
            //    toplam = toplam + sayi;
            //    sayi++;
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();


            //sayı 1 den başlasın ve sayı 10 olana kadar yazdırsın. Do while ile.
            //do while döngüsünde döngü illaki bir kez çalışır sonradan kontrol eder.
            //int sayi = 1;
            //do
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //while (sayi <= 10);
            //{
            //    Console.ReadLine();
            //}


            
        }
    }
}
