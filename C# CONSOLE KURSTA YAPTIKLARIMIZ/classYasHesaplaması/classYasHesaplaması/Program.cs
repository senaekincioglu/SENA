using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classYasHesaplaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = DateTime.Parse("2000-04-01");
            Kisi kisi = new Kisi();
            kisi.AdSoyad = "Sena";
            kisi.Dtarih = tarih; 
            Console.WriteLine(kisi.Yas);
            Console.WriteLine(kisi.AdSoyad);
            Console.ReadLine();
        }
    }
        class Kisi
        {
            //kişiye özel
            //set değer demek
            private string adSoyad;
            private int YaS;
            private DateTime dTarihi;
            public string AdSoyad { get { return adSoyad; } set { adSoyad = value; } }
        public DateTime Dtarih { get { return dTarihi; } set { dTarihi = value; } } 
            public int Yas { get { return DateTime.Now.Year - dTarihi.Year; } }
        }

    }
