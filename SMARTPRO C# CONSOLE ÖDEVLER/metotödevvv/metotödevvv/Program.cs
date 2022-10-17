using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotödevvv
{
    internal class Program
    {
       bool Bul(string kelime, string cümle)
        {
            bool durum = true;
            if (cümle.IndexOf(kelime) == -1)
            {
                durum = false;
            }

            return durum;
            static void Main(string[] args)
            {
                Program program = new Program();

                Console.WriteLine(program.Bul("ali", "sena"));
                Console.ReadLine();
            }
        }
    }
}
