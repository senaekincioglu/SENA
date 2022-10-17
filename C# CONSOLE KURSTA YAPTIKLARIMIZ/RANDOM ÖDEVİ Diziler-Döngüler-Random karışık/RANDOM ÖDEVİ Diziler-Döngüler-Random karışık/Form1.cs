namespace RANDOM_ÖDEVİ_Diziler_Döngüler_Random_karışık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //Göster butonuna tıklandığında 1 den 49 a kadar olan 6 tane rastgele olan sayıyı listboxa ekleyen program
            lstRastgelesayilar.Items.Clear();
            lstRastgelesayilar.Text = "";
            int[] sayilar = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                //Sayılar dizisindeki i indeksini yani her bir sayilar dizisindeki 6 elemanı ayrı ayrı 0 ile 49 arasında rastgele seçeceği için for kullandım
                //sayilar[i] = rnd.Next(0, 50);
                int rastgeleSayi = rnd.Next(0, 50);
                if (sayilar.Contains(rastgeleSayi))
                {
                    i--;
                }
                else
                {
                    sayilar[i] = rastgeleSayi;
                    //lstRastgelesayilar.Items.Add(sayilar[i]);
                }

                //    for (int j = 0; j < i; j++)
                //    {
                //        while(sayilar[i] == sayilar[j])//sayilar i sayılar j ye eşitken i yi eksilt tekrar döndür ama bunu
                //        ifle de yaptım 
                //        {
                //            i--;
                //        }
                //}
            }

            foreach (int sayi in sayilar)
            {
                //Dizinin tüm eleman sayılarını yazdırıyor
                lstRastgelesayilar.Items.Add(sayi);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            lstRastgelesayilar.Items.Clear();
        }
    }
}