using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_fonksiyonları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ındexof : kendisini çağıran string tipli değişkenin içinde kendisine parametre olarak verilen karakter veya stringi arar. Arama işlemine kendisini çağıran değişkenin içindeki verinin ilk karakterinden başlayıp son karakterine doğru yapar. IndexOf( ) metodu, aradığını bulamazsa geriye -1 değerini döndürür.

            //int[] sayi = new int[] { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(Array.IndexOf(sayi, 5));//bu sayıda 5 i aricak. 4. index
            //Console.WriteLine(Array.IndexOf(sayi, 3, 0, 4));//sınırları belirler bulamazsa -1 döner
            ////yani 0 ile 4 arasında gibi
            //Console.ReadLine();

            //array ile diziler aynı şey
            //Array isimler = new[] { "Neval", "İlker", "Bedirhan", "Burak", "Mert1,", "Mert2", "Erhan" };
            //Console.WriteLine(Array.IndexOf(isimler, "Burak",0,6));// bu şekilde de yazılabilir. 0,6 da 0 ile 6 arasında varmı onu yazdırıyo
            //int index=Array.IndexOf(isimler,"Bedirhan");//bu şekilde de yazılabilir.


            //Console.WriteLine(index);
            //Console.ReadLine();

            //Array isimler = new[] { "Neval", "İlker", "Bedirhan", "Burak", "Mert1,", "Mert2", "Erhan" };
            //int index = Array.IndexOf(isimler, "Neval");
            //if (index!=-1)
            //{
            //    Console.WriteLine("var"+index);//atama ise + , scop varsa{0} gibi arada , konur.
            //}
            //else
            //{
            //    Console.WriteLine("yok");
            //}
            //Console.ReadLine();



            //sayısal loto oluştur.
            //dizi oluştur sınırı 6 yap rastgele sayı oluştur 1 ile 49 arasında ve o sayıya göre while ile kontrol et
            //if ile index of no eşit olmayacak
            //sıralama sort ile yapılır.

            int[] numaralar = new int[6];
            int sayi;
            int i = 0;
            Random rnd = new Random();
            sayi= rnd.Next(1, 49);
            while (sayi<6)
            {
                sayi = rnd.Next(1, 49);
                if (Array.IndexOf(numaralar,sayi)==-1)
                {
                    numaralar[i] = sayi;
                    i++;
                }
            }
            Array.Sort(numaralar);
            foreach (int item in numaralar)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();

            

        }
    }
}
