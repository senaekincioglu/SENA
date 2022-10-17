namespace For_Döngüsü_Örn_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Göster tuşuna basıldığında 1 den 50 ye kadar olan sayıları, tek sayıları ve çift sayıları gösteren kod.
            for (int i = 1; i <= 50; i++)
            {
                lblSayilar.Text = lblSayilar.Text + " " + i;
                if (i % 2 == 1)
                {
                    lblTeksayilar.Text = lblTeksayilar.Text + " " + i;
                }
                else
                {
                    lblCiftsayilar.Text = lblCiftsayilar.Text + " " + i;
                }
            }
        }
        //Koy butonuna basıldığında Yazilimkodlama.com yazısını 10 kez listboxtda gösteren kod.
        private void btnKoy_Click(object sender, EventArgs e)
        {
            for(int i=1;i<=10;i++)
            {
                lstKoy.Items.Add("Yazilimkodlama.com");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Ekle butonuna tıklandığında textboxdaki değeri 10 defa listboxa yazdıran kod.


            for(int i=1;i<=10;i++)
            {
                lstEkle.Items.Add(txtEkle.Text);
            }


        }

        private void btnlst_Click(object sender, EventArgs e)
        {
            //Ekle butonuna basıldığında kullanıcının textboxa girdiği adı textboxa girdiği adet kadar yazdıran kod.
            int adet = Convert.ToInt32(txtAdet.Text);
            for(int i=1;i<=adet;i++)
            {
                lstAdadet.Items.Add(txtAd.Text);
            }
        }

        private void btnSayilar_Click(object sender, EventArgs e)
        {
            //Sayılar butonuna tıklandığında 1 den 100 e kadar olan sayıları listboxa ekleyen kod.
            for(int i=1;i<=100;i++)
            {
                lstSayilar.Items.Add(i);
            }
        }

        private void btnGeriye_Click(object sender, EventArgs e)
        {
            //Butona basıldığında 100 den 1 e kadar olan sayıları geriye doğru listboxa yazdıran kod.
            for(int i=100;i>=1;i--)
            {
                lstGeriye.Items.Add(i);
            }
        }

        private void btnSayi_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında 1 den kullanıcının girdiği sayıya kadar sayıları listboxa yazdıran kod.

            int sayi = Convert.ToInt32(txtSayi.Text);
            lstSayi.Text = " ";
            for (int i =1;i<=sayi;i++)
            {
                lstSayi.Items.Add(i.ToString());
                
            }
        }
    }
}