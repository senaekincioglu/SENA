using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Insan sena = new Insan();//Nesne oluşturduk.
            sena.Ad = "Sena";
            sena.Soyad = "Ekincioğlu";
            sena.SacRengi = "Siyah";
            sena.GozRengi = "Kahve";
            sena.DogumTarihi = new DateTime(2000, 04, 01);
            //sena.Yas = 22; Hata verir. Çünkü sadece okunabilirdir.

            sena.TcNo = "4138916813";

            string senaninKonusmasi = sena.Konus();
            Console.WriteLine(senaninKonusmasi);

            Console.WriteLine("Ad: " + sena.Ad);
            Console.WriteLine("Soyad: " + sena.Soyad);
            Console.WriteLine("Saç Rengi: " + sena.SacRengi);
            Console.WriteLine("Göz Rengi: " + sena.GozRengi);
            Console.WriteLine("Doğum Tarihi: " + sena.DogumTarihi);
            Console.WriteLine("Yas: " + sena.Yas);
            Console.WriteLine("Tc No: " + sena.TcNo);
            


            /*----------------------------------------*/

            Ogrenci beyza = new Ogrenci();
            beyza.Ad = "Beyza";
            string beyzaninKonusmasi = beyza.Konus();
            Console.WriteLine(beyzaninKonusmasi);


            beyza.Ders = "Matematik";
            string beyzaDers = beyza.DersYap();
            Console.WriteLine(beyzaDers);


            Console.ReadLine();
        }
    }
}
