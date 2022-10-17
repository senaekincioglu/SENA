using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen bir cümleyi yazdırılacak ve kullanıcı cümle girdikten sonra enter tuşuna bastığı zaman ilk kullanıcının girdiği cümleyi yazdıracak ve sonra ise cümle tersten şifreli olarak ekrana
            //yazılacak.

            //a yerine?, e yerine*, ı veya i yerineise =o veya ö yerine ise &, u veya ü yerine + yazılacak.
            //cümlede kaç tane şifrelenmiş kaç tane şifrelenmemiş onu da yaz
            int sayac = 0;
            char harf;
            Console.Write("Lütfen bir kelime giriniz= ");
            string kelime = Convert.ToString(Console.ReadLine());
            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                Console.Write(kelime[i]);
                harf = kelime[i];
                if (harf == 'a' || harf == 'A')
                {
                    harf = '?';
                    sayac++;


                }
                else if (harf == 'e' || harf == 'e')
                {
                    harf = '*';
                    sayac++;


                }
                else if (harf == 'o' || harf == 'ö')
                {
                    harf = '&';
                    sayac++;


                }
                if (harf == 'u' || harf == 'ü')
                {
                    harf = '+';
                    sayac++;


                }
                Console.WriteLine(harf);
            }
            
            Console.WriteLine("HARF " + sayac + "  KEZ KULLANILMIŞTIR");
            Console.ReadLine();

            //string cumle; char harf;
            //Console.Write("Cümleyi girin= ");
            //cumle = Console.ReadLine();
            //Console.Write("Girilen cümle " + cumle);
            //Console.Write("Şifreli hali ");
            //int sifreli = 0;
            //for (int i = cumle.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(cumle[i]);
            //    harf = cumle[i];
            //    if(harf=='a')
            //    {
            //        harf = '?';
            //        sifreli++;
            //    }
            //  else  if (harf == 'e')
            //    {
            //        harf = '*';
            //        sifreli++;
            //    }
            //  else  if (harf == 'ı'||harf=='i')
            //    {
            //        harf = '=';
            //        sifreli++;
            //    }
            // else   if (harf == 'o'||harf=='ö')
            //    {
            //        harf = '&';
            //        sifreli++;
            //    }
            //  else  if (harf == 'u'||harf=='ü')
            //    {
            //        harf = '+';
            //        sifreli++;
            //    }
            //    else if(i==0)
            //    {
            //        Console.WriteLine("harf= " + harf);

            //    }
            //    else
            //    {
            //        Console.Write("harf= " + harf);
            //    }
               

            //}
            //Console.WriteLine(sifreli+cumle.Length-sifreli);
            //Console.ReadLine();





        }
    }
}
