using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSqlÖrneği
{
    // sistem yazacaksın ve herbirde farklı teknolohi kullanacaksın
    //hepsinde ayrı yapman lazımo yüzden class oluştur. Ve her sql uygulamasında aynı şeyler olacağı için Interface oluşturulur.

    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());//sql e ekledi.
            customerManager.Add(new OracleServerCustomerDal());
            Console.ReadLine();

        }
    }
}
