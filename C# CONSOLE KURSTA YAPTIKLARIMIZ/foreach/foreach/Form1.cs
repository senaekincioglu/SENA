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
        //Butona t�kland���nda Her b�lgeden toplam 7 �ehir yazd�r�ls�n yazd�r�lan �ehri foreach ile listeletelim
        string[] sehirler = { "mersin", "izmir", "kocaeli", "artvin", "ankara", "erzurum", "�anl�urfa" };
        foreach(string i in sehirler)
        {
            listBox1.Items.Add(i);
        }

    }
}

}