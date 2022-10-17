using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaÖrnek
{ 
    internal class Program
    {
        
        private void BankaKredi()
        {

            double sonuc, tutar = 0;
           
            Console.WriteLine("Welcome to Bank App");
            Console.WriteLine("Choose Bank:");
            Console.WriteLine("1. İş Bankası \n2. Garanti Bankası \n3. Ziraat Bankası");
            int banka = Convert.ToInt32(Console.ReadLine());
            switch(banka)
            {
                case 1: Console.WriteLine("İş bankası "+ "1 - Bireysel mi? 2-  Kurumsal mı?");
                    break;
                case 2:
                    Console.WriteLine("Garanti bankası " +"1- Bireysel mi? 2- Kurumsal mı?");
                    break;
                case 3:
                    Console.WriteLine("Ziraat bankası " + "1- Bireysel mi? 2- Kurumsal mı?");
                    break;
            }
            int secim = Convert.ToInt32(Console.ReadLine());
            double faiz = 1.9;
            double faiz2 = 1.5;
            switch (secim)
            {

                case 1: Console.WriteLine("Kredi tutarını girin = ");
                    tutar = Convert.ToDouble(Console.ReadLine());
                    sonuc = faiz * tutar;
                    Console.WriteLine("TOPLAM = "+sonuc);
                    break;
                case 2: Console.WriteLine("Kullanıcı adını girin : ");
                    string kullanıcıad = Convert.ToString(Console.ReadLine());
                    Console.Write("Şifre girin : ");
                    string sifre = Convert.ToString(Console.ReadLine());
                    Console.Write("Kredi tutarını girin = ");
                    tutar = Convert.ToDouble(Console.ReadLine());
                    sonuc = faiz2 * tutar;
                    Console.WriteLine("TOPLAM = "+sonuc);
                    
                    break;
                    
            }
           
            Console.WriteLine("Vade girin= ");
            double vade = Convert.ToDouble(Console.ReadLine());

            //anapara*faiz oranı*vade (gün)/36500

            sonuc = tutar * faiz * vade ;  
            
            for (int i = 1; i <= vade; i++)
            {
              
                Console.WriteLine(i + ". taksit = "+sonuc);
            }
        
            
            
        }
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.BankaKredi();

            Console.ReadLine();

        }
        }
    }

