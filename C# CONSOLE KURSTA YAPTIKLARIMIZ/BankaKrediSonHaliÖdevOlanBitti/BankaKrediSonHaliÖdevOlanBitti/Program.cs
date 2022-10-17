using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediSonHaliÖdevOlanBitti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hesaplama = 0;
            Console.WriteLine("Kredi tutarını giriniz =");
            int Kreditutar = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Vade seçiniz =");
            int vade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Lütfen bir banka seçiniz ");

            Console.WriteLine("Garanti bankası için 1");
            Console.WriteLine("İş bankası için 2");
            Console.WriteLine("Finansbank için 3");
            Console.WriteLine("Ziraat bankası için 4");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b == 1)
            {
                Console.WriteLine("Garanti bankası seçtiniz");
            }
            else if (b == 2)
            {
                Console.WriteLine("İş bankası seçtiniz");
            }
            else if (b == 3)
            {
                Console.WriteLine("Finansbank seçtiniz");
            }
            else if (b == 4)
            {
                Console.WriteLine("Ziraat bankası seçtiniz");
            }
            Console.WriteLine("Kurumsal ise 1 e Bireysel ise 2 ye basınız");
            int soru = Convert.ToInt16(Console.ReadLine());

            if (soru == 1)
            {
                Console.WriteLine("Kurumsal seçtiniz ");
                Console.WriteLine("Lütfen Kullanıcı adını giriniz");
                string kadi = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Lütfen şifrenizi giriniz");
                int sifre = Convert.ToInt16(Console.ReadLine());

                if (kadi == "admin" && sifre == 123)
                {
                    Console.WriteLine("Doğru giriş yaptınız");
                    hesaplama = Kreditutar + (Kreditutar * vade * 1.9 / 120);
                    //hesaplama = Kreditutar+(Kreditutar * vade * faiz / 120);
                    //hesaplama=(Kreditutar*vade*faiz)+Kreditutar;
                    //hesaplama = (Kreditutar * 0.174) / vade + (Kreditutar * 0.174);
                    Console.WriteLine(hesaplama);

                }
                else
                {
                    Console.WriteLine("Yanlış giriş yaptınız");
                }
            }
            else if (soru == 2)
            {
                Console.WriteLine("Bireysel seçtiniz ");
                hesaplama = Kreditutar + (Kreditutar * vade * 1.9 / 120);
                
                Console.WriteLine(hesaplama);
            }
            double taksit;
            taksit = hesaplama / vade;

            for (int i = 1; i <= vade; i++)
            {
                Console.WriteLine("Krediyi kapatmak istiyor musunuz,istemiyorsanız 1'e istiyorsanız 2'ye basınız");
                int tamam = Convert.ToInt16(Console.ReadLine());

                if (tamam == 1)
                {
                    taksit = taksit - (taksit * 0.19);
                    Console.WriteLine("Aylık taksit tutarı  = " + hesaplama / vade);
                    Console.WriteLine($"{i}.Faiz tutarı  = " + taksit);
                    Console.WriteLine("Anapara  = " + (hesaplama / vade - taksit));
                    Console.WriteLine("---------------------------------");
                }
                else if (tamam == 2)
                {
                    Console.WriteLine("Ödemeniz gereken indirimli tutar = " + (hesaplama - (taksit * (i + 1))));
                    break;
                }


            }

            Console.ReadLine();
        }
    }
}
