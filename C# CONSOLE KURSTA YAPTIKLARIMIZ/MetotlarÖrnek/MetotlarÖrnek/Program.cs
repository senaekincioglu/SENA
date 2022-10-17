using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarÖrnek
{
    internal class Program
    { 
       
        public int cevreHesaplama(int uzunluk, int genislik)//değer döndürüp parametre alan.
        {
            int cevre = 2 * (uzunluk + genislik);
            return cevre;
        }

        static void Main(string[] args)
        {
            //Çevre hesaplaması uzunluk genişlik.
            int uzunlukdeger = 0;
            int genislikdeger = 0;

            Console.WriteLine("Çevre Hesaplama \n");

            Console.Write("Uzunluk giriniz= ");
            uzunlukdeger = Convert.ToInt32(Console.ReadLine());

            Console.Write("genişlik giriniz= ");
            genislikdeger = Convert.ToInt32(Console.ReadLine());
            Program prg = new Program();
            Console.WriteLine("ÇEVRE= " + prg.cevreHesaplama(uzunlukdeger,genislikdeger));

            
        }
    }
}
