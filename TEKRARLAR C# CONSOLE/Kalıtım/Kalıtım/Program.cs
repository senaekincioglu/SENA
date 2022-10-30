using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Program
    {
        public class İnsan
        {
            public string ad { get; set; }
            public string soyad { get; set; }
            public int yas { get; set; }
            public int kilo { get; set; }
        }
        public class Personel : İnsan
        {
            public string departman { get; set; }
            public string yer { get; set; }
            public int boy { get; set; }
        }
        static void Main(string[] args)
        {
            İnsan ins = new İnsan();
            ins.ad = "Murat";
            ins.soyad = "Yücedağ";
            ins.yas = 22;
            ins.kilo = 75;

            Console.WriteLine("Ad : " + ins.ad);
            Console.WriteLine("Soyad : " + ins.soyad);
            Console.WriteLine("Yaş : " + ins.yas);
            Console.WriteLine("Kilo : " + ins.kilo);

            Console.WriteLine();

            Personel pers = new Personel();
            pers.departman = "Eğitmen";
            pers.yer = "Şube-1";
            pers.boy = 185;

            //normalde personel classında ad yok ama personel classına insan classı eklendi. personel den ad çağrılıyor.
            pers.ad = "SENA";
            pers.kilo = 65;

            Console.WriteLine("Departman : " + pers.departman);
            Console.WriteLine("Yer : " + pers.yer);
            Console.WriteLine("Boy : " + pers.boy);
            Console.WriteLine("Ad : " + pers.ad);
            Console.WriteLine("Kilo : " + pers.kilo);

            Console.ReadLine();


        }
    }
}
