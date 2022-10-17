using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Örnek_Tekrarı_Metotlar
{
    internal class Program
    {
        private void Topla()
        {
            double sayi1, sayi2, sonuc;
            Console.Write("Lütfen 1. sayıyı giriniz= ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz= ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Toplama sonucu= "+(sayi1 + sayi2));  

        }
        private void Cıkarma()
        {
            double sayi1, sayi2, sonuc;
            Console.Write("Lütfen 1. sayıyı giriniz= ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz= ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Toplama sonucu= " + (sayi1 - sayi2));
        }
        private void Carpma()
        {
            double sayi1, sayi2, sonuc;
            Console.Write("Lütfen 1. sayıyı giriniz= ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz= ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Toplama sonucu= " + (sayi1 * sayi2));
        }
        private void Bolme()
        {
            double sayi1, sayi2, sonuc;
            Console.Write("Lütfen 1. sayıyı giriniz= ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz= ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Toplama sonucu= " + (sayi1 / sayi2));
        }
        static void Main(string[] args)
        {
            ab:
            //Değer döndürmeyen ve parametre almayan metot ile hesap makinesi.
            Program prg = new Program();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz (+,-,*,/ )");
            string islem = Convert.ToString(Console.ReadLine());
            switch(islem)
            {
                case "+": prg.Topla();
                    break;
                case "-": prg.Cıkarma();
                    break;
                case "*":prg.Carpma();
                    break;
                case "/": prg.Bolme();
                    break;
            }
            goto ab;
            Console.ReadLine();

        }
    }
}
