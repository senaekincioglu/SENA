using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSqlÖrneği
{
    interface ICustomerDal//Interface Ortakları yazıyorsun metot gibi ama ismi yok void yanında
    {
        void Update();
        void Delete();
        void Add();

    }
    class SqlServerCustomerDal : ICustomerDal //Class(Interface ortak olandan çekiyor
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Sql Add");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Sql Delete");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Sql Update");

        }
    }
    class OracleServerCustomerDal : ICustomerDal //Class(Interface ortak olandan çekiyor
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Oracle Add");

        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Oracle Delete");

        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Oracle Update");

        }
    }
    class CustomerManager //İşlemleri yapacağın class
    {
        public void Add(ICustomerDal customerDal)//sadece Interface (sql ve oracle yok
        {
            customerDal.Add();  
        }
    }
}

