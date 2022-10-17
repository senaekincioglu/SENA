using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar_Örneği_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();//class ismi ile her zaman new oluşturmak zorundasın
            customerManager.Ad();// new ile customerManager nesnesi oluşturularak oluşturduğumuz nesne ile class ı çağırdık.
            customerManager.Update();// new ile customerManager nesnesi oluşturularak oluşturduğumuz nesne ile class ı çağırdık.
            Console.ReadLine(); 
        }
    }
    class CustomerManager //Class oluşturuldu ( istediğimiz işlemleri gruplara ayırır )
    {
        public void Ad()//Class a ait metot oluşturuldu (metot:burada bir kez yazarak istediğin yerde çağırabilirsin.)
        {
            Console.WriteLine("Customer Added");//Ad metodunu çağırdığında customer added yazacak
        }
        public void Update() //Classa ait metot oluşturuldu
        {
            Console.WriteLine("Customer Update"); //Update metodunu çağırdığında customer uptade yazacak
        }

       
    }

    class KarayoluTaşıtları
    {
        public void ArabaIsimleri()
        {
            Console.Write("Arabalar");
            Console.Write("Otobüs0)
        }
       
    }
}
