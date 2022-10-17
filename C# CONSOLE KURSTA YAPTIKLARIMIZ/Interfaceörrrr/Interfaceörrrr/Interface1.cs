using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceörrrr
{
    internal interface Interface1 // ınterfaceler(ortaklar ) tanımlandı
    {
        void maas();
        void yemek();
        void calis();

    }
    interface Yemek
    {
        void yemek();
    }
    class calisan : Interface1 // class lar tanımlandı
    {
        public void calis() // metot lar tanımlandı
        {
            
        }

        public void maas()// metot lar tanımlandı
        {
           
        }

        public void yemek()// metot lar tanımlandı
        {
            
        }
    }
    class robot : Interface1  // class lar tanımlandı
    {
        public void calis()// metot lar tanımlandı
        {
            
        }

        public void maas()// metot lar tanımlandı
        {
            
        }

        public void yemek()// metot lar tanımlandı
        {
           
        }
    }
    class yonetici : Yemek
    {
        public void calis()// metot lar tanımlandı
        {
            
        }

        public void maas()// metot lar tanımlandı
        {
            
        }

        public void yemek()// metot lar tanımlandı
        {
            
        }
    }
}
