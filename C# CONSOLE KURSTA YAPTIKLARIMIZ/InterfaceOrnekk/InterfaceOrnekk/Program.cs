using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnekk
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //interface yenilenemez. classların ortak özelliğinde kullanılır(ad gibi) soyut sınıftır.

            Interfacee[] veri = new Interfacee[2]//sınıflar
            {
                new SqlServer(),
                new OracalServer(),
                new Mssql()
            };
            foreach(var item in veri)
            {
                item.Update();
            }
        }
        
    }
}
