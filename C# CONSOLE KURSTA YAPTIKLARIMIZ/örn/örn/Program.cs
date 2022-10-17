using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int faktoriyel=1;
            Console.Write("Sayı girin= ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            while(sayi>1)
            {
                faktoriyel = faktoriyel * sayi;
                sayi--;
               
            }
            Console.WriteLine(faktoriyel);
            Console.ReadLine();
        }
    }
}
