using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek
{
    internal class Program
    {
        private void komisyon()//metot ile
        {
            double malFiyati = 0, komisyonmiktarı = 0, toplamkomisyon = 0;

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.Write("malın fiyatını girin= ", i + 1);
                    malFiyati = Convert.ToDouble(Console.ReadLine());
                    if (malFiyati > 60)
                    {
                        komisyonmiktarı = malFiyati * 0.02;

                    }
                    else
                    {
                        komisyonmiktarı = malFiyati * 0.03;
                    }

                }
                catch
                {
                    Console.WriteLine("Hatalı giriş");
                }
                Console.WriteLine(" Mal için kom:" + i + 1 + komisyonmiktarı);
                toplamkomisyon += komisyonmiktarı;
            }
            Console.WriteLine("toplam :" + toplamkomisyon);

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //bir komisyoncu sattığı mallardan fiyatı 60 tl ye kadar olanlardan %3, daha fazla olanlarda ise %2 komisyon almaktadır.klavyeden teker teker girilen beş malın komisyonlarını bulup ekrana yazdıran ve toplamı yazdıran program

            Program prg = new Program();
            prg.komisyon();
        }
    }
}
