using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotÖrnekleri5
{

    internal class Program
    {
        public double ivme(string s ,double ih, double sh);
        {
            double sonuc = (sh - ih) / Convert.ToDouble(s);
            return sonuc;
        }
        static void Main(string[] args)
        {
            //hız İvme hesaplaması metot ile
            // son zaman ilk zaman ilk hız son hız 
            //süre(son zaman ilk zaman)
            //ilk hız
            //son hız 
            //(s-i) /sure

            Program prg = new Program();
            Console.Write("Süre gir= ");
            string sure = Convert.ToString(Console.ReadLine());
            Console.Write("İlk hızı girin=");
            double ilkHiz = Convert.ToDouble(Console.ReadLine());
            Console.Write("Son hızı girin= ");
            double sonHiz=Convert.ToDouble(Console.ReadLine());




        Console.WriteLine(prg.ivme(sure, ilkHiz, sonHiz));

        }
    }
}
