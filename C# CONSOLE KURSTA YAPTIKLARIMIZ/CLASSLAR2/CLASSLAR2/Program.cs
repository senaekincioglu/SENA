using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSLAR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program cs de çağrılıyo
            URUNBİLGİSİ urunBilgisi = new URUNBİLGİSİ
            {
                ıd = 1,
                Adi = "Elma",
                Adet = 10

            };
            URUNBİLGİSİ urunbilgisi = new URUNBİLGİSİ
            {ıd=1,
            Adi="Sena",
            Adet=10

            };
            Console.WriteLine(urunBilgisi.Adi);
            Console.ReadLine();
        }
    }
}
