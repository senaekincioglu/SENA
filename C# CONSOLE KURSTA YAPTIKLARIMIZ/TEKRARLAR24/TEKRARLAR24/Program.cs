using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRARLAR24
{
    internal class Program
    {
        private int AsalSayi(int sayi1)
        {
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = AsalSayi(sayi);
            if (sonuc == 0)
            {
                Console.WriteLine(" Asal Sayı Değildir."+ sayi);
            }
            else
            {
                Console.WriteLine(" Asal Sayıdır." + sayi);
            }
            
              return sayi;
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Parametre olarak yollanan bir sayının asal sayı olup olmadığını geriye döndüren bir metot yazınız. Eğer sayı asal ise geriye “true” değil ise “false” değeri döndürülecektir.
        }
    }
}
