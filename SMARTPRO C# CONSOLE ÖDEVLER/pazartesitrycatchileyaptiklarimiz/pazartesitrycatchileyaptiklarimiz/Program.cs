using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazartesitrycatchileyaptiklarimiz
{
    internal class Program
    {
        public void Bina()

        {
            // 4 katli bir binanin her katinda 3 daire var. Klavyede her dairede bulunan kişi sayısını girdikten sonra binada kaç kişi olduğunu hesaplayın.

            int[,] dizi = new int[4, 3];
            int toplam = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    try
                    {
                        Console.WriteLine($"{i + 1}. katın {j + 1}. dairesinde kaç kişi oturuyor?");
                        dizi[i, j] = Convert.ToInt16(Console.ReadLine());
                        toplam += dizi[i, j];
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("HATA");
                        j--;
                    }
                }
            }

            Console.WriteLine($"\nBinada toplam {toplam} kişi yaşamaktadır.");

            Console.Read();
        }
        public void BinaGetLengthOlan()
        {
            int[,] dizi = new int[4, 3];
            int toplamKisi = 0; int evdeKisi = 0;

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    try
                    {
                        Console.WriteLine($"{i + 1}. Kat {j + 1} Dairedeki kişi sayısını giriniz: ");
                        evdeKisi = Convert.ToInt16(Console.ReadLine());
                        toplamKisi += evdeKisi;
                    }
                    catch (Exception)
                    {
                        j--;
                        Console.WriteLine("HATA");
                    }

                }
            }

            Console.WriteLine($"Toplam kişi sayısı {toplamKisi}");
            Console.ReadLine();
        }
        public void Aritmetik()
        {
            // Elemanları tam sayı olan bir A dizisinin (20 elemanlı) rastgele sayıları atayan sonra dizi elemanlarının aritmetik ortalamasını hesaplayan ve elemanlardan kaç tanesinin bu ortalamadan büyük ve küçük olduğunu sayan programın kodunu yazın

            int[] dizi = new int[20];

            double toplam = 0;
            double aritmetik = 0;
            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 100);
                Console.WriteLine($"{i + 1}-> " + dizi[i]);
                toplam += dizi[i];
                aritmetik = toplam / dizi.Length;
            }

            Console.WriteLine("\nSayıların toplamı = " + toplam);
            Console.WriteLine("\nSayıların aritmetik ortalaması = " + aritmetik);

            Console.WriteLine("\nAritmetik ortalamadan büyük olan sayılar:");

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > aritmetik)
                {
                    Console.Write(dizi[i] + " ");
                }
            }
            Console.WriteLine("\nAritmetik ortalamadan küçük olan sayılar:");

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < aritmetik)
                {
                    Console.Write(dizi[i] + " ");
                }
            }

            Console.Read();
        }
        public void Komisyon()
        {
            #region benim yaptigim           


            double[] urunler = new double[5];

            for (int i = 0; i < urunler.Length; i++)
            {
                try
                {
                    Console.WriteLine($"{i + 1}. ürünün fiyatını giriniz:");
                    urunler[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SADECE SAYI GİR");
                    i--;
                }
            }

            for (int i = 0; i < urunler.Length; i++)
            {
                double komisyon = urunler[i] * 0.03;
                double komisyon2 = urunler[i] * 0.02;

                if (urunler[i] < 60)
                {
                    Console.WriteLine($"{i + 1}. ürünün komisyonu = {komisyon}");
                    komisyon += komisyon;
                }
                else if (urunler[i] >= 60)
                {
                    Console.WriteLine($"{i + 1}. ürünün komisyonu = {komisyon2}");
                    komisyon2 += komisyon2;

                    if (i == 4)
                    {
                        double total = komisyon + komisyon2;
                        Console.WriteLine($"Toplam komisyon = {total}");
                    }
                }

            }
            Console.ReadLine();

            #endregion

            #region hocanin yaptigi
            /*

            double malFiyati = 0, komisyonMiktari = 0, toplamKomisyon = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} Malin Fiyatini Giriniz: ", i + 1);
                malFiyati = Convert.ToDouble(Console.ReadLine());
                if (malFiyati > 60)
                {
                    komisyonMiktari = malFiyati * 0.02;
                }
                else
                {
                    komisyonMiktari = malFiyati * 0.03;
                }
                Console.WriteLine("{0} Mal için kom: {1}", i + 1, komisyonMiktari);
                toplamKomisyon += komisyonMiktari;
                Console.WriteLine("Toplam : {0}",toplamKomisyon);

                Console.ReadLine();
                
            }
            */
            #endregion

            #region hocanin yaptigi try catchli hali
            /*
            double malFiyati = 0, komisyonMiktari = 0, toplamKomisyon = 0;
            
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("{0} Malin Fiyatini Giriniz: ", i + 1);
                    malFiyati = Convert.ToDouble(Console.ReadLine());
                    if (malFiyati > 60)
                    {
                        komisyonMiktari = malFiyati * 0.02;
                    }
                    else
                    {
                        komisyonMiktari = malFiyati * 0.03;
                    }
                    Console.WriteLine("{0} Mal için kom: {1}", i + 1, komisyonMiktari);
                    toplamKomisyon += komisyonMiktari;
                }
                catch (Exception)
                {
                    i--;
                }
                Console.WriteLine("Toplam : {0}",toplamKomisyon);
                
            }
            Console.ReadLine();
            */
            #endregion

        }
        public void KlavyedenTerse()
        {
            try
            {
                Console.WriteLine("cumle yaz:");
                string cumle = Convert.ToString(Console.ReadLine());

                for (int i = 1; i < cumle.Length + 1; i++)
                {
                    Console.Write(cumle[cumle.Length - i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("HATA");
            }

            Console.ReadLine();

        }
        public void Mlxg()
        {
            // klavyede girilen bi cümleyi yazdırın. Kullanıcı bu cümleyi girdikten sonra enter tuşuna bastığı zaman ilk önce cümleyi yazdıracak daha sonra ise cümle tersten şifreli olarak ekrana yazdırılacaktır. A yerine "?" e yerine "*" ı veya i yerine "=". Cumlede kac karakter sifrelenmis, kac karakter normal kullanılmıs bu da yazılacak.

            Console.WriteLine("CUMLE GIR");

            string cumle = Convert.ToString(Console.ReadLine());
            int sayac = 0;
            int sayac2 = 0;

            for (int i = cumle.Length - 1; i >= 0; i--)
            {
                if (cumle[i] == 'a' || cumle[i] == 'A')
                {
                    Console.Write("?");
                    sayac++;
                }
                else if (cumle[i] == 'e' || cumle[i] == 'E')
                {
                    Console.Write("*");
                    sayac++;
                }
                else if (cumle[i] == 'ı' || cumle[i] == 'i' || cumle[i] == 'I' || cumle[i] == 'İ')
                {
                    Console.Write("=");
                    sayac++;
                }
                else
                {
                    Console.Write(cumle[i]);
                    sayac2++;
                }
            }
            Console.WriteLine($"\nToplam {sayac} adet harf şifrelenmiştir.\n{sayac2} adet harf aynı kalmıştır.");
            Console.ReadLine();
        }
        public void DızıdeIndexOrnekleri()
        {
            //int[] sayi = new int[] { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(Array.IndexOf(sayi,5,0,5));
            //Console.ReadLine();

            Console.WriteLine("aramak istedigin seyi gir");
            Array isimler = new[] { "Neval", "İlker", "Bedirhan", "Burak", "Mert1", "Mert2", "Erhan" };

            int index = 0;

            try
            {
                index = Array.IndexOf(isimler, Convert.ToString(Console.ReadLine()));
            }
            catch (Exception)
            {

                Console.WriteLine("HATA");
            }

            if (index != -1)
            {
                Console.WriteLine("var " + index);
            }
            else
            {
                Console.WriteLine("yok");
            }


            Console.ReadLine();
        }
        public void SayisalLoto()
        {
            Console.WriteLine("SAYISAL LOTO");

            int[] numaralar = new int[6];

            int sayi;
            int i = 0;
            Random rnd = new Random();

            while (i < 6)
            {
                sayi = rnd.Next(1, 49);
                if (Array.IndexOf(numaralar, sayi) == -1)
                {
                    numaralar[i] = sayi;
                    i++;
                }
            }
            Array.Sort(numaralar);
            foreach (var item in numaralar)
            {
                Console.WriteLine(item + " ");
            }

            Console.Read();
        }
        static void Main(string[] args)
        {
            Program bn = new Program();
            bn.SayisalLoto();
        }
    }
}
