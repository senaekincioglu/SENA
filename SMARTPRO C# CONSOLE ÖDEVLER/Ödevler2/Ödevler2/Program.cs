using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ödevler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<5;i++)
            {
                for(int j=4;j>i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=0;k<=i;k++)
                {
                    Console.Write("*");
                }
                for (int z = 0; z < i; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<3;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
