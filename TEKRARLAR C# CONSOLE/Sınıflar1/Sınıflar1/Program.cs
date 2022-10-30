using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class lar newlenir kendi adıyla. eğer main sayfasında class tanımlansaydı program yani o sayfanın class ı ile newlenirdi.
            Araba araba = new Araba();
            araba.renk = "Mavi";
            araba.fiyat = 150000;
            araba.model = "2016";
            araba.vites = "Otomatik";
            araba.plaka = "16-Bursa";

            Console.WriteLine("Arabanın rengi : "+araba.renk);
            Console.WriteLine("Arabanın fiyatı : " + araba.fiyat);
            Console.WriteLine("Arabanın modeli : " + araba.model);
            Console.WriteLine("Arabanın vitesi : " + araba.vites);
            Console.WriteLine("Arabanın plakası : " + araba.plaka);
            Console.WriteLine();

            araba.renk = "Beyaz";
            araba.fiyat = 200000;
            araba.model = "2020";
            araba.vites = "Otomatik";
            araba.plaka = "34-İstanbul";

            Console.WriteLine("Arabanın rengi= "+araba.renk);
            Console.WriteLine("Arabanın fiyatı= " + araba.fiyat);
            Console.WriteLine("Arabanın modeli= " + araba.model);
            Console.WriteLine("Arabanın vitesi= " + araba.vites);
            Console.WriteLine("Arabanın plakası= " + araba.plaka);
            Console.ReadLine();

        }
    }
}
