using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2
{
    internal class Program
    {
       
        private void hesapMakinesi()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 100);
            Console.Write("Sayı girin= ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Random sayı= "+random);
            Console.WriteLine("seçim yapın= ");
            string deger = Convert.ToString(Console.ReadLine());
            switch (deger)
            {
                case "+":
                    Console.WriteLine(sayi1+random);
                    break;

                case "-":
                    Console.WriteLine(sayi1 - random);
                    break;

                case "*":
                    Console.WriteLine(sayi1 *random);
                    break;

                case "/":
                    Console.WriteLine(sayi1 / random);
                    break;

                default:Console.WriteLine("Hatalı seçim");
                    break;
            }
            

        }
        static void Main(string[] args)
        {
            //metotları kullanarak sayi klavyede girilecek diğeri random atılacak bu sayıların dört işlemini yap.
            Program prm = new Program();
            prm.hesapMakinesi();
            Console.ReadLine();
           
            
          
        }
    }
}
