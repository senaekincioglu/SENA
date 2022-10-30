using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //ınterface classların tüm özelliklerini ınterface ile yazdırıyor.
            // Ikisi kisi = new Ikisi(); Interface new lenemez

            Ogrenci ogrenci = new Ogrenci
            {
                Id = 1,
                Ad = "Sena",
                Soyad="Ekincioğlu",
                Bölum="bilgisayar"

            };
            Console.WriteLine(ogrenci.Ad);
            

            Musteri musteri = new Musteri
            {
                Id = 1,
                Ad = "Sena",
                Soyad="Ekincioğlu"

            };
            Console.WriteLine(musteri.Id);
            Console.WriteLine(musteri.Ad);
            Console.WriteLine(musteri.Soyad);
            Console.ReadLine();



        }

    }
    interface Ikisi
    {
        int Id { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }


    }
    class Calisan : Ikisi
    {
        public int Id { get; set; }
        public String Ad { get; set; }
        public string Soyad { get; set; }
    }
    class Ogrenci : Ikisi
    {
        public int Id { get; set; }
        public String Ad { get; set; }
        public string Soyad { get; set; }

        public int maas { get; set; }
        public string Bölum { get; set; }

    }
    class Musteri : Ikisi
    {
        public int Id { get; set; }
        public String Ad { get; set; }
        public string Soyad { get; set; }
    }
    class MyClass
    {
        public void Ekle(Ikisi ıkisi)//metoda vereceğin parametrenin ınterface olması lazım o yüzden parantez içine bu yazılıyor.
        {
            Console.WriteLine(ıkisi);
        }
    }


}

