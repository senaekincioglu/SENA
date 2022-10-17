using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {//Interface: Enbüyük kullanım amacı : temel nesne oluşturup bütün nesneleri onda toplamak.
        //INTERFACE NEW LENEMEZ.

        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();//class için new oluşturdu
            manager.Add(new Customer { Id = 1, FirstName = "Sena", LastName = "Eknc" });//classtaki değerleri çağırdı
            Console.ReadLine();

            Customer customer = new Customer();
            customer.Id = 1;

            Console.ReadLine();
            

        }
    }   
    class Customer : Interface1//(ınterface ortak) //Müşteri(müşteri de bi insandır)
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public string Address{ get; set; }  
    }
    class Student : Interface1 //(ınterface ortak) //Öğrenci (Öğrenci de bi insandır)
    {
        public int Id { get; set; } 
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager //Burda customer yazdığın için mainde
                        //onu yazdırırsın
    {
        public void Add(Customer customer)//Müşteri tipinde parametre ver Metot oluşturdu
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}
