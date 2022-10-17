using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnekkkkk
{
    internal class Program
    {
        private void dizirandom()
        {
           
            
            int[] dizi =new int [20];
            Random rnd = new Random();
            int dizitoplamı = 0, ortalamadanBuyuk = 0, ortalamadanKucuk = 0;
            double diziOrtalaması = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i]= rnd.Next(1, 50);
                dizitoplamı += dizi[i];
                Console.WriteLine("sayı"+dizi[i]);
            }
            diziOrtalaması = dizitoplamı / 20;
            foreach(int dizin in dizi)
            {
                if (dizin > diziOrtalaması)
                {
                    ortalamadanBuyuk += 1;
                }
                else
                {
                    ortalamadanKucuk += 1;
                }
            }
            Console.Write("dizi ortalaması= " + diziOrtalaması + " ortalamadan büyük eleman sayısı= " + ortalamadanBuyuk + " ortalamadan küçük eleman sayısı= " + ortalamadanKucuk);
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            //elemanları tam sayı olan bir a dizisinin(20 elemanlı) rastgele sayıları atayan sonra dizi elemanlarının aritmetik ortalamsını hesaplayan ve elamanlardan kaç tanesinin bu ortalamadan büyük ve küçük olduğunu sayan programın kodunu yazın.
            //random 1 ile 100 arasında olsun
            Program prg=new Program();  
            prg.dizirandom();   


        }
    }
}
