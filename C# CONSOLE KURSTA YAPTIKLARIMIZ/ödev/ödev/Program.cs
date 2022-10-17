using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //seçilen birdaha seçilmiyor. bunu ödev yap
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
            foreach (var aa in isimler)
            {
                //Dizinin tüm eleman sayılarını yazdırıyor
                Console.WriteLine(aa);
            }


        }
        static void Main(string[] args)
        {
            // 0 ile 15 arası diziler ile random atama
            Program prg = new Program();
            prg.Randomdizi();
            Console.ReadLine();
        }

    }
}
}
