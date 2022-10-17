using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_elseif_swichcase_pozitifnegatifsayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if(sayi%2==0)
            //{
            //    Console.WriteLine("{0}Çift sayıdır"+sayi);//{0} kısmı indexi verir
            //}
            //else
            //{
            //    Console.WriteLine("{0} Sayı tektir"+sayi);
            //}

            //klaveyeden giirlenin nefatfi pozitif mi olduğu
            //ab://goto dur sen ekranı kapatmadan devam eder
            //    int sayii = Convert.ToInt32(Console.ReadLine());

            //    if(sayii<0)
            //    {
            //        Console.WriteLine("SAYI NEGATİF");
            //    }
            //    else

            //    {
            //        Console.WriteLine("sayı pozifir");

            //    }

            //    goto ab;//goto dur sen ekranı kapatmadan devam eder


            ////klavyeden girilen karenin alan ve çevresini hesaplayın
            //int kenar,alan, cevre;
            //Console.WriteLine("Kenar sayısı girin");
            //kenar = Convert.ToInt32(Console.ReadLine());
            //alan = kenar * kenar;
            //Console.WriteLine("karenin alanı= " + alan);

            //cevre = kenar * 4;
            //Console.WriteLine("karenin çevresi= "+cevre);
            //Console.ReadLine();

            //klavyeden girilen dikdörtgenin alanı ve çevresi

            //int alan, cevre,kenar1,kenar2;
            //Console.Write("1. kenarı giriniz");
            //kenar1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. kenarı giriniz");
            //kenar2 = Convert.ToInt32(Console.ReadLine());
            //alan = kenar1 * kenar2;
            //Console.WriteLine("dikdortgenin alanı= " + alan);
            //cevre = (kenar1 + kenar2 )* 2;
            //Console.WriteLine("dikdortgenin cevresi= " + cevre);
            //Console.ReadLine();


            //bir manav bölümünde satılan elma armut ve muz( elma=3, armut=5, muz=7 tl)
            // kg fiyatlarına göre müşterinin üründen ne kadar almak istediğini sorup
            // ödeyeceği ücretin hesaplanması 


            // int elmakg = 3, armutkg = 5, muzkg = 7, tutar,kg;
            // string ürün;
            // Console.Write("Hangi üründen alacaksınız ");
            // ürün = Convert.ToString(Console.ReadLine());
            // Console.WriteLine("Kaç kg alacaksınız ");
            // kg = Convert.ToInt32(Console.ReadLine());

            // if(ürün=="elma")
            // {
            //     Console.WriteLine(tutar= elmakg * kg);
            // }
            // else if(ürün=="armut")
            // {
            //     Console.WriteLine(tutar= elmakg * kg);
            // }
            //else
            // {
            //     Console.WriteLine(tutar= elmakg * kg);
            // }


            // Console.ReadLine();

            //ödev seçilen ürün kg si 0 ile 50 arasında ise %10 indirim uygula
            //50 ile 100 arasında ise %15 indirim
            //100 üstüyse%%20 indirim


            //Console.Write("Ne alırsınız = ");
            //int elma = 3, armut = 5, muz = 7;
            //string secim = Convert.ToString(Console.ReadLine());
            //Console.Write("Kaç kilo = ");
            //int kilo = Convert.ToInt32(Console.ReadLine());
            //if(secim=="elma")
            //{
            //    Console.Write("Toplam fiyat= " + elma * kilo);
            //}

            //else if(secim=="armut")
            //{
            //    Console.Write("Toplam fiyat= " + armut * kilo);
            //}
            //else
            //{
            //    Console.Write("Toplam fiyat= " + muz * kilo);
            //}
            //Console.ReadLine();




            //1.sınav % 30 2.sınav % 50 ve projenin % 20 not ortalamasını hesaplayan program
            //0 ile 50 arası kaldı 50 ile 70 ise geçti 70 ile 100 arası ise çok iyi
            //1.sınav 100 üzerinde olamaz
            //   ab:
            //   Console.Write("1. notu giriniz= ");
            //   int sınav1 = Convert.ToInt32(Console.ReadLine());
            //   Console.Write("2. notu giriniz= ");
            //   int sınav2 = Convert.ToInt32(Console.ReadLine());
            //   Console.Write("proje notunu giriniz= ");
            //   int proje = Convert.ToInt32(Console.ReadLine());
            //   int ortalama, not;
            //   not = (sınav1 * 30) / 100 + (sınav2 * 50) / 100 + (proje * 20) / 100;
            //   ortalama = (sınav1 + sınav2 + proje) / 3;
            //   if(sınav1<0||sınav2<0||proje<0&&sınav1>100||sınav2>100&proje>100)
            //   {
            //       Console.WriteLine("Geçersiz not");
            //   }
            //else   if (sınav1 >= 0 && sınav2 >= 0 && proje >= 0)
            //       if (ortalama < 50)
            //       {
            //           Console.WriteLine("Notunuz= " + not);
            //           Console.WriteLine("Kaldı");
            //       }
            //       else if (ortalama == 50 || ortalama == 70)
            //       {
            //           Console.WriteLine("Notunuz= " + not);
            //           Console.WriteLine("geçti");
            //       }
            //       else
            //       {
            //           Console.WriteLine("Notunuz= " + not);
            //           Console.WriteLine("iyi");
            //       }
            //   Console.ReadLine();
            //   goto ab;



            //yaz girince yaz ayları yazdıran,kış girdiğinde kış aylarını yazdıran program.
            //ab:
            //string ay;
            //Console.Write("Mevsim giriniz= ");
            //ay = Convert.ToString(Console.ReadLine());
            //string yaz, kis, ilkbahar, sonbahar;
            //if(ay=="ilkbahar")
            //{
            //    Console.WriteLine("MART, NİSAN,MAYIS");

            //}
            //else if(ay=="yaz")
            //{
            //    Console.WriteLine("haziran, temmuz,ağustos");
            //}
            //else if (ay == "sonbahar")
            //{
            //    Console.WriteLine("eylül, ekim,kasım");
            //}
            //else if(ay== "kis")
            //{
            //    Console.WriteLine("aralık, ocak, şubat");
            //}
            //else
            //{
            //    Console.WriteLine("yanlış girdiniz");
            //}
            //Console.ReadLine();

            //goto ab;


            //swich case:koşuldur karışılaştırma sadece eşitlikten ibarettir.

            //string deger = Convert.ToString(Console.ReadLine());
            //switch(deger)
            //{
            //        case "sena":
            //        Console.WriteLine("Hoşgeldin sena");
            //        break;//olayı bitirir
            //    case "beyza":
            //        Console.WriteLine("Hoşgeldin beyza");
            //        break;
            //    case "şeyma":
            //        Console.WriteLine("Hoşgeldin şeyma");
            //        break;
            //    case "elif":
            //        Console.WriteLine("Hoşgeldin elif");
            //        break;

            //    default://Bunlardan hiçbiri değilse demek
            //        Console.WriteLine("hatalı isim");
            //        break;


            //}
            //Console.ReadLine();//break ile bitirdiği için parantez dışına yaz

            //Girilen mevsime göre swich case ile yazan program
            //ab:
            //Console.Write("mevsim girin");
            //string mevsim = Convert.ToString(Console.ReadLine());
            //switch(mevsim)
            //{
            //    case "ilkbahar":
            //    Console.WriteLine("mart, nisan mayıs");
            //    break;
            //    case "yaz":
            //        Console.WriteLine("haziran temmuz ağustos");
            //        break;
            //    case "sonbahar":
            //        Console.WriteLine("eylül ekim kasım");
            //        break;
            //    case "kış":
            //        Console.WriteLine("aralık ocak şubat");
            //        break;

            //    default:
            //        Console.WriteLine("Yanlış girdiniz");
            //        break;

            //}
            //goto ab;
            //Console.ReadLine();



            //haftanın günlerini yazan program ilk gün girildiğinde pazartesi gibi
            //ab:
            //int gun;
            //Console.Write("Gün giriniz= ");
            //gun = Convert.ToInt32(Console.ReadLine());
            //switch(gun)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;

            //    default:
            //        Console.WriteLine("Böyle bir gün sayısı yoktur");
            //        break;

            //}
            //Console.ReadLine();
            //goto ab;


            // swich case ile 4 işlem girilen iki sayının çarpımı toplamı bölümü farkı
            //int islem;

            //Console.Write("Lütfen Birinci Sayıyı Girin= ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen İkinci Sayıyı Girin= ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen seçim yapınız= ");
            //Console.WriteLine("+,-,*,/");
            //string secim = Convert.ToString(Console.ReadLine());


            //switch(secim)
            //{
            //    case "+":
            //        islem = sayi1 + sayi2;
            //        Console.Write("toplam=", islem);
            //        break;
            //    case "-":
            //        islem = sayi1 - sayi2;
            //        Console.Write("toplam" + islem);
            //        break;
            //    case "*":
            //        islem = sayi1 * sayi2;
            //        Console.Write("toplam" + islem);
            //        break;
            //    case "/":
            //        islem = sayi1 / sayi2;
            //        Console.Write("toplam" + islem);
            //        break;


            //    default:
            //        Console.Write("Hatalı girdiniz");
            //        break;


            //}
            //Console.ReadLine();





        }
    }
}
