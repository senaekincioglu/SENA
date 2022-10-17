using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf_ile_indirim_ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir manav bölümünde satılan elma armut ve muz (elma=3, armut=5, muz=7 tl) kg fiyatlarında müşterinin seçtiği kg ye 
            //göre seçilen ürün kg si 0 ile 50 arasında ise % 10 indirim uygula, 50 ile 100 arasında ise %15 indirim uygula, 100 üstüyse
            //%20 indirim uygula.
           
            double elma = 3, armut = 5, muz = 7;
            Console.Write("Hangi üründen alacaksınız= ");
            string urun = Convert.ToString(Console.ReadLine());
            double kg;
            double tutar;
            double indirim,indirimlisatis;
            Console.Write("Kaç kilogram alacaksınız= ");
           kg = Convert.ToDouble(Console.ReadLine());

            if (urun == "elma")
            {
                if (kg > 0 || kg < 50)
                {
                    tutar = kg * elma;
                    Console.WriteLine("Gerçek tutar= " + tutar);
                    indirim = (tutar * 10) / 100;
                    indirimlisatis = tutar - indirim;
                    Console.WriteLine("İndirimli fiyat= " + indirimlisatis);
                }
                else if (kg >= 50 || kg <= 100)
                {
                    tutar = kg * elma;
                    Console.WriteLine("Gerçek tutar= " + tutar);
                    indirim = (tutar * 15) / 100;
                    indirimlisatis = tutar - indirim;
                    Console.WriteLine("İndirimli fiyat= " + indirimlisatis);
                }
                else if (kg > 100)
                {
                    tutar = kg * elma;
                    Console.WriteLine("Gerçek tutar= " + tutar);
                    indirim = (tutar * 20) / 100;
                    indirimlisatis = tutar - indirim;
                    Console.WriteLine("İndirimli fiyat= " + indirimlisatis);
                }
            }

          if (urun == "armut")
            {
                if (kg > 0 || kg < 50)
                {
                    tutar = kg * armut;
                    Console.WriteLine("Gerçek tutar= " + tutar);
                    indirim = (tutar * 10) / 100;
                    indirimlisatis = tutar - indirim;
                    Console.WriteLine("İndirimli fiyat= " + indirimlisatis);
                }
               else  if (kg >= 50 || kg <= 100)
                {
                    tutar = kg * armut;
                    Console.WriteLine("Gerçek tutar= " + tutar);
                    indirim = (tutar * 15) / 100;
                    indirimlisatis = tutar - indirim;
                    Console.WriteLine("İndirimli fiyat= " + indirimlisatis);
                }
                else if (kg > 100)
                {
                    tutar = kg * armut;
                    Console.WriteLine("Gerçek tutar= " + tutar);
                    indirim = (tutar * 20) / 100;
                    indirimlisatis = tutar - indirim;
                    Console.WriteLine("İndirimli fiyat= " + indirimlisatis);
                }
            }
             if (urun == "muz")
            {
                if (kg > 0 || kg < 50)
                {
                    tutar = kg * muz;
                    Console.WriteLine("Gerçek tutar= " + tutar);
                    indirim = (tutar * 10) / 100;
                    indirimlisatis = tutar - indirim;
                    Console.WriteLine("İndirimli fiyat= " + indirimlisatis);
                }
                else if (kg >= 50 || kg <= 100)
                {
                    tutar = kg * muz;
                    Console.WriteLine("Gerçek tutar= " + tutar);
                    indirim = (tutar * 15) / 100;
                    indirimlisatis = tutar - indirim;
                    Console.WriteLine("İndirimli fiyat= " + indirimlisatis);
                }
                else if (kg > 100)
                {
                    tutar = kg * muz;
                    Console.WriteLine("Gerçek tutar= " + tutar);
                    indirim = (tutar * 20) / 100;
                    indirimlisatis = tutar - indirim;
                    Console.WriteLine("İndirimli fiyat= " + indirimlisatis);
                }
                


            }



            Console.ReadLine();


        }
    }
}
