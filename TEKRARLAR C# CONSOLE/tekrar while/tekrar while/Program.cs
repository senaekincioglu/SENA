using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tekrar_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden tek sayı girilene kadar sayı isteyen ve tek girildiğinde tek sayı girdiniz yazan
            //program.



            try

            {
                Console.WriteLine("LÜTFEN BİR SAYI GİRİNİZ");
                int sayi = Convert.ToInt32(Console.ReadLine());



                while (sayi % 2 == 0)
                {
                    Console.WriteLine("Lütfen sayı giriniz");
                    sayi = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine("TEK SAYI GİRDİNİZ");
            }
            catch
            {
                Console.Write("giriş dizesi doğru değil");
            }

            

            Console.ReadLine();


        }
    }

}