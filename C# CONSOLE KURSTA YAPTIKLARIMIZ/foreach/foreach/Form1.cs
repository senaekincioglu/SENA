using System.Runtime.ConstrainedExecution;

namespace foreach;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //Butona týklandýðýnda Her bölgeden toplam 7 þehir yazdýrýlsýn yazdýrýlan þehri foreach ile listeletelim
        string[] sehirler = { "mersin", "izmir", "kocaeli", "artvin", "ankara", "erzurum", "þanlýurfa" };
        foreach(string i in sehirler)
        {
            listBox1.Items.Add(i);
        }

    }
}

}