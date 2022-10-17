using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnekclasmetot
{
    internal class Program
    {
        class Arababilgileri
        {
            string Yas;
            public string yas
            {
                get
                {
                    return Yas;
                }
                set
                {
                    if(Yas )
                    {

                    }
                    else
                    {

                    }
                }
            }
        




        }

        class MusteriBilgisi
        {

            int tcno;
            public int TcNo
            {
                get { return tcno; }

                set
                {
                    tcno = value;
                }

            }
            public string adsoyad { get; set; }


        }



        static void Main(string[] args)
        {
            
            MusteriBilgisi musteri = new MusteriBilgisi();
            Console.Write("tc girin= ");
            int tc = Convert.ToInt32(Console.ReadLine());
            musteri.TcNo = tc;
            Console.WriteLine(musteri.TcNo);

            musteri.adsoyad = "Sena";
            Console.Write(musteri.adsoyad);

            Console.Write("Yaş girin= ");
            int yass = Convert.ToInt32(Console.ReadLine());
            Arababilgileri.yas = yass;
            Console.WriteLine(Arababilgileri.yas);

            Console.ReadLine();
        }
    }
}

