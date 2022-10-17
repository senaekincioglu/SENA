using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dama_oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
      
       
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(40 * (j + 1), 50 * (i + 1));

                    button.Size = new Size(40, 40);
                   
                    this.Controls.Add(button);
                   
                    
                    if ((i+j) % 2 == 0)
                    {
                        button.BackColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = Color.Black;
                    }

                }
            }
        }
    }
}
