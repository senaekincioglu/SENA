using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            long tc = -1;
            string adSoyad = " ";
            string adres = " ";
            string telefon = " ";
            int secim;

            PersonelEkle(7173677834, "Mehmet Demir", "İstanbul ..", "0546......");
            PersonelEkle(7777777777, "Hasan Emir", "İstanbul ..", "0544......");
            PersonelEkle(8888888888, "Ahmet Emin", "İstanbul ..", "0534......");
            PersonelEkle(9999999999, "Kerem Temiz", "İstanbul ..", "0549......");
            PersonelEkle(5655555555, "Kerim Demir", "İstanbul ..", "0539......");
            do
            {
            giris:
                Console.WriteLine("Yapılacak işlemi seçiniz" + "\n" + "1-Personel Ekle" + "\n" + "2-Personel Ara" + "\n" + "3-Personel Sil" + "\n" + "4-Personel Güncelle " + "\n" + "5-Tüm Personelleri göster" + "\n" + "0-Çıkış");
                secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    for (int i = 0; ; i++)
                    {
                        Console.WriteLine("Eklenecek personelin Tcsini giriniz:");
                        tc = Convert.ToInt64(Console.ReadLine());                        
                        Console.WriteLine("Eklenecek personelin Adı ve soyadını giriniz:");
                        adSoyad = Console.ReadLine();
                        Console.WriteLine("Eklenecek personelin adresini giriniz:");
                        adres = Console.ReadLine();
                        Console.WriteLine("Eklenecek personelin telefon numarasını giriniz:");
                        telefon = Console.ReadLine();
                        PersonelEkle(tc, adSoyad, adres, telefon);
                        giris2:
                        Console.WriteLine("Ekleme yapmaya devam etmek istiyor musunuz?" + "\n" + "1-Evet" + "\n"+"2-Hayır");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 2)
                            break;
                        else if (secim2 > 2 || secim2 < 1)
                        {
                            Console.WriteLine("Hatalı tuşlama yaptınız.Lütfen tekrar deneyiniz");
                            goto giris2;
                        }
                    }
                }
                
                if (secim == 2)
                {
                    for (int i = 0; ; i++)
                    {
                        string pad = "";
                        long ptc = 0;
                        Console.WriteLine("Aranacak personelin Tcsini giriniz:");
                        ptc = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Aranıcak personelin adını giriniz:");
                        pad = Console.ReadLine();

                        string bulunan = PersonelAra(ptc, pad);
                        if (bulunan != "")
                            Console.WriteLine("Aradığınız isim personel listesimizde bulunmaktadır.Kişisel bilgileri şunlardır:" + "\n" + bulunan);
                        else
                            Console.WriteLine("Aradığınınız isim personel listesinde bulunmamaktadır.");
                        giris2:
                        Console.WriteLine("Aramaya yapmaya devam etmek istiyor musunuz?" + "\n" + "1-Evet" + "\n" + "2-Hayır");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 2)
                            break;
                        else if (secim2 > 2 || secim2 < 1)
                        {
                            Console.WriteLine("Hatalı tuşlama yaptınız.Lütfen tekrar deneyiniz");
                            goto giris2;
                        }
                    }
                }
                if (secim == 3)
                {
                    for (int i = 0; ; i++)
                    {
                        long ptc = 0;
                        Console.WriteLine("Silinecek personelin Tcsini giriniz:");
                        ptc = Convert.ToInt64(Console.ReadLine());
                        PersonelSil(ptc);
                    giris2:
                        Console.WriteLine("Silme işlemine yapmaya devam etmek istiyor musunuz?"+"\n"+"1-Evet" + "\n" + "2-Hayır");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 2)
                            break;
                        else if (secim2 > 2 || secim2 < 1)
                        {
                            Console.WriteLine("Hatalı tuşlama yaptınız.Lütfen tekrar deneyiniz");
                            goto giris2;
                        }
                    }                
                }
                if (secim == 4)
                {
                    for (int i = 0; ; i++)
                    {
                        Console.WriteLine("Güncellenecek personelin Tcsini giriniz:");
                        tc = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Güncellenecek personelin Adı ve soyadını giriniz:");
                        adSoyad = Console.ReadLine();
                        Console.WriteLine("Güncellenecek personelin adresini giriniz:");
                        adres = Console.ReadLine();
                        Console.WriteLine("Güncellenecek personelin telefon numarasını giriniz:");
                        telefon = Console.ReadLine();
                        PersonelGuncelle(tc, adSoyad, adres, telefon);
                    giris2:
                        Console.WriteLine("Güncelleme yapmaya devam etmek istiyor musunuz?"+"\n"+"1-Evet" + "\n" + "2-Hayır");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 2)
                            break;
                        else if (secim2 > 2 || secim2 < 1)
                        {
                            Console.WriteLine("Hatalı tuşlama yaptınız.Lütfen tekrar deneyiniz");
                            goto giris2;
                        }
                    }
                }
                if (secim == 5)
                {
                    for (int i = 0; i < Tcler.Count; i++)
                    {
                        Console.WriteLine("TC:" + Tcler[i]);
                        Console.WriteLine("Ad Soyad:" + adSoyadlar[i]);
                        Console.WriteLine("Adres:" + adresler[i]);
                        Console.WriteLine("Telefon:" + telefonlar[i]);
                        Console.WriteLine("-------------------------");
                    }
                    Console.WriteLine("İşlem yapmaya devam etmek istiyor musunuz?" + "\n" + "1-Evet" + "\n" + "2-Hayır");
                    int secim2 = Convert.ToInt32(Console.ReadLine());
                    if (secim2 == 2)
                        break;
                    else if (secim2 > 2 || secim2 < 1)
                    {
                        Console.WriteLine("Hatalı tuşlama yaptınız.Lütfen tekrar deneyiniz");
                        goto giris;
                    }
                    /*foreach (var item in adSoyadlar)
                    {
                        Console.WriteLine(item);
                    }*/                    
                }
                if (secim > 6 || secim < 0)
                {
                    Console.WriteLine("Hatalı tuşladınız.Lütfen tekrar deneyiniz.");
                    goto giris;
                }
            } while (secim != 0);
            Console.WriteLine("İşlem sonlandırıldı.İyi günler dileriz.");
            Console.ReadLine();
        }

        static List<long> Tcler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();

        static void PersonelEkle(long tc, string adSoyad = "", string adres = " ", string telefon = " ")
        {
            if (tc != 0)
            {
                Tcler.Add(tc);
                adSoyadlar.Add(adSoyad);
                adresler.Add(adres);
                telefonlar.Add(telefon);
            }
        }

        static string PersonelAra(long tc = 0, string adSoyad = "")
        {
            string personel = "";
            int personelIndex = -1;//listede -1 olmayacağı için,-1 bulunmadığı anlamına gelir.
            if (adSoyad != "")
            {
                if (adSoyadlar.Contains(adSoyad) == true)
                {
                    personelIndex = adSoyadlar.IndexOf(adSoyad);
                }
            }
            else if (tc != 0)
            {
                if (Tcler.Contains(tc) == true)
                {
                    personelIndex = Tcler.IndexOf(tc);
                }
            }
            if (personelIndex != -1)
            {
                personel = Convert.ToString(Tcler[personelIndex]) + " " + adSoyadlar[personelIndex] + " " +
                adresler[personelIndex] + " " + telefonlar[personelIndex];
            }
            return personel;
        }
        static void PersonelSil(long tc = 0)
        {
            int personelIndex = -1;
            if (tc != 0)
            {
                if (Tcler.Contains(tc) == true)
                {
                    personelIndex = Tcler.IndexOf(tc);
                    Tcler.Remove(personelIndex);
                }
            }
            if (personelIndex != -1)
            {
                Tcler.RemoveAt(personelIndex);
                adresler.RemoveAt(personelIndex);
                adSoyadlar.RemoveAt(personelIndex);
                telefonlar.RemoveAt(personelIndex);
            }
        }

        static void PersonelGuncelle(long tc, string AdSoyad, string adres, string telefon)
        {
            if (tc != 0)
            {
                int personelIndex = Tcler.IndexOf(tc);
                if (personelIndex != -1)
                {
                    PersonelAra(tc);
                    adSoyadlar[personelIndex] = AdSoyad;
                    adresler[personelIndex] = adres;
                    telefonlar[personelIndex] = telefon;
                }
            }
        }
    }
}
    

