using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotclassss
{
    internal class Program
    {

        public void musteriBilgileri()
        {
            Console.WriteLine("Tc girin= ");
            decimal tc = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ad soyad= ");
            string adsoyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine(tc + " " + adsoyad);
        }

        public void aracBilgisi()
        {
            Console.Write("Model girin= ");    
            int yil;
            yil = DateTime.Now.Year - Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Araç yaşı {0} ",yil);
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write(yas);

           

            Console.WriteLine("Araç kazalı mı =  ");
            string kaza = Convert.ToString(Console.ReadLine());
            double sonuc;
            double deger = 5000;

            if (yas > 0 && yas < 10) 
            {
                switch (kaza)
                {

                    case "Evet":
                        sonuc = deger * 1.55;
                        Console.WriteLine(sonuc);
                        break;
                    case "Hayir":
                        sonuc = deger * 1.75;
                        Console.WriteLine(sonuc);
                        break;

                }
            }
            else if (yas >= 10 && yas < 20)
            {
                switch (kaza)
                {
                    case "Evet":
                        sonuc = deger * 1.80;
                        Console.WriteLine(sonuc);
                        break;
                    case "Hayir":
                        sonuc = deger * 2;
                        Console.WriteLine(sonuc);
                        break;
                }
            }
            else
            {
                Console.Write("Bu araç sigortaya uygun değildir.");
            }



        }
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.musteriBilgileri();
            prg.aracBilgisi();
            Console.ReadLine();
        }
    }
}                                                                                                                                                                                                                                                                 
