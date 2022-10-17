using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassÖrnekleriKutuphane
{
    internal class Personel
    {
        public void Kız()
        {
            Console.WriteLine("Sena");
            Console.WriteLine("Elif"); 
            Console.WriteLine("Öznur");
            Console.WriteLine("Şeyma");
            Console.WriteLine("Beyza");
            Console.WriteLine("Necla");
            
        }
        public string Kızlar { get; set; }
        public void Erkek()
        {
            Console.WriteLine("Oğuz");
            Console.WriteLine("Hüseyin");
            Console.WriteLine("Ahmet");
            Console.WriteLine("Mehmet");
            Console.WriteLine("Ali");
        }
    }
}
