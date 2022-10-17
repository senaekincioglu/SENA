using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oncekiörneklertrycatchhali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dizi1satir = 0;
            int dizi1sutun = 0;
            bool state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("Lütfen 1.dizinin Satır Sayısını giriniz.");
                    dizi1satir = Convert.ToInt32(Console.ReadLine());


                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen int türünde sayı giriniz.");

                }
            }
            state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("Lütfen 1.dizinin Sütun Sayısını giriniz.");
                    dizi1sutun = Convert.ToInt32(Console.ReadLine());


                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen int türünde sayı giriniz.");

                }
            }
            int[,] dizi = new int[dizi1satir, dizi1sutun];
            state = true;
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {
                    try
                    {
                        Console.WriteLine("Lütfen 1.dizinin {0}x{1} Elemanını giriniz.", (i + 1), (k + 1));
                        dizi[i, k] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Lütfen int türünde sayı giriniz.");
                        k--;
                    }
                }

            }





            int[,] dizi2 = new int[dizi1satir, dizi1sutun];
            int[,] dizi3 = new int[dizi1satir, dizi1sutun];
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {


                    try
                    {
                        Console.WriteLine("Lütfen 2.dizinin {0}x{1} Elemanını giriniz.", (i + 1), (k + 1));
                        dizi2[i, k] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Lütfen int türünde sayı giriniz.");
                        k--;
                    }
                }


            }
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {
                    dizi3[i, k] = dizi[i, k] + dizi2[i, k];
                }

            }
            Console.WriteLine();
            Console.WriteLine("1.Dizi Yazdırılıyor...");
            Console.WriteLine();
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {
                    Console.Write(dizi[i, k] + " ");
                }
                Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("2.Dizi Yazdırılıyor...");
            Console.WriteLine();
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {
                    Console.Write(dizi2[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.Dizi ve 2.Dizinin Toplamı olan 3.Dizi Yazdırılıyor...");
            Console.WriteLine();
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {
                    Console.Write(dizi3[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.dizi1Tanimla();


            Console.ReadLine();
        }
        //*****************************************************

        public void Komisyon()
        {
            double komisyonMiktarı = 0, toplam = 0;


            for (int i = 0; i < 5; i++)
            {
                try
                {

                    Console.WriteLine("lütfen   degeri giriniz");

                    double ürün = Convert.ToDouble(Console.ReadLine());

                    if (ürün < 60)
                    {
                        komisyonMiktarı = ürün / 100 * 3;
                        toplam += komisyonMiktarı;
                    }
                    else if (ürün > 60)
                    {

                        komisyonMiktarı = ürün / 100 * 2;
                        toplam += komisyonMiktarı;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış");
                        i--;
                    }
                    Console.WriteLine("{0} Komisyon : {1} ", i + 1, komisyonMiktarı);
                    toplam += komisyonMiktarı;

                }

                catch (Exception)
                {
                    i--;

                }

                Console.WriteLine(" ");

                Console.WriteLine("Toplam Komisyon : {0}", toplam);

                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            // bir komisyoncusattıgı mallardan fiyatı 60Tl kadar olanlardan yüzde 3 , daha fazla olanlardan ise yüzde 2 komisyon almaktadır.
            //klavyede teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve toplamı yazdıran program kodları

            Program prg = new Program();
            prg.Komisyon();
        }
    }

    //******************************
    static void Main(string[] args)
    {
        // elemanları tam sayı olan bir a dizisinin (20 elemanlı) rastgale sayıları atayan, sonra dizi elemanlarının aritmatik ortalamasın
        //hesaplayan ve elemanlardan kac tanesinin bu elemanlardan küçük ve büyük olduğınu yazın.

        int[] dizi = new int[20];
        Random rnd = new Random();
        int diziToplami = 0, ortalamadanBuyuk = 0, ortalamadanKucuk = 0;
        double diziOrtalamasi = 0;

        try
        {
            for (int i = 0; i < dizi.Length; i++)
            {

                dizi[i] = rnd.Next(1, 50);

                diziToplami += dizi[i]; // diziToplami = diziToplami+ dizi[i];

                Console.WriteLine($"{i + 1}. Sayı :" + dizi[i]);

            }
            Console.WriteLine("Toplam : " + diziToplami);
        }
        catch (Exception)
        {
            Console.WriteLine("Hata");
        }
        diziOrtalamasi = diziToplami / 20;

        foreach (int var in dizi)
        {
            if (var > diziOrtalamasi)
            {
                ortalamadanBuyuk = ortalamadanBuyuk + 1;
            }

            else
            {
                ortalamadanKucuk += 1;
            }

        }
        Console.WriteLine("Ortalama : " + diziOrtalamasi);
        Console.WriteLine("büyük : " + ortalamadanBuyuk);
        Console.WriteLine("küçük : " + ortalamadanKucuk);
        Console.ReadLine();

    }
}
//***
try
{
    Console.WriteLine("Cumle girin");
    string cumle = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Griilen cümle : {0}", cumle);
    Console.Write("şifreli hali : ");
    Console.ReadKey();
    char harf;
    int sayac = 0;

    for (int i = cumle.Length - 1; i >= 0; i--)
    {
        harf = cumle[i];

        if (harf == 'a' || harf == 'A')
        {
            harf = '?';
            sayac++;
        }
        else if (harf == 'e' || harf == 'E')
        {
            harf = '*';
            sayac++;
        }
        else if (harf == 'i' || harf == 'I')
        {
            harf = '=';
            sayac++;
        }
        else if (harf == 'o' || harf == 'Ö')
        {
            harf = '&';
            sayac++;
        }
        else if (i == 0) Console.WriteLine("{0}", harf);

        else Console.Write("{0}", harf);

        Console.WriteLine("Toplam {0} tane harf şifrelendi" + "{1} tanesi şifrelenmedi", sayac, cumle.Length - sayac);
        Console.Write(harf);
    }
            catch (Exception)
{
    Console.WriteLine("Yanlıs giriş");
}
            }
            
            Console.ReadLine();
        }
    }
        }
    }
}
