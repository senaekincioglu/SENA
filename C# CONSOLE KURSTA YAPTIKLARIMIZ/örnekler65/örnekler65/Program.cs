using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnekler65
{
    internal class Program
    {
        private void Daire()
        {
            //int toplam = 0, kisi = 0;  

            //for (int i = 0; i < 4; i++)//kat
            //{
            //    for (int j = 0; j < 3; j++)//daire
            //    {
            //        Console.Write("kişi sayısı girin ");
            //        kisi = Convert.ToInt32(Console.ReadLine());
            //        toplam += kisi;
            //    }
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            int[,] dizi = new int[4, 3];
            int toplamkisi = 0, evdekikisi = 0;
            for (int i = 0; i < dizi.GetLength(0); i++)//getlength çok boyutlu bir dizinin belirli bir boyutunun uzunluğunu döndürür. Uzunluk, tüm boyutlardaki toplam öğe sayısının toplamını döndürür.
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    Console.WriteLine("{ 0} . kat {1} Daire deki kişi sayısı giriniz:  ", i + 1, j + 1);
                    evdekikisi = Convert.ToInt32(Console.ReadLine());
                    toplamkisi += evdekikisi;//toplam=toplam+kişi
                }
            }
            Console.WriteLine("toplam kişi sayısı {0}", toplamkisi);
            Console.ReadLine();


        }
        static void Main(string[] args)
        {
            //4 katlı bir binanın her katında 3 daire var. klavyede her dairede bulunan kişi sayısını girdikten sonra binada kaç kişi olduğunu toplayan program.
            Program prg = new Program();
            prg.Daire();

        }
    }
}
