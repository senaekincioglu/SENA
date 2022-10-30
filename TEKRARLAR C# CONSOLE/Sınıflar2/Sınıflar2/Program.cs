using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.ADI = "Sena";
            ogr.SOYADI = "Ekincioğlu";
            ogr.ALANI = "Bilgisayar Muhendisliği";
            ogr.YASİ = 22;

            Console.WriteLine("Adı: " + ogr.ADI);
            Console.WriteLine("Soyadı: " + ogr.SOYADI);
            Console.WriteLine("Alanı: " + ogr.ALANI);
            Console.WriteLine("Yaşı: " + ogr.YASİ);

            Console.ReadLine();
        }
    }
}
