using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotÖrnekleri2
{
    internal class Program
    {
        //değer döndürmeyecek (void) ve parametre alan(parantez içi olacak)

        private void Toplama(int s1,int s2)
        {
            int sonuc = s1 + s2;
            Console.WriteLine("Toplama sonucu= "+ sonuc);
        }
        private void Cikarma(int s1, int s2)
        {
            int sonuc = s1 - s2;
            Console.WriteLine("Çıkarma sonucu= "+ sonuc);
        }
        private void Carpma(int s1, int s2)
        {
            int sonuc = s1 * s2;
            Console.WriteLine("Çarpma sonucu= "+sonuc);
        }
        private void Bolme(int s1, int s2)
        {
            int sonuc = s1 / s2;
            Console.WriteLine("Bölme sonucu= "+ sonuc);
        }
        static void Main(string[] args)
        {
            //string secim = " ";
            Program prg = new Program();
            Console.Write("Sayı girin= ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı girin= ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            prg.Toplama(sayi1, sayi2);
            prg.Cikarma(sayi1, sayi2);
            prg.Carpma(sayi1, sayi2);
            prg.Bolme(sayi1, sayi2);


            Console.ReadLine();
            //switch(secim)
            //{
            //    case " +":
            //        prg.Toplama(sayi1, sayi2);
            //        break;
            //    case " -":
            //        prg.Cikarma(sayi1, sayi2);
            //        break;
            //    case " *":
            //        prg.Carpma(sayi1, sayi2);
            //        break;
            //    case " /":
            //        prg.Bolme(sayi1, sayi2);
            //        break;
        }
            
        }
    }

