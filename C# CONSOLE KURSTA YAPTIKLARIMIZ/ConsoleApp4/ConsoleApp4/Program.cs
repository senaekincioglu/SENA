using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen bir cümlenin tersini yazdıran program.
            Console.Write("Cümle girin= ");
            string cumle = Convert.ToString(Console.ReadLine());      
            Console.WriteLine("Metnimizin ters hali");
            for (int i = cumle.Length-1; i >=0; i--)//0 ı alır ondan dolayı -1
            {
                Console.Write(cumle[i]);
            }
            Console.ReadLine();
        }
    }
}
