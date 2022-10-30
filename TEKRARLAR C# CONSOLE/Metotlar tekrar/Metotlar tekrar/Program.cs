using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_tekrar
{
    
    internal class Program
    {
        
        private static int islem(int s1,int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.Write("");
            Console.Write(islem(2,5));
            Console.ReadLine();
        }
    }
}
