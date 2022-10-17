using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch_örnek
{
    internal class Program
    {
        public void Carpma()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = new int[5];//b=a*a
            int[] c = new int[5];//c=b*a
            Console.WriteLine("A Değeri");

            for (int i = 0; i < a.Length; i++)
            {
                b[i]=a[i]*a[i];
                Console.WriteLine(b[i]);
            }
            Console.ReadLine();
            for (int j = 0; j < b.Length; j++)
            {
                c[j] = a[j] * b[j];
                Console.WriteLine(c[j]);
            }
            Console.ReadLine();
           
        }
        static void Main(string[] args)
        {
            
            Program prg = new Program();
            prg.Carpma();
            Console.ReadLine();
        }
    }
}
