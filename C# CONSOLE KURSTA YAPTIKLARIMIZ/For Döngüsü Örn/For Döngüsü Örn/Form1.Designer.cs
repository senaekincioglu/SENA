namespace For_Döngüsü_Örn_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGoster = new System.Windows.Forms.Button();
            this.lblSayilar = new System.Windows.Forms.Label();
            this.lblTeksayilar = new System.Windows.Forms.Label();
            this.lblCiftsayilar = new System.Windows.Forms.Label();
            this.btnKoy = new System.Windows.Forms.Button();
            this.lstKoy = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.lstEkle = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnlst = new System.Windows.Forms.Button();
            this.lstAdadet = new System.Windows.Forms.ListBox();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.lstSayilar = new System.Windows.Forms.ListBox();
            this.btnGeriye = new System.Windows.Forms.Button();
            this.lstGeriye = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lstSayi = new System.Windows.Forms.ListBox();
            this.btnSayi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(25, 44);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 0;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSayilar
            // 
            this.lblSayilar.AutoSize = true;
            this.lblSayilar.Location = new System.Drawing.Point(25, 88);
            this.lblSayilar.Name = "lblSayilar";
            this.lblSayilar.Size = new System.Drawing.Size(41, 15);
            this.lblSayilar.TabIndex = 1;
            this.lblSayilar.Text = "Sayılar";
            // 
            // lblTeksayilar
            // 
            this.lblTeksayilar.AutoSize = true;
            this.lblTeksayilar.Location = new System.Drawing.Point(25, 133);
            this.lblTeksayilar.Name = "lblTeksayilar";
            this.lblTeksayilar.Size = new System.Drawing.Size(61, 15);
            this.lblTeksayilar.TabIndex = 2;
            this.lblTeksayilar.Text = "Tek Sayılar";
            // 
            // lblCiftsayilar
            // 
            this.lblCiftsayilar.AutoSize = true;
            this.lblCiftsayilar.Location = new System.Drawing.Point(25, 173);
            this.lblCiftsayilar.Name = "lblCiftsayilar";
            this.lblCiftsayilar.Size = new System.Drawing.Size(63, 15);
            this.lblCiftsayilar.TabIndex = 3;
            this.lblCiftsayilar.Text = "Çift Sayılar";
            // 
            // btnKoy
            // 
            this.btnKoy.Location = new System.Drawing.Point(106, 44);
            this.btnKoy.Name = "btnKoy";
            this.btnKoy.Size = new System.Drawing.Size(118, 23);
            this.btnKoy.TabIndex = 4;
            this.btnKoy.Text = "Koy";
            this.btnKoy.UseVisualStyleBackColor = true;
            this.btnKoy.Click += new System.EventHandler(this.btnKoy_Click);
            // 
            // lstKoy
            // 
            this.lstKoy.FormattingEnabled = true;
            this.lstKoy.ItemHeight = 15;
            this.lstKoy.Location = new System.Drawing.Point(106, 73);
            this.lstKoy.Name = "lstKoy";
            this.lstKoy.Size = new System.Drawing.Size(118, 154);
            this.lstKoy.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(239, 204);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(239, 45);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(100, 23);
            this.txtEkle.TabIndex = 7;
            // 
            // lstEkle
            // 
            this.lstEkle.FormattingEnabled = true;
            this.lstEkle.ItemHeight = 15;
            this.lstEkle.Location = new System.Drawing.Point(239, 73);
            this.lstEkle.Name = "lstEkle";
            this.lstEkle.Size = new System.Drawing.Size(100, 124);
            this.lstEkle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adet";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(392, 45);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(72, 23);
            this.txtAd.TabIndex = 11;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(392, 74);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(72, 23);
            this.txtAdet.TabIndex = 12;
            // 
            // btnlst
            // 
            this.btnlst.Location = new System.Drawing.Point(379, 114);
            this.btnlst.Name = "btnlst";
            this.btnlst.Size = new System.Drawing.Size(100, 23);
            this.btnlst.TabIndex = 13;
            this.btnlst.Text = "EKLE.";
            this.btnlst.UseVisualStyleBackColor = true;
            this.btnlst.Click += new System.EventHandler(this.btnlst_Click);
            // 
            // lstAdadet
            // 
            this.lstAdadet.FormattingEnabled = true;
            this.lstAdadet.ItemHeight = 15;
            this.lstAdadet.Location = new System.Drawing.Point(479, 44);
            this.lstAdadet.Name = "lstAdadet";
            this.lstAdadet.Size = new System.Drawing.Size(75, 64);
            this.lstAdadet.TabIndex = 14;
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(12, 252);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(100, 23);
            this.btnSayilar.TabIndex = 15;
            this.btnSayilar.Text = "Sayilar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // lstSayilar
            // 
            this.lstSayilar.FormattingEnabled = true;
            this.lstSayilar.ItemHeight = 15;
            this.lstSayilar.Location = new System.Drawing.Point(12, 281);
            this.lstSayilar.Name = "lstSayilar";
            this.lstSayilar.Size = new System.Drawing.Size(100, 124);
            this.lstSayilar.TabIndex = 16;
            // 
            // btnGeriye
            // 
            this.btnGeriye.Location = new System.Drawing.Point(124, 252);
            this.btnGeriye.Name = "btnGeriye";
            this.btnGeriye.Size = new System.Drawing.Size(100, 23);
            this.btnGeriye.TabIndex = 17;
            this.btnGeriye.Text = "Sayilar Geriye";
            this.btnGeriye.UseVisualStyleBackColor = true;
            this.btnGeriye.Click += new System.EventHandler(this.btnGeriye_Click);
            // 
            // lstGeriye
            // 
            this.lstGeriye.FormattingEnabled = true;
            this.lstGeriye.ItemHeight = 15;
            this.lstGeriye.Location = new System.Drawing.Point(124, 281);
            this.lstGeriye.Name = "lstGeriye";
            this.lstGeriye.Size = new System.Drawing.Size(100, 124);
            this.lstGeriye.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "SAYİ";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(275, 256);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSayi.Size = new System.Drawing.Size(72, 23);
            this.txtSayi.TabIndex = 20;
            // 
            // lstSayi
            // 
            this.lstSayi.FormattingEnabled = true;
            this.lstSayi.ItemHeight = 15;
            this.lstSayi.Location = new System.Drawing.Point(239, 285);
            this.lstSayi.Name = "lstSayi";
            this.lstSayi.Size = new System.Drawing.Size(108, 79);
            this.lstSayi.TabIndex = 21;
            // 
            // btnSayi
            // 
            this.btnSayi.Location = new System.Drawing.Point(239, 370);
            this.btnSayi.Name = "btnSayi";
            this.btnSayi.Size = new System.Drawing.Size(108, 23);
            this.btnSayi.TabIndex = 22;
            this.btnSayi.Text = "Sayı Ekle";
            this.btnSayi.UseVisualStyleBackColor = true;
            this.btnSayi.Click += new System.EventHandler(this.btnSayi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 426);
            this.Controls.Add(this.btnSayi);
            this.Controls.Add(this.lstSayi);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstGeriye);
            this.Controls.Add(this.btnGeriye);
            this.Controls.Add(this.lstSayilar);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.lstAdadet);
            this.Controls.Add(this.btnlst);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEkle);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstKoy);
            this.Controls.Add(this.btnKoy);
            this.Controls.Add(this.lblCiftsayilar);
            this.Controls.Add(this.lblTeksayilar);
            this.Controls.Add(this.lblSayilar);
            this.Controls.Add(this.btnGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGoster;
        private Label lblSayilar;
        private Label lblTeksayilar;
        private Label lblCiftsayilar;
        private Button btnKoy;
        private ListBox lstKoy;
        private Button btnEkle;
        private TextBox txtEkle;
        private ListBox lstEkle;
        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtAdet;
        private Button btnlst;
        private ListBox lstAdadet;
        private Button btnSayilar;
        private ListBox lstSayilar;
        private Button btnGeriye;
        private ListBox lstGeriye;
        private Label label3;
        private TextBox txtSayi;
        private ListBox lstSayi;
        private Button btnSayi;
    }
}