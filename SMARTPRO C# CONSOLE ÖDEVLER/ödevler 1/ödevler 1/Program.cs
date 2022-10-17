using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödevler_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //Console.ReadLine();

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                if (i == 5)
                {
                    for (int k = 0; k < 24; k++)
                    {
                        Console.Write("-");
                    }


                }
                
                Console.WriteLine();
                
            }
            Console.WriteLine();
            //Console.ReadLine();


            for (int i=0;i<5;i++)
            {
                for(int j=4;j>i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=0;k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}
