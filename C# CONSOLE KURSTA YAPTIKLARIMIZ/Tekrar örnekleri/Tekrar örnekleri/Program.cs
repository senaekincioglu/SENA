using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar_örnekleri
{
    internal class Program
    {
        private void Toplama()
        {
            start:
            int puan = 0;
            int sayacd = 0;
            int sayacy = 0;
            Console.Clear();
        ab:
            
            int toplam = 0;
            
            Random rnd = new Random();
            int sayi1 = rnd.Next(1, 101);
            int sayi2 = rnd.Next(1, 101);
            Console.WriteLine("sayi1= " + sayi1 + " sayi2= " + sayi2);
            Console.WriteLine("Bu sayıların toplamı nedir? ");
            int kullanıcı = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            
            if(toplam==kullanıcı)
            {
                Console.WriteLine("Tebrikler bildiniz ");
                puan += 5;
                sayacd++;
            }
            else
            {
                Console.WriteLine("Üzgünüm bilemediniz "+toplam);
                puan += -2;
                sayacy++;
            }
            Console.WriteLine("Puanınız" + puan);
            Console.WriteLine("Tekrar oynamak istiyor musunuz (e / E) ?");
            char ea = Convert.ToChar(Console.ReadLine());
            if(ea=='e'||ea=='E')
            {
                goto ab;
            }
            else if(ea == 'h' || ea == 'H')
            {
                
                Console.WriteLine("Oyun bitti");
                


            }
            //if (toplam == kullanıcı)
            //{
            //    puan = puan + 5;
            //    sayacd++;
            //}
            //else
            //{
            //    puan = puan - 2;
            //    sayacy++; ;
            //}
            //Console.WriteLine("Puanınız" + puan);
            
            Console.WriteLine("Doğru cevap= " + sayacd);
            Console.WriteLine("Yanlış cevap= " + sayacy);
            goto start;
           
        }
        static void Main(string[] args)
        {
            //Toplama işlemini öğretmeye çalışan bir oyun programı yazılacaktır. Oyun başladığı zaman rastgele
            //2tane 1 - 100 arasında sayı tutulacak, tutulan sayılar ekrana gösterilecek ve kullanıcıya bu sayıların toplamı nedir diye sorulacaktır. Eğer kullanıcı doğru cevap verirse “Tebrikler Bildiniz” değil ise “Üzgünüm Bilemediniz” diye mesaj verecektir.Her cevaptan sonra “Tekrar Oynamak istiyormusunuz(e / E) ?” şeklinde bir soru sorulacak ve eğer kullanıcı “e” veya “E” ile karşılık verirse oyun tekrar başlayacaktır. Kullanıcının puanı her doğru cevap için 5 puan artacak, her yanlış cevap için ise 2 puan azalacaktır. Oyun sonlandığında kullanıcının verdiği doğru cevap sayısı, yanlış cevap sayısı ve puanı ekranda listelenmelidir.Bu işlemleri yapan programın kodlarını yazınız.
            Program prg = new Program();
            prg.Toplama();
            Console.ReadLine();

        }
    }
}
