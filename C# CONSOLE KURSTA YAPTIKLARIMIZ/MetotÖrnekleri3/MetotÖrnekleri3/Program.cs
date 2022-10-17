using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotÖrnekleri3
{
    internal class Program
    {
        private void Toplama()
        {
            int s1=0, s2=0,sonuc;           
            sonuc = s1 + s2;
            Console.Write(s1,s2);

        }
        static void Main(string[] args)
        {
            //değer almayan ve parametre almayan hesap makinesi. 
            Program prg = new Program();
            Console.Write("Sayı girin= ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı girin= ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            prg.Toplama();
        }
    }
}
