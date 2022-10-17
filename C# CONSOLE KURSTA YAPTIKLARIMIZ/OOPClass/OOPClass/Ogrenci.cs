using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass
{
    internal class Ogrenci:Insan //Inheritance - Kalıtım 
    {
        public string Okul { get; set; }
        public double Not { get; set; }
        public string Ders { get; set; }

        public string DersYap()
        {
            return Ders + " dersi yapıyorum";
        }
    }
}
