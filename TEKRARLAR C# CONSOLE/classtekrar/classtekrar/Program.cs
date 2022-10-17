using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtekrar //Bu proje oluyor. Bir işyerinde müşteri ile ilgili işlemler ve
    //ürün ile ilgili işlemler gruplanmış oldu.
{
    internal class Program
    {
        //Class : bizim yapmak istediğimiz işlemleri gurplara ayırır ve o grup üzerinden işlemleri yapmak ve rahatlıkla o gruplara ulaşmak için kullanılır
        static void Main(string[] args) //classlar ve içindeki metotlar burada çağrılır. class ismi ile new açarsın ve oluşturduğun nesne ile çağırırsın.
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();//Customer sınıfına ait özellikleri tanımlayacağımız sınıf.

            customer.City = "İstanbul";
            customer.FirstName = "Sena";
            customer.LastName = "Ekincioğlu";
            customer.Id = 1;

            //veya

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Sena",
                LastName = "Eknc"
            };
            Console.WriteLine(customer2.LastName);//Müşteri ile ilgili istediğini ekrana yazdırabilirsin
            Console.WriteLine(customer.firstname);

            Console.ReadLine();
        }
    }

    class CustomerManager //Müşteri yöneticisi class ı açıldı.(müşteri ile ilgili işlemleri koyar)
    {
        public void Add()
        {
            Console.WriteLine("Customer Add");
        }
        public void Update()
        {
            Console.WriteLine("Customer Update");
        }
    }
    class ProductManager //Ürün yöneticisi class ı açıldı.(ürün ile ilgili işlemleri koyar)
    {
          public void Add()
        {
            Console.WriteLine("Product Add");
        }
         public void Update()
        {
            Console.WriteLine("product update");
        }

        }
}

