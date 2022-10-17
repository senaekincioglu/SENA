using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnekk
{
    internal interface Interfacee // classlara ait özellik
    {
        void Ad();
        void Update();
        void Delete();
        
    }
    class SqlServer : Interfacee
    {
        public void Ad()
        {
            Console.WriteLine("Sql Server Add!!!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Delete!!!");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server Update!!!");
        }
    }
    class OracalServer : Interfacee
    {
        public void Ad()
        {
            Console.WriteLine("Oracal Server Add!!!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracal Server Delete!!!");
        }

        public void Update()
        {
            Console.WriteLine("Oracal Server Update!!!");
        }
        class mssql : Interfacee
        {
            public void Ad()
            {
                Console.WriteLine("Mssql Server Add!!!");
            }

            public void Delete()
            {
                Console.WriteLine("Mssql Server Delete!!!");
            }

            public void Update()
            {
                Console.WriteLine("Mssql Server Update!!!");
            }
        }

        //hepsini bir arada kullanmak için class oluştur.
        class Veritabanıİslemleri
        {
            public void Ekle(Interfacee interfacee)//bütün istediklerimizden faydalanmak için ınterfaceyi göster.
            {
                Interfacee.Ad();
            }
            public void Sil(Interfacee interfacee)//bütün istediklerimizden faydalanmak için ınterfaceyi göster.
            {
                Interfacee.Delete();
            }
            public void Güncelle(Interfacee interfacee)//bütün istediklerimizden faydalanmak için ınterfaceyi göster.
            {
                Interfacee.Update();
            }

        }
    }
}
