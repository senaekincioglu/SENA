using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomdizigruplayarakvesilerek
{
    internal class Program
    {
        private void Randomdizi()//metot ile yapıldı.
        {
            //random ile atılan isimlerin atılanlarını silecek ve gruplayacak.
            string[] isimler = { "Sena", "büşra", "Erhan", "Mertk", "Mertt", "Mısra",
                 "bedirhan", "salih", "Muhammet Bedir", "Devrim" };
            Random rnd = new Random();
            string[] isimler2 = new string[isimler.Length];
            Console.WriteLine("Kaç kişilik grup= ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int grupsayisi;
            grupsayisi = isimler.Length / sayi;
            Console.WriteLine();
            Console.WriteLine();
            for (int j = 0; j < grupsayisi; j++)
            {
                Console.WriteLine();
                Console.WriteLine("{0}.grup", j + 1);
                Console.WriteLine();
                int i = 0;
                for ( i = j*sayi; i < sayi*(j+1); i++)
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
