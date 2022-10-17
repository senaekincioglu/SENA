using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //seçilen birdaha seçilmiyor. bunu ödev yap
            //15 kişiyi 3 e böleceksin. yani gruplayarak random atacak ve araya boşluk atacak
            string[] isimler = { "Sena", "büşra", "Erhan", "Mertk", "Mertt", "Mısra", "Devrim", "bedirhan",
                "salih", "Muhammet Bedir",  "Devrim" };
            Random rnd = new Random();
            string[] isimler2 = new string[isimler.Length];

            for (int i = 0; i < isimler.Length; i++)
            {

                int rastgele = rnd.Next(0, isimler.Length);
                if (isimler2.Contains(isimler[rastgele]))
                {
                    i--;
                }
                else
                {
                    isimler2[i] = isimler[rastgele];
                    Console.WriteLine(isimler[rastgele]);

                }
            }
            //for (int i = 0; i < ; i++)
            //{
            //    Console.WriteLine();
            //}
            foreach (var aa in isimler)
            {
                //Dizinin tüm eleman sayılarını yazdırıyor
                Console.WriteLine(aa);
            }


        }
    }
}
