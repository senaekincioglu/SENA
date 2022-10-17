using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Program
    {//kalıtım 


        //kalıtım ile Interface arasındaki fark : 
        //**interface newlenemez kalıtım new lenir
        //interface soyut kalıtım somut
        //**kalıtım bir class tan miras alır,interface birden fazla classtan implet edilir.
        class User//Genel
        {
            public string İnsan { get; set; }
            public string FirstName { get; set; }
            public string Lastname { get; set; }
        }

        class Student : User
        {
            public string Departman { get; set; }
        }

        class Customer : User
        {
            public string Adress { get; set; }
        }



        static void Main(string[] args)
        {
            User[] user = new User[]
            {
                new Student { FirstName = "Büşra",Lastname="Atmaca" },
                new Customer { FirstName = "Sena" }//hepsine ait olanın classı

            };
            foreach(var item in user)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }
}
