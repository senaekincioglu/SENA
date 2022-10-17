using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖRNEKLEEER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aynı firmada çalışan ahmet ve hasan, ahmetin aylık ücreti  ay %50 artmakta sonraki ay %25 azalmaktadır. hasanın ise ücreti her ay %25artmaktadır. her ikisinin de yılbaşındaki başlangıç ücretleri ve hesaplanacak ay bilgisi klavyeden girildikten sonra ay ay ücretlerinin ne olacağını ve en sonunda hangi işçinin daha fazla veya eşit ücret alacağını hesaplayan programı yazın. 

            //Console.Write("Hasanın başlangıç ücretini girin= ");
            //double maash = Convert.ToDouble(Console.ReadLine());
            double ahmetM = 0, hasanM = 0;
            int ay;
            Console.Write("Ahmetin başlangıç maaşını girin= ");
            ahmetM = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hasanın başlangıç maaşı nı girin= ");
            hasanM = Convert.ToDouble(Console.ReadLine());

            Console.Write("ay girin= ");
            ay = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ay; i++)
            {
                if (i%2==0)//çift aylar için
                {
                    ahmetM = ahmetM + (ahmetM * 50 / 100);
                }
                else
                {
                    ahmetM = ahmetM - (ahmetM * 25 / 100);
                }
            }
            Console.WriteLine("Ahmetin maaşı= " + ahmetM);
            for (int i = 0; i < ay; i++)
            {
                hasanM = hasanM + (hasanM * 25 / 100);
            }
            Console.WriteLine("Hasanın maaşı= " + hasanM);
            if (ahmetM>hasanM)
            {
                Console.WriteLine("Ahmetin maaşı hasanın maaşından fazladır.");
            }
            else
            {
                Console.WriteLine("Hasanın maaşı ahmetin maaşından fazladır.");
            }
            Console.ReadLine();


        }
        }
    }

