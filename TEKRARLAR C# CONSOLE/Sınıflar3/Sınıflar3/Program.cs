using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emlak eml = new Emlak();
            eml.SEMTİ = "Ümraniye";
            eml.RENGİ = "Bej";
            eml.ODASAYİSİ = 4;
            eml.KATNUMARASI = 1;
            eml.ALANI = 200;

            Console.WriteLine("Semti : " + eml.SEMTİ);
            Console.WriteLine("Rengi : " + eml.RENGİ);
            Console.WriteLine("Oda Sayısı : " + eml.ODASAYİSİ);
            Console.WriteLine("Kat Numarası : " + eml.KATNUMARASI);
            Console.WriteLine("Alanı : " + eml.ALANI);

            Console.ReadLine();
        }
    }
}
