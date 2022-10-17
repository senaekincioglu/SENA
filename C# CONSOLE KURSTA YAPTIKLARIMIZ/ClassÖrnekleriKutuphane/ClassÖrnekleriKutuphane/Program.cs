using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassÖrnekleriKutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KitapTuru Kitaptr = new KitapTuru 
            {
                Id=1,
                Adet=10


            };
            


            Kitaptr.Roman();
            Console.WriteLine(Kitaptr.Id);
            Console.WriteLine(Kitaptr.Adet);    

            Personel prsnl = new Personel();
            Console.Write("Personel İsimleri= ");
            prsnl.Kız();
            prsnl.Erkek();
            Console.WriteLine();

            Yonetici yntc = new Yonetici();
            yntc.Yoneticiİsmi();
            Console.ReadLine();
        }
        
    }
}
