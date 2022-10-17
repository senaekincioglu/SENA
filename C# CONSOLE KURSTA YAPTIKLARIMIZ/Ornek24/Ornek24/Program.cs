using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.

            #region OtoparkHesabı
            double odenecekTutar = 0;
            int kalinanSure = 0, aracTipi = 0;
            Console.WriteLine("Araç Tipleri Taksi : 1, Minübüs : 2, Ticari : 3");
            Console.Write("Lütfen Araç Tipini Giriniz : ");
            aracTipi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kalınan Süreyi Giriniz : ");
            kalinanSure = Convert.ToInt32(Console.ReadLine());
            if (kalinanSure > 1)
            {
                for (int i = 1; i <= kalinanSure; i++)
                {
                    if (i == 1)
                    {
                        if (aracTipi == 1)
                        {
                            odenecekTutar = i * 5;
                        }
                        else if (aracTipi == 2)
                        {
                            odenecekTutar = i * 6;
                        }
                        else if (aracTipi == 3)
                        {
                            odenecekTutar = i * 6.5;
                        }
                    }
                    else
                    {

                        kalinanSure -= 1;
                        if (aracTipi == 1)
                        {
                            odenecekTutar += kalinanSure * 5 * 1.20;
                        }
                        else if (aracTipi == 2)
                        {
                            odenecekTutar += kalinanSure * 6 * 1.215;
                        }
                        else if (aracTipi == 3)
                        {
                            odenecekTutar += kalinanSure * 6.5 * 1.25;
                        }
                    }
                }

            }

            else
            {

                if (aracTipi == 1)
                {

                    odenecekTutar = kalinanSure * 5;
                }
                else if (aracTipi == 2)
                {
                    odenecekTutar = kalinanSure * 6;
                }
                else if (aracTipi == 3)
                {
                    odenecekTutar = kalinanSure * 6.5;
                }

            }
            Console.WriteLine("Ödenecek Tutar : {0} TL", odenecekTutar);
            Console.ReadLine();
            #endregion
        }
    }
}
