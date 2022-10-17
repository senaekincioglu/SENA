namespace DizilerDöngülerÖdev
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGirilensayi = new System.Windows.Forms.TextBox();
            this.btnKarebul = new System.Windows.Forms.Button();
            this.lstSayilar = new System.Windows.Forms.ListBox();
            this.btnUcuncusayfagec = new System.Windows.Forms.Button();
            this.btnGecbirinci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGirilensayi
            // 
            this.txtGirilensayi.Location = new System.Drawing.Point(5, 11);
            this.txtGirilensayi.Name = "txtGirilensayi";
            this.txtGirilensayi.Size = new System.Drawing.Size(127, 23);
            this.txtGirilensayi.TabIndex = 0;
            this.txtGirilensayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGirilensayi_KeyPress);
            // 
            // btnKarebul
            // 
            this.btnKarebul.Location = new System.Drawing.Point(5, 50);
            this.btnKarebul.Name = "btnKarebul";
            this.btnKarebul.Size = new System.Drawing.Size(127, 31);
            this.btnKarebul.TabIndex = 1;
            this.btnKarebul.Text = "Kare Bul";
            this.btnKarebul.UseVisualStyleBackColor = true;
            this.btnKarebul.Click += new System.EventHandler(this.btnKarebul_Click);
            // 
            // lstSayilar
            // 
            this.lstSayilar.FormattingEnabled = true;
            this.lstSayilar.ItemHeight = 15;
            this.lstSayilar.Location = new System.Drawing.Point(138, 11);
            this.lstSayilar.Name = "lstSayilar";
            this.lstSayilar.Size = new System.Drawing.Size(184, 379);
            this.lstSayilar.TabIndex = 2;
            // 
            // btnUcuncusayfagec
            // 
            this.btnUcuncusayfagec.Location = new System.Drawing.Point(327, 397);
            this.btnUcuncusayfagec.Name = "btnUcuncusayfagec";
            this.btnUcuncusayfagec.Size = new System.Drawing.Size(47, 23);
            this.btnUcuncusayfagec.TabIndex = 4;
            this.btnUcuncusayfagec.Text = "→";
            this.btnUcuncusayfagec.UseVisualStyleBackColor = true;
            this.btnUcuncusayfagec.Click += new System.EventHandler(this.btnUcuncusayfagec_Click);
            // 
            // btnGecbirinci
            // 
            this.btnGecbirinci.Location = new System.Drawing.Point(-8, 397);
            this.btnGecbirinci.Name = "btnGecbirinci";
            this.btnGecbirinci.Size = new System.Drawing.Size(47, 23);
            this.btnGecbirinci.TabIndex = 5;
            this.btnGecbirinci.Text = "←";
            this.btnGecbirinci.UseVisualStyleBackColor = true;
            this.btnGecbirinci.Click += new System.EventHandler(this.btnGecbirinci_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 417);
            this.Controls.Add(this.btnGecbirinci);
            this.Controls.Add(this.btnUcuncusayfagec);
            this.Controls.Add(this.lstSayilar);
            this.Controls.Add(this.btnKarebul);
            this.Controls.Add(this.txtGirilensayi);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtGirilensayi;
        private Button btnKarebul;
        private ListBox lstSayilar;
        private Button btnUcuncusayfagec;
        private Button btnGecbirinci;
    }
}