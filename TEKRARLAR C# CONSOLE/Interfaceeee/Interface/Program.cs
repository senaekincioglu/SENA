using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        interface Ikıyafet
        {
            int Id { get; set; }
            string Tur { get; set; }
            string Renk { get; set; }
            double Fiyat { get; set; }
            // string Yaka { get; set; } pantolonda yakaya ihtiyaç yok. o yüzden hepsinde olanı yazarsın. ortakları
            // string EnBoy { get; set; } kazakta en boya ihtiyaç yok.
            //  string Kesim { get; set; } kazakta kesime ihtiyaç yok.
            char Size { get; set; }
            //string Desen { get; set; } desen elbisede ihtiyaç yok gibi.
        }
        class Kazak : Ikıyafet
        {
            public int Id { get; set; }
            public string Tur { get; set; }
            public string Renk { get; set; }
            public double Fiyat { get; set; }
            public string Yaka { get; set; }
            // public string EnBoy { get; set; } interface de kaldırdığımız için yani hepsinde geçerli olmadığı için burda da kullanılmaz.
            // public string Kesim { get; set; } interface de kaldırdığımız için yani hepsinde geçerli olmadığı için burda da kullanılmaz.
            public char Size { get; set; }
            //  public string Desen { get; set; } interface de kaldırdığımız için yani hepsinde geçerli olmadığı için burda da kullanılmaz.
            private string ozellik1 { get; set; }
        }
        class Pantolon : Ikıyafet
        {
            public int Id { get; set; }
            public string Tur { get; set; }
            public string Renk { get; set; }
            public double Fiyat { get; set; }
            //  public string Yaka { get; set; } interface de kaldırdığımız için yani hepsinde geçerli olmadığı için burda da kullanılmaz.
            public string EnBoy { get; set; }
            public string Kesim { get; set; }
            public char Size { get; set; }
            // public string Desen { get; set; } interface de kaldırdığımız için yani hepsinde geçerli olmadığı için burda da kullanılmaz.
            public string Marka { get; set; }
            public bool PacaYapilacakmi { get; set; }
        }
        class Elbise : Ikıyafet
        {
            public int Id { get; set; }
            public string Tur { get; set; }
            public string Renk { get; set; }
            public double Fiyat { get; set; }
            //  public string Yaka { get; set; } interface de kaldırdığımız için yani hepsinde geçerli olmadığı için burda da kullanılmaz.
            public string EnBoy { get; set; }
            //  public string Kesim { get; set; } interface de kaldırdığımız için yani hepsinde geçerli olmadığı için burda da kullanılmaz.
            public char Size { get; set; }
            public string Desen { get; set; }
            public string Kumas { get; set; }
        }
        static void Main(string[] args)
        {
            //kazak pantolon elbise
            //burda istediğin classları çağırıp class içinde istediklerini tanımlayıp yazdırabilirsin.
            Kazak kzk = new Kazak();
            kzk.Fiyat = 200.75;
            kzk.Renk = "Mavi";

            Console.WriteLine("Kazak fiyatı : "+ kzk.Fiyat);
            Console.WriteLine("Kazak rengi : "+kzk.Renk);

            Console.WriteLine();

            Pantolon pntl = new Pantolon();
            pntl.Id = 5;
            pntl.Size = 'M';
            pntl.Marka = "Mavi";

            Console.WriteLine("Pantolon Id : "+pntl.Id);
            Console.WriteLine("Pantolon size : "+pntl.Size);
            Console.WriteLine("Pantolon marka : "+pntl.Marka);

            Console.WriteLine();

            Elbise elbs = new Elbise();
            
                elbs.Kumas = "Polyester";
                elbs.EnBoy= "28-30";

            Console.WriteLine("Elbise kumaş : "+elbs.Kumas);
            Console.WriteLine("Elbise enboy : "+elbs.EnBoy);

            Console.ReadLine();
            //yani interface de sadece ortaklar olsa yeter. o yüzden interface de sadece pantolona ait olanı veya sadece elbiseye ait olanları yazmaya gerek yok.
        }
    }
}
