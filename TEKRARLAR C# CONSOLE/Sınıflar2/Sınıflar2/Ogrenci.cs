using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar2
{
    internal class Ogrenci
    {
        //Ogrenci adında bir class oluşturuldu. ve bu class a ait özellikler tanımlanacak.
        //public yapınca heryerde ulaşabiliyordun. ama private yapınca heryerde erişemiyordun.
        //private yapmak istiyorsan get ve set özelliklerini kullanarak heryerde erişebilirsin.

        private string ad;
        private string soyad;
        private int yas;
        private string alan;

        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string ALANI
        {
            get { return alan; }
            set { alan = value; }
        }
        public int YASİ
        {
            get { return yas; }
            set
            {
                if(value<18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }
        }
    }
}
