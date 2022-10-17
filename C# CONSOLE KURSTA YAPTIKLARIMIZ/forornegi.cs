using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(" ");
                for (int j = 3-i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2*i+1; k++)
                {
                    Console.Write("*");
                }
                for (int z = 0; z < i; z++)
                {
                    Console.Write("*");
                }


            } 

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <4; j++)
                {
                    Console.WriteLine(" ");
                }
                for (int k = 5-(i*2); k>0; k--)
                {
                    Console.Write("*");
                }
            }
            Console.ReadLine();
            }
     
    }
}
