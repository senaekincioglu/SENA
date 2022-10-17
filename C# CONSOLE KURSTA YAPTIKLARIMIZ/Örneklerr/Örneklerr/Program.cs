using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örneklerr
{
    internal class Program
    {
        private void SıfırKontrol()
        {

            Console.WriteLine("Bir sayı girin= ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayı girin= ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 == 0 && sayi2 == 0)
            {
                Console.WriteLine("0 girdiniz");
            }
            else
            {
                Console.WriteLine("Hata! sayı 0 dan farklı ve sayıların toplamı= " + sayi1 + sayi2);

            }



        }




            static void Main(string[] args)
        {
            //klavyeden girilen iki sayının 0 dan farklı olup olmadığını kontrol eden ve toplayan program
            //negatif veya pozitif mi kontrol et. negatifse hata yazdır.
            
            Program prg = new Program();
            prg.SıfırKontrol();
            Console.ReadLine();
        }
    }
}
