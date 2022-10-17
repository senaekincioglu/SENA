using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //burada çalışır.

            //class: yapmak istediğimiz işlemleri gruplara ayırmak ve bu grup üzerinde işlemlerimizi yapmak ve rahatlıkla bu gruba ulaşmak için kullanılır.


            //erişim türleri 
            //public: tüm classlarda çağrılıp, kullanılabilir.
            //private: sadece bulunduğu class da çağrılır.

            //global: bir metot diye düşünülebilir.

            //static: bulunduğu class da metot adı ile direkt çağrılır
            //public-static : genel bir değişken tanımlaması olmasına rağmen başka classa gidemez sadece kendi classında class nesnesi tanımlanmadan kullanılabilir.
            //private-static: private clas özel tanımlama ve static ise classa ait değişken olduğundan dışarıdan çağrıldığında erişilemez.


            URUNLERR urunBilgileri = new URUNLERR();//bulunduğu classın ismi ile çağrılır
            urunBilgileri.Ekleme();
            urunBilgileri.Silme();
            Console.WriteLine();
            Console.ReadLine();
            Musteri musteriBilgileri = new Musteri();
            musteriBilgileri.Ekle();
            musteriBilgileri.Guncelleme();
            Console.ReadLine();

            



        }
        
   
       
    }

}