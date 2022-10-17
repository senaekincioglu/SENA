using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖRNEKLER23
{
    internal class Program
    {
        private void Ornek()
        {
        aa:
        ba:
        ab:

            Console.WriteLine("************************************");
            double tutar = 0;
            int kalinanSure = 0;


            Console.Write("Hangi araç= ");
            
            Console.WriteLine("taksi= 1,minibüs= 2, ticari=3");
            int arac = Convert.ToInt32(Console.ReadLine());
            if (arac>3)
            {
                Console.WriteLine("Hatalı seçim");
                goto ba;
            }
                Console.Write("Kaç saat= ");
            int saat = Convert.ToInt16(Console.ReadLine());
            if (saat<1)
            {
                Console.WriteLine("Hatalı seçim");
                goto aa;
            }

            if (saat>1)
            {
                if (arac == 1)
                {

                    tutar = tutar + (saat * 5 * 1.20);
                }
                if (arac == 2)
                {
                    tutar = tutar + (saat * 6 * 1.215);
                }
                else if(arac == 3)
                {
                    tutar = tutar + (saat * 6.5 * 1.25);
                } 
                else
                {
                    Console.WriteLine("Hatalı giriş");
                    
                }
            }
            else
                kalinanSure -= 1;
            {
                if(arac==1)
                {
                    tutar = tutar + (saat * 5);
                }
                else if(arac == 2)
                {
                    tutar=tutar+(saat * 6); 
                }
                else if(arac == 3)
                {
                    tutar = tutar + (saat * 6.5);
                }

            }
            Console.WriteLine("ödenecek tutar= " + tutar);
            Console.ReadLine();
            goto ab;

        }

       
        static void Main(string[] args)
        {
            //Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.

            Program prg = new Program();
            prg.Ornek();
        }
    }
}
