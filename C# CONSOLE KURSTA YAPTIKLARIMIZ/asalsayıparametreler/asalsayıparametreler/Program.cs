using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalsayıparametreler
{
    internal class Program
    {
        static bool Asalsayi(int sayi)
        {
            bool sonuc;
            int sayac = 0;
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi%i==0)
                {
                    sayi += 1;
                }
            }
            if (sayac==2)
            {
                sonuc = true;

            }
            else
            {
                sonuc = false;
            }
            return sonuc;
           
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            bool sonuc = Asalsayi(25);
            if (sonuc) Console.WriteLine("Asal sayı");
            else Console.WriteLine("Asal sayı değil");
            Console.ReadLine();
            //Metotlarda program classının içinde olduğu için new yapmaya gerek yok. dışardaki class tan çağıracaksan newleme yapıyorsun.

        }
    }
}
