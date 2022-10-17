using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        //Metotlar: belirli bir işlemi yerine getirmek için yazılan ve istenilen yerde çağrılan kod bloklarıdır.
        //Erişim belirleyici niteleyici(varsa) DonusTİPİ MetotAdı(varsa Parametre) 
        //Metotda çağrılacak kod blokları 

        //public herkese açık
        //private özel sadece o sayfada kullanılır.

        ///void değer döndürmeyen demek
        /// return değer döndüren metot demek

        private void Metot()//metodu programın dışında istediğin yerde yaz//parametre almayan özel
        {
            Console.WriteLine("Metot");
        }
        private void Ekle(int a, int c)//değer döndürmeyen parametre alan(parantez içindeki)
        {
            int b = 5;
            int toplam = a + b + c;
            Console.WriteLine(toplam);
        }
        private void Ekle2()//değer döndürmeyen parametre almayan(parantez içindeki)
        {
            Console.WriteLine("Merhaba");
        } 
        private int Toplama()//değer döndüren metotlardır.. void döndürmez ama diğerleri döndürür.
        {
            int a = 5;
            int b = 6;
            int sonuc = a + b;
            return a + b;   //değer döndüren.
        }
        static void Main(string[] args)
        {
            Program mrg = new Program();//bunu hep yazmak zorundasın.
            //mrg.Metot();//çalışacak kısım
            //Console.ReadLine();


            mrg.Ekle(5, 8);//void parametreli
            mrg.Ekle2();
            mrg.Toplama();
            Console.Write(mrg.Toplama());
            Console.ReadLine();

            //değer verecekse console.writeline  ile yazdırılır sonuc gibi.
            //ama üstt mettotda console.writeline("mERHABA YAZILSA") sadece
            //alt tarafta console.writeline yazdırmadan metodu çağırırsın







        }

    }
}
