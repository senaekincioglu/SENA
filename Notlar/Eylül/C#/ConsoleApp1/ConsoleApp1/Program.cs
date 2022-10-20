using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////23.09.2022////////////////////////////////////////////////////

            /*int sayi;
              Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 5)
                Console.WriteLine("Sayı 5ten küçüktür."+sayi);
            else
                Console.WriteLine("Sayı 5ten büyüktür."+Math.Pow(sayi,2));
            Console.ReadLine();*/

            /*int sayi1, sayi2;
            Console.WriteLine("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
                Console.WriteLine("Büyük olan sayı 1.sayıdır."+sayi1);
            else if (sayi1 < sayi2)
            {
                Console.WriteLine("Büyük olan sayı 2.sayıdır." + sayi2);
            }
            else
                Console.WriteLine("Sayılar eşittir.");
            Console.ReadLine();*/
            /*int sayi1, sayi2,sayi3;
            int toplam = 0;
            Console.WriteLine("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü sayıyı giriniz: ");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 < 100)
                 toplam+=sayi1;
            if (sayi2 < 100)
                toplam+=sayi2;
            if (sayi3 < 100) {
                toplam+=sayi3; }

            Console.WriteLine("Sayıların toplamı=" + toplam);
            if (toplam == 0)
                Console.WriteLine("Tüm sayılar 100den büyük");
            Console.ReadLine();*/

            /////////////////////////////////////////////////26.09.2022////////////////////////////////////////////////////

            /*double vize, final, ort;
         giris:
             Console.WriteLine("Vize notunuzu giriniz: ");
             vize = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Final notunuzu giriniz: ");
             final = Convert.ToDouble(Console.ReadLine());
             ort = (vize * 40) / 100 + (final * 60) / 100;
             if (ort >= 85 && ort < 101)
                 Console.WriteLine("Harf notunuz:A"+" Ortalamanız:"+ort);
             else if (ort >= 75 && ort < 85)
                 Console.WriteLine("Harf notunuz:B" + " Ortalamanız:" + ort);
             else if (ort >= 65 && ort < 75)
                 Console.WriteLine("Harf notunuz:C" + " Ortalamanız:" + ort);
             else if (ort >= 50 && ort < 65)
                 Console.WriteLine("Harf notunuz:D" + " Ortalamanız:" + ort);
             else if (ort > 0 && ort < 50)
                 Console.WriteLine("Harf notunuz:F" + " Ortalamanız:" + ort);
             else
             {
                 Console.WriteLine("Yanlış not girdiniz");
                 goto giris;
             }*/
            /*double sayi1, sayi2;
            string islem;
            Console.WriteLine("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
        giris2:
            Console.WriteLine("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
        giris:
            Console.WriteLine("Yapılacak işlem nedir? 1-Topla 2-Çıkar 3-Böl 4-Çarp");
            islem = Console.ReadLine();
            if (islem == "1" || islem == "Topla")
                Console.WriteLine("Sonuç=" + (sayi1 + sayi2));
            else if (islem == "2" || islem == "Çıkar")
                Console.WriteLine("Sonuç=" + (sayi1 - sayi2));
            else if (islem == "3" || islem == "Böl")
            {
                if (sayi2 != 0)
                {

                    Console.WriteLine("Sonuç=" + (sayi1 / sayi2));
                }
                else
                {
                    Console.WriteLine("Sonuç 0 olamaz");
                    goto giris2;
                }
            }
            else if (islem == "4" || islem == "Çarp")
                Console.WriteLine("Sonuç=" + (sayi1 * sayi2));
            else
            {
                Console.Write("Geçersiz işlem seçtiniz.Lütfen geçerli bir işlem giriniz");
                goto giris;
            }
            Console.ReadLine();*/


            /*double sayi, kat;

            Console.WriteLine("Sayı giriniz");
            sayi = Convert.ToDouble(Console.ReadLine());
            if (sayi % 2 == 0)
                Console.WriteLine("Sayı 2'nin katıdır." + sayi);
            else
            {

                if (sayi % 3 == 0)
                    Console.WriteLine("Sayı 3'ün " + (sayi / 3) + " katıdır.");
                else
                    Console.WriteLine("Sayının 3'bölümünden kalan: " + sayi % 3);
            }
            Console.ReadLine();*/
            /*int sayi, kacsayi;
            int psayi = 0;
            int nsayi = 0;
            int ntoplam = 0;
            int ptoplam = 0;
            int a = 1;

            Console.WriteLine("Kaç sayı gireceksiniz: ");
            kacsayi = Convert.ToInt32(Console.ReadLine());
            do
            {
            notr:
                Console.WriteLine(a+".Sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                kacsayi--;

                if (sayi > 0)
                {
                    psayi++;
                    ptoplam += sayi;

                }
                else if (sayi < 0)
                {
                    nsayi++;
                    ntoplam += sayi;
                }
                else
                {
                    Console.WriteLine("0 nötr sayıdır.Yeniden giriniz.");
                    goto notr;
                }
                a++;
            } while (kacsayi > 0);
            Console.WriteLine(psayi + " pozitif sayı var,toplamları: " + ptoplam);
            Console.WriteLine(nsayi + " negatif sayı var,toplamları: " + ntoplam);
            Console.ReadLine();*/
            /* string f;
             Console.WriteLine("Sıcaklığı fahrenheit cinsinden giriniz.");
             f = Console.ReadLine();
             double fa = Convert.ToDouble(f);//stringi double'a çevirme
             double c = (fa - 32) / 1.8;
             c = Math.Round(c, 2);//Sayının kaç virgül sonraya yuvarlanacağı
             Console.WriteLine("Sıcaklık santigirat cindsinden şöyledir." + c);*/

            /////////////////////////////////////////////////27.09.2022////////////////////////////////////////////////////

            /*int fakt = 1;
            Console.WriteLine("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            do
            {
                fakt *= sayi;
                sayi--;
            }
            while (sayi > 1);
            Console.WriteLine("Sayının faktoriyeli:" + fakt);
            Console.ReadLine();*/

            /*int taban, us, sonuc = 1;
            Console.WriteLine("Tabanı giriniz: ");
            taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üssü giriniz: ");
            us = Convert.ToInt32(Console.ReadLine());
            int üs = us;
        sonuc:
            //do
            //{
            sonuc *= taban;
            us--;
            if (us > 0)
                goto sonuc;
            //} while (us > 0);
            Console.WriteLine(taban + " tabanında " + üs + ":" + sonuc);
            Console.ReadLine();*/

            /*double sayi, toplam = 0;
             int gsayi, a = 1;
             Console.WriteLine("Kaç sayı girilecek:");
             gsayi = Convert.ToInt32(Console.ReadLine());
             int asayi = gsayi;
         giris:
             Console.WriteLine(a + ".Sayıyı giriniz:");
             sayi = Convert.ToDouble(Console.ReadLine());
             if (sayi > 0 && sayi < 100)
             {
                 a++;
                 gsayi--;
                 toplam += sayi;
                 if (gsayi > 0)
                     goto giris;
             }
             else
             {
                 Console.WriteLine("Hatalı girdiniz.Lütfen 0-100 arasında bir sayı giriniz");
                 goto giris;
             }
             double sonuc = Math.Round(toplam / asayi, 2);
             Console.WriteLine("Girilen sayıların aritemetik ortalaması:" + sonuc);
             Console.ReadLine();*/

            /*int sayi=1;
            int gsayi;
            Console.WriteLine("Hangi sayıya kadar saysın");
            gsayi = Convert.ToInt32(Console.ReadLine());
            while (sayi >= 1 && sayi <= gsayi)
            {
                Console.WriteLine(sayi);
                sayi++;                
            }
            Console.ReadLine();*/
            /* string secim;
             giris:
             Console.Write("Mesajınızı yazınız.Çıkmak için kapat yazınız: ");
             secim = Console.ReadLine();
             while (secim.ToLower()!= "kapat")
             {
                 Console.WriteLine(secim);
                 goto giris;
             }
             Console.ReadLine();*/

            /*string sayi;
            int toplam = 0, a = 1;
        giris:
            Console.WriteLine("Toplanıcak " + a + ".sayıyı giriniz:");
            sayi = Console.ReadLine();

            while (sayi.ToLower() != "bitir")
            {
                a++;
                int ksayi = Convert.ToInt32(sayi);
                toplam += ksayi;
                Console.WriteLine("Çıkmak için bitir yazınız:");
                goto giris;
            }
            Console.WriteLine((a-1) + " sayının toplamı: " + toplam);
            Console.ReadLine();*/

            /*string sSayi = "34VB5412";
            bool kontrol = false;
            int isayi = 0;
            try
            {
                isayi = Convert.ToInt32(sSayi);
                kontrol = true;
                Console.WriteLine("Metin formatı düzgün.");

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Metin formatı hatalı!Tip dönüşümü yapılamadı.");
            }
            Console.ReadLine();*/

            /*int sayi = 1;
            while (sayi <= 100)
            {
                if (sayi % 2 == 0)
                {
                    if (sayi % 3 == 0)
                    {
                        Console.WriteLine(sayi + " çifttir ve 3'e bölünebilir ve 3'ün " + (sayi / 3) + " katıdır.");
                    }
                    else
                        Console.WriteLine(sayi + " çifttir.");
                }
                else
                {
                    if (sayi % 3 == 0)
                    {
                        Console.WriteLine(sayi + " tektir ve 3'e bölünebilir ve 3'ün " + (sayi / 3) + " katıdır.");
                    }
                    else
                        Console.WriteLine(sayi + " tektir.");
                }
                sayi++;
            }
            Console.ReadLine();*/

            /////////////////////////////////////////////////28.09.2022////////////////////////////////////////////////////

            /*Console.Write("Bir sayı giriniz: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }
            int sayac = 1;
            while (sayac <= i)
            {
                if (sayac == 10)
                    break;
                Console.WriteLine("Hello World! " + sayac);
                sayac++;
            }
            Console.ReadLine();*/

            /*int sayi;
            while (true)
            {
                Console.Write("Sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 5 == 0)
                {
                    Console.WriteLine("BOMM!!");
                }
                if (sayi % 7 == 0)
                    Console.WriteLine("Sayı 7'nin " + (sayi / 7) + " katıdır.");
                if (sayi % 19 == 0)//95 değeri yüzünde if
                {
                    Console.WriteLine("19'un katı girildi.Program sona erdi.");
                    break;
                }
                else
                    Console.WriteLine(sayi);
            }
            Console.ReadLine();*/

            /*int sayi = 1;
            while (sayi <= 10)
            {
                if (sayi == 7)
                {
                    sayi++;
                    continue;
                }
                if (sayi == 9)
                    break;

                Console.WriteLine(sayi);
                sayi++;
            }
            Console.ReadLine();*/


            /*basla:
            try
            {
                Console.WriteLine("Üst sınırı giriniz: ");
                int limit= Convert.ToInt32(Console.ReadLine());

                int sayi = 1;
                while (sayi <= limit)
                {
                    Console.WriteLine("Sayi: " + sayi);
                    sayi++;
                }                
            }
            catch(Exception e)
            {
                Console.WriteLine("Metin formatı hatalı.");
                Console.WriteLine(e.Message);
                goto basla;

            }
            Console.ReadLine();*/

            /*int sayi;
            int a = 1;
            int toplam = 0;
            do
            {

                Console.Write("Toplanıcak " + a + ".sayıyı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                a++;
                toplam += sayi;
            } while (sayi != 0);

            Console.WriteLine((a - 1) + " sayınının toplamı: " + toplam);
            Console.ReadLine();*/

            /*string eposta, sifre;
            bool a = true;
            do

            {
                Console.WriteLine("E-posta adresinizi giriniz:");
                eposta = Console.ReadLine();
            sifre:
                Console.WriteLine("Şifrenizi giriniz:");
                sifre = Console.ReadLine();
                if (eposta == "smart@pro.net")
                {
                    if (sifre == "SP123")
                    {
                        Console.WriteLine("Başarılı giriş");
                        a = false;
                    }
                    else
                    {
                        Console.WriteLine("Şifreniz yanlış lütfen tekrar giriniz");
                        goto sifre;

                    }
                }
                else
                    Console.WriteLine("E-posta adresiniz veya şifreniz yanlış.Lütfen tekrar deneyiniz.");
            } while (a = false);
            Console.ReadLine();*/

            /*for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i + "for döngüsü");
            }
            Console.ReadLine();*/

            /*int i = 1,toplam=0;
            for (i = 1; i <= 10; i++)
            {
                toplam += i;                
            }
            Console.WriteLine(toplam);
            Console.WriteLine("Son gelinen i değeri:" + i);
            Console.ReadLine();*/

            /* int sayi;
             Console.Write("Bir sayı giriniz:");
             sayi = Convert.ToInt32(Console.ReadLine());
             for (int i =1; i <=sayi; i++)
             {
                 if (i % 2 == 0)
                     Console.WriteLine(i);              
             }
             Console.ReadLine();*/
            /*int sayi, i;
            Console.Write("Bir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (i = sayi; i > 0; i--)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();*/


            /*int sayi, sayi2, i, j;
            Console.Write("Birinci sayıyı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi > sayi2)
            {
                for (i = sayi; i >= sayi2; i--)
                {
                    Console.WriteLine(i);

                }
            }
            else
            {
                for (j = sayi2; j >= sayi; j--)
                {
                    Console.WriteLine(j);

                }
            }
            Console.ReadLine();*/

            /*int kfiyat = 0, urun, kurun, a;
            Console.Write("Kaç ürün gireceksiniz:");
            kurun = Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= kurun; a++)
            {
                Console.Write(a + ".ürünün fiyatının giriniz:");
                urun = Convert.ToInt32(Console.ReadLine());
                kfiyat = ((urun * 18) / 100) + urun;
                Console.WriteLine(a + ".ürünün KDV'li fiyatı:" + kfiyat);
            }
            Console.WriteLine("Program sona erdi.");
            Console.ReadLine();*/

            /*int sayi, ptoplam = 0, ntoplam = 0, a = 1, n = 0, p = 0, toplam = 0, t = 0;
            for (; ; )//sonsuz döngü
            {
                Console.Write(a + ".Sayıyı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {
                    if (sayi == 34)
                    {
                        Console.WriteLine("Lütfen 34 veya -34 girmeyiniz");
                        continue;
                    }
                    if (sayi % 3 == 0)
                    {
                        toplam += sayi;
                        t++;
                        a++;
                        ptoplam += sayi;
                        p++;
                    }
                    else
                    {
                        ptoplam += sayi;
                        a++;
                        p++;

                    }
                }
                else if (sayi < 0)
                {
                    if (sayi == -34)
                    {
                        Console.WriteLine("Lütfen 34 veya -34 girmeyiniz");
                        continue;
                    }
                    if (sayi % 3 == 0)
                    {
                        toplam += sayi;
                        t++;
                        a++;
                        ntoplam += sayi;
                        n++;
                    }
                    else
                    {
                        ntoplam += sayi;
                        a++;
                        n++;
                    }
                }
                else
                    break;
            }
            Console.WriteLine(p + " pozitif sayının toplamı:" + ptoplam);
            Console.WriteLine(n + " negatif sayının toplamı:" + ntoplam);
            Console.WriteLine(t + " tane 3'e bölünebilen sayının toplamı:" + toplam);
            Console.ReadLine();*/

            /*string kelime,cumle="";
            for(; ; )
            {
                Console.Write("Kelimeyi giriniz:");
                kelime = Console.ReadLine();
                if (kelime.ToLower() == "bitti")                   
                {
                    Console.WriteLine(cumle);
                    break;
                }
                else
                {
                    cumle+=kelime+"\n";                   
                }
            }
            Console.WriteLine("Program sona erdi");
            Console.ReadLine();*/

            /////////////////////////////////////////////////29.09.2022////////////////////////////////////////////////////

            /*int i, j,toplam=0;
            for (i = 1; i <= 10; i++)s
            {
                int faktoriyel = 1;
                for (j = 1; j <= i; j++)
                {
                    faktoriyel *= j;
                }
                toplam += faktoriyel;
                Console.WriteLine(i+"sayısının faktoriyeli:" +faktoriyel);
            }
            Console.WriteLine("1'den 10'a kadar olan sayıların faktoriyellerinin toplamı:"+toplam);
            Console.ReadLine();*/

            /*int i, j,toplam=0;
            for (i = 1; i <= 10; i++)
            {
                int kare = 0;
                for (j = 1; j <= i; j++)
                {
                    //kare = j * j;
                    kare =Convert.ToInt32(Math.Pow(j,2));
                }
                toplam += kare;
                Console.WriteLine(i+"sayısının karesi:"+kare);
            }
            Console.WriteLine("1'den 10'a kadar olan sayıların kareleri toplamı:"+toplam);
            Console.ReadLine();*/

            /*int[] sayilar = new int[10];
            int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] isimler = new string[12];
            for (int i = 0; i < rakamlar.Length;i++)
            {
                isimler[0] = "Ahmet";
                Console.WriteLine(isimler[0]+" rakamlar dizisinin "+(i+1)+".elamanı:" + rakamlar[i]);               
            }
            foreach(var sehir in rakamlar)
            {
                Console.WriteLine(sehir);
            }
            Console.ReadLine();*/
            /*Console.Write("Kaç isim giriceksiniz:");
            int kac = Convert.ToInt32(Console.ReadLine());
            string[] isimler = new string[kac];
            for(int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine((i + 1) + ". ismi giriniz:");
                isimler[i] = Console.ReadLine();
            }
            //for ile yazdırması
            for (int j = 0; j < isimler.Length; j++)
            {
                Console.WriteLine((j + 1) + ".isim:"+isimler[j]);
            }
            //foreach ile yazdırması
            foreach(var a in isimler)
            {
                int index = Array.IndexOf(isimler, a)+1;
                Console.WriteLine(index + ".isim: " + a);
            }
            Console.ReadLine();*/
            /*int []puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            int index10 = Array.IndexOf(puanlar,10);
            //1.indexten başlayıp ilk 10 değerini bulan
            int index1_10 = Array.IndexOf(puanlar, 10,1);
            Console.WriteLine("Puanlar dizsinde ilk 10 sayısı: "+index10);
            Console.WriteLine("Puanlar dizsinde ilk 10 sayısı: " + index1_10);
            Console.ReadLine();*/

            /*int toplam = 0;
            int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            for (int i = 0; i < puanlar.Length; i++)
            {
                if (puanlar[i] == 10)
                {
                    toplam++;
                    Console.WriteLine(i + ".indexinde 10 vardır");
                }
                Array.Sort(puanlar);//küçükten büyüğe sıralama
                Console.WriteLine(puanlar[i]);
                Array.Reverse(puanlar);//sırayı ters çevirme
                Console.WriteLine(puanlar[i]);
            }
            Console.WriteLine(toplam + " tane 10 vardır");
            Console.ReadLine();*/

            /*object[] karisikdizi = new object[10];
            for(int i = 0; i < karisikdizi.Length; i++)
            {
                Console.WriteLine((i+1)+".değeri giriniz: ");
                karisikdizi[i] = Console.ReadLine();
            }
            foreach(var a in karisikdizi)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();*/
            /*int i, j;
            Random rnd = new Random();
            int[] sayilar = new int[10];
            for (i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 100);
            }
            /*foreach(var a in sayilar)
            {
                Console.WriteLine(a);
            }
            for (j = 0; j < sayilar.Length; j++)
            {
                Console.WriteLine(sayilar[j]);
            }
            Console.ReadLine();*/

            /*int[] dizi1 = { 20, 32, 31, 12, 15, 55, 66, 8, 7, 9,5 };
            int[] dizi2 = new int[15];
            //dizi1.CopyTo(dizi2,2);
            //*Array.Copy(dizi1, 2, dizi2, 4, 5);****
            Array.Copy(dizi1, dizi2, 8);
            Random rnd = new Random();

            for(int i = 0; i < dizi2.Length; i++)
            {
                if (dizi2[i] == 0)
                {
                    dizi2[i] = rnd.Next(0, 100);
                }
            }
            foreach(var item in dizi2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();*/

            /*int[] dizi1 = { 1, 213, 434, 233, 211, 123, 5, 3, 5, 4 };
            int[] dizi2 = new int[10];
            Array.Copy(dizi1, 3, dizi2, 0, 5);
            foreach (var a in dizi2)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();*/

            /*int[] m = new int[10];
            //int[,] matris = new int[5, 5];//5x5lik bir matrix tanımlar
            int[,] matris = new int[5, 10];
            matris[0, 0] = 10;
            matris[0, 4] = 20;
            matris[4, 4] = 30;

            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matris[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/
            /*
             * 2 0 0 0 2
             * 2 0 0 0 2
             * 2 0 0 0 2
             * 2 0 0 0 2
             * 2 0 0 0 2*/
            /*int[,] matris = new int[5, 5];            

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0 || j == 4)
                    {
                        matris[i, j] = 2;
                    }
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*int[,] matris = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i+j==4)
                    {
                        matris[i, j] = 1;
                    }
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*int[,] matris = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i + j == 4|| i == j)
                    {s
                        matris[i, j] = 1;
                    }                   
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/


            /////////////////////////////////////////////////30.09.2022////////////////////////////////////////////////////

            /*string[] isimler = new string[10];
             for (int i = 0; i < isimler.Length; i++)
             {
                 Console.Write((i + 1) + ".ismi giriniz:");
                 isimler[i] = Console.ReadLine();
             }
             int index = 0;
             foreach(var a in isimler)
             {
                 index = Array.IndexOf(isimler,a,index);
                 Console.WriteLine((index+1)+".isim:"+a);
                 index++;
             }
             Console.ReadLine();*/

            /*int i, j;
            Random rnd = new Random();
            int[] sayilar = new int[10];
            for (i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 1000);
            }
            for (j = 0; j < sayilar.Length; j++)
            {
                Console.WriteLine(sayilar[j]);
            }
            Console.ReadLine();*/

            /*int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] dizi2 = { 101, 102, 103, 104, 105, 106, 107, 108, 109,110};
            Array.Copy(dizi1,2, dizi2,4, 5);
            for (int j = 0; j < dizi1.Length; j++)
            {
                Console.WriteLine(dizi2[j]);
            }
            Console.ReadLine();*/

            /*int[,] matrix = new int[2, 4];
            for (int i = 0; i < 2; i++)
            {                
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("["+i + "," + j+"]endeksini giriniz:");
                    matrix[i, j] =Convert.ToInt32(Console.ReadLine());
                }               
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i,j]+" ");                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*int[,] matrix = new int[2, 4];
            for (int i = 0; i < 2; i++)
            {
                int toplam = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]endeksini giriniz:");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    toplam += matrix[i, j];
                }
                matrix[i, 3] = toplam;
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*int[,,] dizi3D = new int[2, 3, 3];
            Random rnd = new Random();
            for (int z = 0; z < 2; z++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        dizi3D[z, i, j] = rnd.Next(1000);
                    }
                }
            }
            for (int z = 0; z < 2; z++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(dizi3D[z, i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("***************************************");
            }
            Console.ReadLine();*/
            ////Liste////
            /*List<int> ilkListem = new List<int>();//Liste;kapasitesi sınırlı değil,otomamtik genişler.
            List<string> sehirler = new List<string>() { "İstanbul","İzmir","Manisa","Siirt","Adana","Bursa","Mersin" };
            sehirler.Add("Sivas");//ekleme
            sehirler.Insert(1,"Kütahya");//araya ekleme
            foreach (var item in sehirler)
            {
                Console.WriteLine(item + " "); 
            }
            Console.WriteLine("*************************************");
            for (int i = 0; i <sehirler.Count; i++)
            {
                Console.WriteLine(sehirler[i] + " ");
            }
            Console.WriteLine("*************************************");
            bool sivasKontrol = sehirler.Contains("Sivas");//kontrol etme
            Console.WriteLine("SivasKontrol:" + sivasKontrol);
            sehirler.Remove("İstanbul");//çıkarma
            sehirler.RemoveAt(2);//belirli indexi çıkarma
            sehirler.Sort();//Alfabetik sıra
            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine(sehirler[i] + " ");
            }
            Console.WriteLine("*************************************");
            sehirler.Clear();//silme
            Console.ReadLine();*/

            /*Random rnd = new Random();
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();
            List<int> l3 = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int sayi = rnd.Next(1, 10);
                l1.Add(sayi);
                sayi = rnd.Next(1, 10);
                l2.Add(sayi);
            }
            Console.Write("Liste 1:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(l1[i] + ",");
            }
            Console.Write("\n" + "Liste 2:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(l2[i] + ",");
            }
            foreach (var a in l1)
            {
                if (l2.Contains(a) == false && l3.Contains(a) == false)
                    l3.Add(a);
            }
            Console.Write("\n" + "Liste 3:");
            foreach (var e in l3)
            {
                Console.Write(e + ",");
            }
            Console.ReadLine();*/

            /*int tahmin, sayi1;
            List<int> sayi = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                sayi1 = rnd.Next(0, 20);
                sayi.Add(sayi1);
            }
            for (int i = 0; i < sayi.Count; i++)
            {
                Console.WriteLine(sayi[i] + " ");
            }
        giris:
            Console.WriteLine("Tahmininizi giriniz: ");
            tahmin = Convert.ToInt32(Console.ReadLine());

            if (sayi.Contains(tahmin))
            {
                Console.WriteLine("Tahmininiz listede var." + sayi.IndexOf(tahmin) + "," + sayi.LastIndexOf(tahmin) + ".indexte bulunuyor.");
            }
            else
            {
                Console.WriteLine("Tahmininiz listede yok.Lütfen tekrar deneyiniz:");
                goto giris;
            }
            Console.ReadLine();*/

            /////////////////////////////////////////////////03.10.2022////////////////////////////////////////////////////

            /*int sayi = 0;
            Random random = new Random();
            List<int> tahminler = new List<int>();
            sayi = random.Next(0, 1000);
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine((i + 1) + ".tahmininizi giriniz");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                tahminler.Add(tahmin);
                if (tahmin == sayi)
                {
                    Console.WriteLine("Tahmininiz doğru,sayi " + tahmin + "'dir");
                    break;
                }
                else if (tahmin > sayi)
                    Console.WriteLine("Sayı tahmininden daha küçük bir sayıdır.");
                else
                    Console.WriteLine("Sayı tahmininden daha büyük bir sayıdır.");
            }
            Console.WriteLine("Tahminleriniz:");
            foreach (var item in tahminler)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();*/

            /*int[] dizi = new int[5];
            dizi[0] = 66;
            dizi.SetValue(67, 0);
            */

            /*string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Adıyaman" };
            int AnkaraIndexi = Array.IndexOf(sehirler, "Ankara");
            Console.WriteLine("Ankara Indexi:"+AnkaraIndexi);
            int AdiyamanIndexi= Array.IndexOf(sehirler, "Adıyaman");
            Console.WriteLine("Adıyaman Indexi:" + AdiyamanIndexi);
            int AdiyamanIndexi2 = Array.IndexOf(sehirler, "Adıyaman", 2);
            Console.WriteLine("Adıyaman Indexi:" + AdiyamanIndexi);*/

            /*int[] dizi1 = { 11, 41, 21, 32, 43, 54, 65,66,77,86 };
            int[] dizi2 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //dizi1.CopyTo(dizi2, 0);
            Array.Copy(dizi1, 5, dizi2, 5, 5);
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }*/

            /*int[,] dizi = new int[2, 3];
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int sayi = rnd.Next(0, 15);
                    dizi[i, j] = sayi;
                    if (dizi[i, j] < 10)
                        Console.Write(dizi[i, j] + "  ");
                    else
                        Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*int[,] dizi = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (((i == j)|| (i + j == 4))&&(j<3))
                        dizi[i, j] = 1;
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*int[,] dizi = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (((i == j) || (i + j == 4)) && (j >=2))
                        dizi[i, j] = 1;
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*int[,] dizi = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 || i == 4 || j == 0 || j == 4)
                        dizi[i, j] = 1;
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*int a = 10;
            Console.WriteLine(a++);//10
            Console.WriteLine(a);//11
            Console.WriteLine(++a);//12
            Console.WriteLine(a--);//12
            Console.WriteLine(--a);//10
            Console.ReadLine();*/

            //Liste Devamı////////
            /*List<string> sehirler = new List<string>() { "İstanbul", "Manisa", "Van", "Mersin", "Gaziantep", "Şanlıurfa", "Van", "Van" };
            int elamansayisi = sehirler.Count;
            Console.WriteLine(elamansayisi);
            int VanSayisi = sehirler.Count(sehir => sehir == "Van");//Şehir diye bir değişken tanımla Vana eşitse countunu al
            Console.WriteLine(VanSayisi);
            sehirler.Remove("İstanbul");
            sehirler.RemoveAt(6);
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
            bool adanaVarMi = sehirler.Contains("Adana");
            Console.WriteLine("Adana var mı:" + adanaVarMi);
            bool mersinVarMi = sehirler.Contains("Mersin");
            Console.WriteLine("Mersin var mı:"+mersinVarMi);
            Console.ReadLine();*/

            /*List<string> isimler = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ".ismi giriniz:");
                string isim = Console.ReadLine();
                isimler.Add(isim);
            }
            isimler.Sort();
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();*/

            /*List<object> karisikListe = new List<object>() { 1, "Veysel Perü", 432, "54232331", true };
            foreach (var item in karisikListe)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();*/

            ////////////////////////////////////////////////METOTLAR/////////////////////////////////////////////////
            //Topla(5, 4);

            //kareAl();

            /*string kelime;
            Console.Write("10 defa yazılacak kelimeyi giriniz:");
            kelime = Console.ReadLine();
            Ekrana10DefaYaz(kelime);*/

            //Console.WriteLine(kdvHesapla(35));
            //Console.WriteLine(kdvHesapla(20, "eğitim"));
            //Console.WriteLine(Math.Round(kdvHesapla(35,"gıda")));

            /*ToplaYaz(10, 90);
            int toplam = toplaDondur(22,66);
            Console.WriteLine("Toplam:" + toplam);
            Console.ReadLine();*/

            /////////////////////////////////////////////////04.10.2022////////////////////////////////////////////////////

            ///////////////////////////////////////////// Personel Uygulaması//////////////////////////////////////////////
            /*long tc = -1;
            string adSoyad = " ";
            string adres = " ";
            string telefon = " ";

            PersonelEkle(7173677834, "Mehmet Demir", "İstanbul ..", "0546......");
            PersonelEkle(7777777777, "Hasan Emir", "İstanbul ..", "0544......");
            PersonelEkle(8888888888, "Ahmet Emin", "İstanbul ..", "0534......");
            PersonelEkle(9999999999, "Kerem Temiz", "İstanbul ..", "0549......");
            PersonelEkle(5655555555, "Kerim Demir", "İstanbul ..", "0539......");
            Console.WriteLine("Yapılacak işlemi seçiniz"+"\n" +"1-Personel Ekle"+"\n"+"2-Personel Ara" + "\n"+"3-Personel Sil" + "\n"+"4-Personel Güncelle " + "\n"+"5-Tüm Personelleri göster");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                for (int i = 0; ; i++)
                {
                    Console.WriteLine("Eklenecek personelin Tcsini giriniz:");
                    tc = Convert.ToInt64(Console.ReadLine());
                    if (tc == 0)
                    {
                        break;
                    }
                    Console.WriteLine("Eklenecek personelin Adı ve soyadını giriniz:");
                    adSoyad = Console.ReadLine();
                    Console.WriteLine("Eklenecek personelin adresini giriniz:");
                    adres = Console.ReadLine();
                    Console.WriteLine("Eklenecek personelin telefon numarasını giriniz:");
                    telefon = Console.ReadLine();
                    PersonelEkle(tc, adSoyad, adres, telefon);
                }
            }
            for (int i = 0; i < Tcler.Count; i++)
            {
                Console.WriteLine("TC:" + Tcler[i]);
                Console.WriteLine("Ad Soyad:" + adSoyadlar[i]);
                Console.WriteLine("Adres:" + adresler[i]);
                Console.WriteLine("Telefon:" + telefonlar[i]);
                Console.WriteLine("-------------------------");
            }
            if (secim == 2)
            {
                string pad = "";
                long ptc = 0;
                Console.WriteLine("Eklenecek personelin Tcsini giriniz:");
                ptc = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Aranıcak personelin adını giriniz:");
                pad = Console.ReadLine();

                string bulunan = PersonelAra(ptc, pad);
                if (bulunan != "")
                    Console.WriteLine("Aradığınız isim personel listesimizde bulunmaktadır.Kişisel bilgileri şunlardır:" + "\n" + bulunan);
                else
                    Console.WriteLine("Aradığınınız isim personel listesinde bulunmamaktadır.");
            }
            if (secim == 3)
            {
                long ptc = 0;
                Console.WriteLine("Silinecek personelin Tcsini giriniz:");
                ptc = Convert.ToInt64(Console.ReadLine());
                PersonelSil(ptc);
            }
            if (secim == 4)
            {
                Console.WriteLine("Güncellenecek personelin Tcsini giriniz:");
                tc = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Güncellenecek personelin Adı ve soyadını giriniz:");
                adSoyad = Console.ReadLine();
                Console.WriteLine("Güncellenecek personelin adresini giriniz:");
                adres = Console.ReadLine();
                Console.WriteLine("Güncellenecek personelin telefon numarasını giriniz:");
                telefon = Console.ReadLine();
                PersonelGuncelle(tc, adSoyad, adres, telefon);
            }
            if (secim == 5)
            {
                foreach (var item in adSoyadlar)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
            Console.ReadLine();*/
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*int bol = Bolum(600, 13);
            double bol2 = Bolum(600D, 13D);
            Console.WriteLine("integer bölüm"+bol);
            Console.WriteLine("double bölüm:"+bol2);
            Console.ReadLine();*/

            /*int faktoriyel = Faktoriyel(5);
            Console.WriteLine(faktoriyel);
            Console.ReadLine();*/

            /*Console.WriteLine("Asallığı kontrol edilecek sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (asalMı(sayi))
                Console.WriteLine("Sayı asaldır");
            else
                Console.WriteLine("Sayı asal değildir");
            Console.ReadLine();*/

            /*int[] gelen = new int[10];
            gelen = Random10();
            int sira = 1;
            foreach (var item in gelen)
            {
                Console.WriteLine(sira+"."+item);
                sira++;
            }
            Console.ReadLine();*/

            /*int[] sayilar = {1,2,3,4,5,6,7,8,9,10};
             int[] sayilar2 = { 1, 2, 3, 0, 5, 0, 7, 8, 0, 10 };
             DiziYaz(sayilar);
             DiziYaz(sayilar2, true);
             DiziYaz(sayilar2, false);
             Random rnd = new Random();
             int[] sayilar3 = new int[20];
             for (int i = 0; i < sayilar.Length; i++)
             {
                 sayilar[i] = rnd.Next(0, 20);
             }
             int[] teksayilar = tSayi(sayilar);
             DiziYaz(teksayilar,false);*/

            /*Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sayıyı giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Büyük olan sayı:" + bkucuk(sayi1, sayi2));
            Console.WriteLine("Büyük olan sayı:" + bkucuk(sayi1, sayi2,sayi3));
            Console.ReadLine();*/

            /////////////////////////////////////////////////05.10.2022////////////////////////////////////////////////////

            /*int besfaktoiyel = Faktoriyel(5);
            Console.WriteLine(besfaktoiyel);
            Console.ReadLine();*/

            /*foreach (var item in sayilar())
            {
                Console.WriteLine(item);
            }*/

            /*foreach (var item in sayiUret())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();*/

            /*List<string> kelimeler = new List<string>() { "Araba" ,"hızla" , "yanımdan" ,"geçti" };
            string s = listToString(kelimeler);
            Console.WriteLine(s);
            Console.ReadLine();*/

            /*Console.WriteLine(hesapMakinesi());
            Console.WriteLine(hesapMakinesi2());
            Console.ReadLine();*/

            /*double[] doubleArray = { 5.0, 4.5, 6.5, 7.9 };
            float[] floatArray = makeFloat(doubleArray);
            foreach (var item in floatArray)
            {
                Console.WriteLine(item);
            }*/

            /*List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
            }
            foreach (var item in ksayilar(sayilar))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();*/

            /*Console.Write("Kaç adet sayi gireceksiniz:");
            int sayac = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[sayac];
            for (int i = 0; i < sayac; i++)
            {
                Console.Write((i+1)+".sayıyı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
            }
            Console.WriteLine(Topla(sayilar));
            Console.WriteLine(Topla(15, 23, 42, 44, 65));
            Console.WriteLine(Topla(15, 23));
            Console.WriteLine(Topla(15, 23, 42));            
            Console.ReadLine();*/

            //PuanTopla("Ahmet", 20, 60, 70, 80, 90);

            //ref kullanırken parametrenin ilk değeri alması zorunludur.
            /*int[] sayiDizisi = new int[8];
            int bes=0;//*************
            kare(ref bes);*/

            /*int sayi = 5;
            Console.WriteLine(degerDegistir(ref sayi));            
            int s2;
            int s3 = degerDegistirOUT(out s2);
            Console.WriteLine("S2:" + s2);
            Console.WriteLine("S3:" + s3);
            Console.ReadLine();*/

            /*Console.WriteLine("En büyük sayi:"+enBuyukSayiBul(1,5,9,12,66,3,4,21,45,7));
            Console.ReadLine();*/

            //Recursive:Kendisini çağıran metotlar:

            /*int ff = Faktoriyel(5);
            Console.WriteLine("ff:"+ff);
            Console.ReadLine();*/
            /////////////////////////////////////////////////06.10.2022////////////////////////////////////////////////////

            /////////////////////////////////////////////////Tarih-Saat///////////////////////////////////////////////////

            /*Console.WriteLine("Min Date Time:"+DateTime.MinValue);
            Console.WriteLine("Max Data Time"+DateTime.MaxValue);
            Console.WriteLine("Şuanki tarih saat:"+DateTime.Now);
            Console.WriteLine("Şuanki tarih:"+DateTime.Today);
            DateTime TarihSaat = new DateTime();
            TarihSaat = DateTime.Now;
            Console.WriteLine("Gün:" + TarihSaat.Day);
            Console.WriteLine("Ay:"+TarihSaat.Month);
            Console.WriteLine("Yıl:"+TarihSaat.Year);
            Console.WriteLine("Tarih::"+TarihSaat.ToShortDateString());//saat kısmını atar.           
            Console.WriteLine("Haftanın kaçıncı günü:"+TarihSaat.DayOfWeek);
            Console.WriteLine("Yılın kaçıncı günü:"+TarihSaat.DayOfYear);
            Console.WriteLine("Günün kaçıncı günü:"+TarihSaat.TimeOfDay);
            Console.WriteLine("Saat:"+TarihSaat.Hour);
            Console.WriteLine("Dakika:"+TarihSaat.Minute);
            Console.WriteLine("Saniye:"+TarihSaat.Second);
            Console.WriteLine("Milisaniye:"+TarihSaat.Millisecond);
            Console.WriteLine();

            long numberOfTicks=TarihSaat.Ticks;
            DateTime myDate = new DateTime(numberOfTicks);
            string test = myDate.ToString("dd.mm.yyyy");
            Console.WriteLine("Test:"+test);
            Console.WriteLine();

            DateTime tarihSaat2 = new DateTime(2002,09,13);
            TimeSpan gecenZaman = TarihSaat - tarihSaat2;
            Console.WriteLine("Doğum günü:" + tarihSaat2.DayOfWeek);

            Console.WriteLine("Geçen zaman:"+gecenZaman.Days);
            double yasi = Convert.ToDouble(gecenZaman.Days) / 365;
            Console.WriteLine("Yaşı:"+yasi);

            Console.WriteLine("Dosya adı:" + DateTime.Now.ToFileTime());

            Console.WriteLine(yasHesapla(2002));
            Console.ReadLine();*/
            //////////////////////////////////////////////////MATH///////////////////////////////////////////////////////

            /*int mutlak = Math.Abs(-7);//Mutlak değer
            Console.WriteLine(mutlak);
            double cos = Math.Cos(45);//Cosinus
            double cos45 = Math.Round(Math.Cos(45),2);
            Console.WriteLine("Cos45:"+cos);
            Console.WriteLine("Cos45(yuvarlanmış):"+cos45);
            Console.WriteLine("Tan45(yuvarlanmış):"+Math.Round(Math.Tan(45), 2));//Tanjant
            Console.WriteLine(Math.Max(45,55));//Maximum değer
            Console.WriteLine(Math.Min(12,23));//Minimum değer
            Console.WriteLine(Math.Pow(2,10));//Üs alma
            Console.WriteLine(Math.Sqrt(25));//Kök alma
            Console.WriteLine(Math.Log(4,2));//Logaritma(önce sayı sonra taban)
            Console.WriteLine(Math.Exp(4));//e üzeri x
            Console.WriteLine(Math.Log10(1000));//1O tabanında Logaritma
            Console.WriteLine();

            double[] numbers = { -1, 0, 0.105, 0.5, 0.789, 1, 4, 6.9, 10, 50, 100, 500, 1000,Double.MaxValue };
            foreach (double item in numbers)
            {
                Console.WriteLine("1O tabanına göre "+item+" sayısının log değeri:"+Math.Log10(item));
            }
            Console.ReadLine();*/

            //////////////////////////////////////////////String Methods/////////////////////////////////////////////////

            /*string birlesim = String.Concat("Smart ", "Pro ", "405Sbaj", 2022);//concat=Yan yana birleştir/yaz.
            Console.WriteLine(birlesim);

            int[] dizi = { 3, 4, 5, 6 };
            Console.WriteLine(String.Concat(dizi));

            string str1 = "aslantepe", str2 = "ASLANTEPE",str3="aslantepe";
            Console.WriteLine(String.Compare(str1,str2));//Compare=Karşılaştırma yapar.Önce büyük harfler gelir.
            Console.WriteLine(String.Compare(str2,str1));//Sözlük karşılaştırması gibi birşey
            Console.WriteLine(String.Compare(str1,0,str2,0,3));//Başlangıç harfi ve kaç harf
            Console.WriteLine(String.Compare(str1,0,str2,0,3,true));//Büyük küçük harf takma durumu
            Console.WriteLine(String.Compare(str1,str3));//Aynı olursa 0 verir

            string metin = "BEŞİKTAŞ";
            Console.WriteLine(metin.IndexOf("Ş"));
            Console.WriteLine(metin.LastIndexOf("Ş"));
            Console.WriteLine(metin.StartsWith("BEŞ"));//Metinin başlangıcı doğru mu yanlış mı
            Console.WriteLine(metin.EndsWith("KTAŞ"));//Metinin sonu doğru mu yanlış mı

            string yazi = "          8TAŞ                ";
            yazi = yazi.Trim(' ');//Boşlukları atar
            Console.WriteLine("Yazı:"+yazi);
            yazi = yazi.Trim('8');//En sağ ve en soldakileri keser
            Console.WriteLine("Yazı:"+yazi);

            char[] dizi2 = { 'Ş', 'H', 'E', 'A','O'};
            yazi = yazi.Trim(dizi2);//yazıdan listedeki karakterleri metnin kenarından çıkarır.
            Console.WriteLine("Yazi:"+yazi);

            string str4 = "Merhaba Dünya";
            Console.WriteLine(str3.PadRight(15,'E'));//Verilen uzunluğa göre sağ tarafa ekler.
            Console.WriteLine(str3.PadLeft(20,'*'));//Verilen uzunluğa göre sol tarafa ekler.

            string youtubeStr = "Https://www.youtube.com/watch?v=tbCiWKLLjBY";
            string[] adres = youtubeStr.Split('=');//yazılan ifadeden itibaren ayırır.
            foreach (var item in adres)
            {
                Console.WriteLine(item);
            }

            string cumle = "Merhaba             arkadaşlar.          Bugün sınav var.";
            string[] kelimeler = cumle.Split(' ');
            string cumle2 = String.Join(" ", kelimeler);
            Console.WriteLine("Cumle2="+cumle2);
            foreach (var item in kelimeler)
            {
                if(item!=""&& item!=" ")
                Console.WriteLine(item);
            }

            Console.WriteLine("Kelime sayısı:" + kelimeSay(cumle));

            string buyuk = "SMARTPRO";
            string kucuk = "smartpro";

            Console.WriteLine(buyuk.ToLower());
            Console.WriteLine(kucuk.ToUpper());

            Console.WriteLine(buyuk.Remove(0,1));//Nerden başlıyacak,kaç karakter silecek         
            Console.WriteLine("buyuk inserted:"+buyuk.Insert(5,"_405_"));
            Console.WriteLine("buyuk replace:"+buyuk.Replace('P','B'));
            buyuk = buyuk.Replace('P', 'B');
            buyuk = buyuk.Replace('O', 'E');
            Console.WriteLine("buyuk replace:"+buyuk);

            buyuk = buyuk.Replace("SMART", "OSMAN");
            Console.WriteLine("buyuk replace:"+buyuk);

            Console.WriteLine("Buyuk(0):"+buyuk[0]);
            Console.WriteLine("buyuk.Length="+buyuk.Length);
            Console.WriteLine("Ters yaz:"+tersYaz(buyuk));
            Console.ReadLine();*/

            /////////////////////////////////////////////////07.10.2022////////////////////////////////////////////////////

            /*for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    Console.Write(j+"x"+i+"="+i*j+"\t");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();*/

            /*for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*for (int i = 20; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*List<string> kitaplar = new List<string>();
            string secim = "";
            bool a = true;
            do
            {
                Console.Write("Kütüphane Menüsü" + "\n" + "1-Görüntüle" + "\n" + "2-Ekle" + "\n" + "3-Sil" + "\n" + "0-Çıkış"+"\n"+ "Yapılacak işlemi seçiniz:");
                secim = Console.ReadLine();                
                switch (secim)
                {
                    case "1":
                        foreach (var item in kitaplar)
                        {
                            Console.WriteLine(item);                            
                        }
                        Console.WriteLine("-----------------------------------");
                        break;
                    case "2":
                        Console.Write("Eklenicek kitap adını yazınız:");
                        string kadı = Console.ReadLine();
                        kitaplar.Add(kadı);
                        Console.WriteLine("-----------------------------------");
                        break;
                    case "3":
                        Console.Write("Silinecek kitap adını yazınız:");
                        string kadı2 = Console.ReadLine();
                        kitaplar.Remove(kadı2);
                        Console.WriteLine("-----------------------------------");
                        break;
                    case "0":
                        Console.WriteLine("Çıkış yapılıyor...");
                        a = false;
                        break;
                    default:
                        Console.WriteLine("Yanlış işlem seçtiniz.Lütfen geçerli bir işlem seçiniz.");
                        Console.WriteLine("-----------------------------------");
                        break;                        
                }
            } while (a);

            Console.ReadLine();*/

            /*Random rnd = new Random();
            List<int> tahminler = new List<int>();
            int sayi = rnd.Next(0, 1000);
            for (int i =1; i <= 15; i++)
            {
                Console.WriteLine(i+".tahmininizi giriniz:");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                tahminler.Add(tahmin);
                if (tahmin < sayi)
                {
                    Console.WriteLine("Tahmininiz sayıdan küçüktür");
                }
                else if (tahmin > sayi)
                {
                    Console.WriteLine("Tahmininiz sayıdan büyüktür");
                }
                else
                {
                    Console.WriteLine("Tahmininiz doğru sayı:" + sayi + "idi");
                    break;
                }
            }
            Console.WriteLine("Tahminleriniz:");
            foreach (var item in tahminler)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();*/

            /*double[] sayilar = {8.5,6.7,9.0};
            double[] kokler =SqrtBul(sayilar);
            foreach (var item in kokler)
            {
                Console.WriteLine(item);
            }*/

            ////////////////////////////////////////////////TRY-CATCH////////////////////////////////////////////////////

            /*int bolunen = 20;
            int bolen = 0;
            try
            {
                int bolum = bolunen / bolen;
                Console.WriteLine(bolum);
            }
            catch (Exception)
            {
                Console.WriteLine("Bir hata ile karşılaşıldı.Ancak program durmadı.Devam ediyor.");
                //throw;//hatayı fırlatıyor
            }
            finally
            {
                Console.WriteLine("Try bloku çalışsada çalışmasada çalışan blok.2 durumda da çalışır");
            }*/

            /*int bolunen = 20;
            int bolen = 0;
            try
            {
                int bolum = bolunen / bolen;
                Console.WriteLine(bolum);
            }
            catch (DivideByZeroException hata)
            {
                Console.WriteLine("0'a bölme hatası!Bölen 0 olamaz"+hata.Message);
            }
            catch(FormatException hata)
            {
                Console.WriteLine("Format Hatası!"+hata.Message);
            }
            catch (IndexOutOfRangeException hata)
            {
                Console.WriteLine("Dizide olmayan elamana ulaşmaya çalıştın"+hata.Message);
            }
            catch(Exception genelhata)
            {
                Console.WriteLine("Bir hata ile karşılaşıldı.Ancak program durmadı.Devam ediyor."+genelhata.Message);
                Console.WriteLine("Bir hata ile karşılaşıldı.Ancak program durmadı.Devam ediyor."+getType().Name);

            }*/



            /////////////////////////////////////////////////10.10.2022////////////////////////////////////////////////////
        }
        ///////////////////////////////////////////////////METOTLAR////////////////////////////////////////////////////

        /////////////////////////////////////////////////03.10.2022////////////////////////////////////////////////////

        /*static int Topla(int s1,int s2)
{
   int toplam = s1 + s2;
   return toplam;
}*/

        /*static void kareAl()
        {
            Console.WriteLine("Karesi alınacak sayıyı giriniz:");
            int s = Convert.ToInt32(Console.ReadLine());
            int kare = s * s;
            Console.WriteLine("Sayının karesi:"+kare);
            Console.ReadLine();
        }*/

        /*public static void Ekrana10DefaYaz(string kelime)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(kelime);
            }
            Console.ReadLine();
        }*/

        /*private static double kdvHesapla(double fiyat)
        {
            return fiyat * 1.18;
        }*/

        /*private static double kdvHesapla(double fiyat, string secim)
        {
            if (secim == "gıda")
                return fiyat * 1.18;
            else if (secim == "eğitim")
                return fiyat * 1.05;
            else
                return fiyat * 1.18;
        }*/

        /*static void ToplaYaz(int v1,int v2)
        {
            Console.WriteLine("Toplam ="+(v1+v2));
        }*/

        /*static int toplaDondur(int v1,int v2)
        {
            return v1 + v2;
        }*/

        /////////////////////////////////////////////////04.10.2022////////////////////////////////////////////////////

        ///////////////////////////////////////////// Personel Uygulaması//////////////////////////////////////////////

        /*static List<long> Tcler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();

        static void PersonelEkle(long tc, string adSoyad = "", string adres = " ", string telefon = " ")
        {
            if (tc != 0)
            {
                Tcler.Add(tc);
                adSoyadlar.Add(adSoyad);
                adresler.Add(adres);
                telefonlar.Add(telefon);
            }
        }

        static string PersonelAra(long tc = 0, string adSoyad = "")
        {
            string personel = "";
            int personelIndex = -1;//listede -1 olmayacağı için,-1 bulunmadığı anlamına gelir.
            if (adSoyad != "")
            {
                if (adSoyadlar.Contains(adSoyad) == true)
                {
                    personelIndex = adSoyadlar.IndexOf(adSoyad);
                }
            }
            else if (tc != 0)
            {
                if (Tcler.Contains(tc) == true)
                {
                    personelIndex = Tcler.IndexOf(tc);
                }
            }
            if (personelIndex != -1)
            {
                personel = Convert.ToString(Tcler[personelIndex]) + " " + adSoyadlar[personelIndex] + " " +
                adresler[personelIndex] + " " + telefonlar[personelIndex];
            }
            return personel;
        }
        static void PersonelSil(long tc = 0)
        {
            int personelIndex = -1;
            if (tc != 0)
            {
                if (Tcler.Contains(tc) == true)
                {
                    personelIndex = Tcler.IndexOf(tc);
                    Tcler.Remove(personelIndex);
                }
            }
            if (personelIndex != -1)
            {
                Tcler.RemoveAt(personelIndex);
                adresler.RemoveAt(personelIndex);
                adSoyadlar.RemoveAt(personelIndex);
                telefonlar.RemoveAt(personelIndex);
            }
        }

        static void PersonelGuncelle(long tc, string AdSoyad, string adres, string telefon)
        {
            if (tc != 0)
            {
                int personelIndex = Tcler.IndexOf(tc);
                if (personelIndex != -1)
                {
                    PersonelAra(tc);
                    adSoyadlar[personelIndex] = AdSoyad;
                    adresler[personelIndex] = adres;
                    telefonlar[personelIndex] = telefon;
                }
            }
        }*/

        /*static int sayiGir()
        {
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;
        }
        static int Bolum(int sayi1,int sayi2)
        {
            return sayi1 / sayi2;
        }
        static double Bolum(double sayi1, double sayi2)
        {
            return Math.Round(sayi1 / sayi2);
        }*/

        /*static int Faktoriyel(int sayi)
        {
            int carpim = 1;
            for (int i = 1; i <= sayi; i++)
            {
                carpim*= i;
            }
            return carpim;
        }*/

        /*static bool asalMı(int sayi)
        {
            int kontrol=0;
            for (int i = 1; i <=sayi; i++)
            {
                if(sayi%i==0)
                kontrol++;
            }
            if (kontrol == 2)
            {
                return true;
            }
            else
                return false;
        }*/

        /*static int[] Random10()
        {
            int[] sayiDizisi = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                sayiDizisi[i] = rnd.Next(0, 10);
            }
            return sayiDizisi;
        }*/

        /*static void DiziYaz(int[] sayilar)
        {
            int toplam = 0;
            int kare = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
                toplam += sayilar[i];
                kare += Convert.ToInt32(Math.Pow(sayilar[i], 2));
            }
            Console.WriteLine("Dizideki sayıların toplamı:" + toplam);
            Console.WriteLine("Dizideki sayıların kareleri toplamı:" + kare);
            Console.ReadLine();
        }
        static void DiziYaz(int[] sayilar, bool SifirlarıGoster)
        {
            if (SifirlarıGoster)
            {
                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
            else
                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (sayilar[i] != 0)
                        Console.WriteLine(sayilar[i]);
                }
            Console.ReadLine();
        }

        static int[] tSayi(int[]sayilar)
        {
            int[] tsayilar = new int[20];
            for (int i = 0; i < sayilar.Length; i++)
            {
                
                if (sayilar[i] % 2 == 1)                                 
                    tsayilar[i] = sayilar[i];                              
            }
            return tsayilar;
        }*/

        /*static int bkucuk(int sayi1, int sayi2)
        {
            if (sayi1 < sayi2)
                return sayi2;
            else if (sayi2 < sayi1)
                return sayi1;
            else
                return sayi1 = sayi2;
        }
        static int bkucuk(int sayi1, int sayi2, int sayi3)
        {
            return bkucuk(bkucuk(sayi1, sayi2), sayi3);
        }*/

        /////////////////////////////////////////////////05.10.2022////////////////////////////////////////////////////

        /*static int Faktoriyel(int f)
        {
            int carpim = 1;
            for (int i = 1; i <= f; i++)
            {
                carpim*= i;
            }
            return carpim;
        }*/

        /*static List<int> sayilar()
        {
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
            }
            Console.ReadLine();
            return sayilar;
        }*/

        /*static List<int> sayiUret()
        {
            List<int> sayilar = new List<int>();
            int enKucuk, enBuyuk, sayiAdeti;
              Random rnd = new Random();
            Console.Write("En küçük sayıyı giriniz:");
            enKucuk = Convert.ToInt32(Console.ReadLine());
            Console.Write("En büyük sayıyı giriniz:");
            enBuyuk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Alınacak rastgele sayı adetini giriniz:");
            sayiAdeti = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayiAdeti; i++)
            {
                sayilar.Add(rnd.Next(enKucuk, enBuyuk));
            }
            return sayilar;
        }*/

        /*static string listToString(List<string> kelimeler)
        {
            string k = " ";
            for (int i = 0; i < kelimeler.Count; i++)
            {
                k += kelimeler[i] + " ";
            }
            return k;
        }*/

        /*static double hesapMakinesi()
        {
            double sayi1;
            double sayi2;
            string secim;
            Console.WriteLine("1.sayıyı giriniz:");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());
        giris:
            Console.WriteLine("Yapıcağınız işlemi seçiniz:+,-,/,*(Çıkmak inin çıkış yazınız");
            secim = Console.ReadLine();

            if (secim == "+")
                return (sayi1 + sayi2);
            else if (secim == "-")
                return (sayi1 - sayi2);
            else if (secim == "/")
                return (sayi1 / sayi2);
            else if (secim == "*")
                return (sayi1 * sayi2);
            else if (secim == "çıkış")
                return 0;
            else
            {
                Console.WriteLine("Yanlış işlem seçtiniz lütfen tekrar deneyiniz");
                goto giris;
            }
        }
        static double hesapMakinesi2()
        {
            double sayi1,sonuc;
            double sayi2;
            string secim;
            Console.WriteLine("1.sayıyı giriniz:");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            giris:
            Console.WriteLine("Yapıcağınız işlemi seçiniz:+,-,/,*(Çıkmak inin çıkış yazınız");
            secim = Console.ReadLine();
            switch (secim)
            {
                case "+":
                    sonuc= sayi1 + sayi2;break;
                case "-":
                    sonuc= sayi1 - sayi2;break;
                case "/":
                case "%":
                    if (sayi2 == 0)
                    {
                        sonuc = -1;
                        Console.WriteLine("0'a bölüm olmaz");
                    }
                    else
                    sonuc= sayi1 / sayi2;break;
                case "*":
                    sonuc= sayi1 * sayi2;break;
                case "çıkış":
                    sonuc=0;
                    break;
                default:
                    Console.WriteLine("Yanlış işlem seçtiniz lütfen tekrar deneyiniz");
                    goto giris;
            }
            return sonuc;
        }*/

        /*static float[] makeFloat(double[] doubleArray)
        {
            float[] floatArray = new float[doubleArray.Length];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                floatArray[i] = (float)doubleArray[i];
            }
            return floatArray;
        }*/

        /*static List<int> ksayilar(List<int> sayilar)
        {
            List<int> ksayilar = new List<int>();
            for (int i = 0; i < sayilar.Count; i++)
            {              
                ksayilar.Add(Convert.ToInt32(Math.Pow(sayilar[i],2)));
            }
            return ksayilar;
        }*/

        /*static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            return toplam;
        }*/

        /*static void PuanTopla(string isim,int yas, params int[] puan)
        {
            int toplam = 0;
            foreach (var item in puan)
            {
                toplam += item;
            }
            Console.WriteLine(isim+" adlı "+yas+" yaşındaki öğrencinin notları toplamı:"+toplam);
            Console.ReadLine();
        }*/

        /*static int kare(ref int sayi)
        {
            return sayi * sayi;
        }*/

        /*static int degerDegistir(ref int sayi)
        {
            sayi = sayi * 10;
            return sayi;
        }
        static int degerDegistirOUT(out int sayi)
        {
            sayi = 20;
            return sayi+100;
        }*/

        /*static int enBuyukSayiBul(params int[] sayilar)
        {
            int bsayi = -1;
            foreach (var item in sayilar)
            {
                if (item > bsayi)
                {
                    bsayi =item;
                }
            }
            return bsayi;
            }*/

        /*static int Faktoriyel(int f)
        {
            if (f <= 1)
                return 1;
            else
                return f * Faktoriyel(f-1);
        }*/

        /////////////////////////////////////////////////06.10.2022////////////////////////////////////////////////////

        /*static int yasHesapla(int dyılı)
        {
            int yas = 0;
            DateTime yıl = new DateTime();
            yıl = DateTime.Now;
            yas = yıl.Year - dyılı;
            return yas;
        }*/

        /*static int kelimeSay(string cumle)
        {
            int toplamKelime = 0;
            string[] kelimeler = cumle.Split(' ');
            //return kelimeler.Length;
            foreach (var item in kelimeler)
            {
                if (item != " " && item != "")
                    toplamKelime++;
            }
            return toplamKelime;
        }

        static string tersYaz(string buyuk)
        {
            string ters = " ";
            for (int i = buyuk.Length-1; i >=0 ; i--)
            {
                ters = ters + buyuk[i];
            }
            return ters;
        }*/

        /////////////////////////////////////////////////07.10.2022////////////////////////////////////////////////////

        /*static double[] SqrtBul(double[] sayilar)
        {
            double[] kokler = new double[sayilar.Length];
            for (int i = 0; i < sayilar.Length; i++)
            {
                kokler[i] = Math.Sqrt(sayilar[i]);
            }
            return kokler;
        }*/

        /////////////////////////////////////////////////10.10.2022////////////////////////////////////////////////////
    }
}

