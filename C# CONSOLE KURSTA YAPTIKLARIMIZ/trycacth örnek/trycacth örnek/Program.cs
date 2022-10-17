using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycacth_örnek
{
    internal class Program
    {
        private static int SayiGetir()
        {
            int girilen1 = -1;
            try
            {
                Console.WriteLine("Birinci sayıyı girin= ");
                girilen1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Hatalı giriş");
            }
            return girilen1;
        }
    }
}
//        private static int SayiGetir2()
//        {
//            int girilen2 = -1;
//            try//hata yakalar ve gösterir.
//            {
//                Console.WriteLine("İkinci sayıyı girin= ");
//               girilen2 = Convert.ToInt32(Console.ReadLine());
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Hatalı giriş");
//            }
//            return girilen2;
//        }

//        private static void KontrolEt(int sayi)
//        {
//            if(sayi==0)
//            {
//                Console.WriteLine("Sıfırdan farklı bir sayı giriniz= ");
//                sayi = SayiGetir();
//                KontrolEt(sayi);
//            }
//            if(sayi==-1)
//            {
//                sayi = SayiGetir();
//                KontrolEt(sayi);
//            }
//            else
//            {
//                Console.WriteLine("Girilen Sayı : " + sayi);
//                int sayi2 = SayiGetir2();
//                if(sayi2==0)
//                {
//                    Console.WriteLine("Sıfırdan farklı bir sayı girin= ");
//                    sayi2 = SayiGetir2();
//                    KontrolEt(sayi2);
//                }

//                else
//                {
//                    Console.WriteLine("2.Sayi= " + sayi2);
//                    int toplam = sayi + sayi2;
//                    Console.WriteLine("Sonuc değer=" + toplam);
//                    Console.ReadLine();
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            int sayi = SayiGetir();
//            KontrolEt(sayi);
//        }
//    }
//}
