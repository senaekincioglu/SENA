namespace CafeÖdeviWindowsForms
{
    partial class Form1
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
            this.chcKola = new System.Windows.Forms.CheckBox();
            this.chcLimonata = new System.Windows.Forms.CheckBox();
            this.chcCay = new System.Windows.Forms.CheckBox();
            this.chcSu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKola = new System.Windows.Forms.ComboBox();
            this.cmbLimonata = new System.Windows.Forms.ComboBox();
            this.cmbÇay = new System.Windows.Forms.ComboBox();
            this.cmbSu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.lblSiparisToplami = new System.Windows.Forms.Label();
            this.lblKasaToplami = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chcKola
            // 
            this.chcKola.AutoSize = true;
            this.chcKola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcKola.Location = new System.Drawing.Point(13, 45);
            this.chcKola.Margin = new System.Windows.Forms.Padding(4);
            this.chcKola.Name = "chcKola";
            this.chcKola.Size = new System.Drawing.Size(57, 20);
            this.chcKola.TabIndex = 0;
            this.chcKola.Text = "Kola";
            this.chcKola.UseVisualStyleBackColor = true;
           
            // 
            // chcLimonata
            // 
            this.chcLimonata.AutoSize = true;
            this.chcLimonata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcLimonata.Location = new System.Drawing.Point(13, 85);
            this.chcLimonata.Margin = new System.Windows.Forms.Padding(4);
            this.chcLimonata.Name = "chcLimonata";
            this.chcLimonata.Size = new System.Drawing.Size(89, 20);
            this.chcLimonata.TabIndex = 1;
            this.chcLimonata.Text = "Limonata";
            this.chcLimonata.UseVisualStyleBackColor = true;
            // 
            // chcCay
            // 
            this.chcCay.AutoSize = true;
            this.chcCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcCay.Location = new System.Drawing.Point(13, 130);
            this.chcCay.Margin = new System.Windows.Forms.Padding(4);
            this.chcCay.Name = "chcCay";
            this.chcCay.Size = new System.Drawing.Size(53, 20);
            this.chcCay.TabIndex = 2;
            this.chcCay.Text = "Çay";
            this.chcCay.UseVisualStyleBackColor = true;
            // 
            // chcSu
            // 
            this.chcSu.AutoSize = true;
            this.chcSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcSu.Location = new System.Drawing.Point(13, 177);
            this.chcSu.Margin = new System.Windows.Forms.Padding(4);
            this.chcSu.Name = "chcSu";
            this.chcSu.Size = new System.Drawing.Size(44, 20);
            this.chcSu.TabIndex = 3;
            this.chcSu.Text = "Su";
            this.chcSu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(191, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adet";
            // 
            // cmbKola
            // 
            this.cmbKola.FormattingEnabled = true;
            this.cmbKola.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbKola.Location = new System.Drawing.Point(176, 50);
            this.cmbKola.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKola.Name = "cmbKola";
            this.cmbKola.Size = new System.Drawing.Size(91, 24);
            this.cmbKola.TabIndex = 5;
            // 
            // cmbLimonata
            // 
            this.cmbLimonata.FormattingEnabled = true;
            this.cmbLimonata.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbLimonata.Location = new System.Drawing.Point(176, 91);
            this.cmbLimonata.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLimonata.Name = "cmbLimonata";
            this.cmbLimonata.Size = new System.Drawing.Size(91, 24);
            this.cmbLimonata.TabIndex = 6;
            // 
            // cmbÇay
            // 
            this.cmbÇay.FormattingEnabled = true;
            this.cmbÇay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbÇay.Location = new System.Drawing.Point(176, 139);
            this.cmbÇay.Margin = new System.Windows.Forms.Padding(4);
            this.cmbÇay.Name = "cmbÇay";
            this.cmbÇay.Size = new System.Drawing.Size(91, 24);
            this.cmbÇay.TabIndex = 7;
            // 
            // cmbSu
            // 
            this.cmbSu.FormattingEnabled = true;
            this.cmbSu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbSu.Location = new System.Drawing.Point(176, 185);
            this.cmbSu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSu.Name = "cmbSu";
            this.cmbSu.Size = new System.Drawing.Size(91, 24);
            this.cmbSu.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(321, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sipariş Toplamı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kasa Toplamı";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(9, 205);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(93, 41);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.Location = new System.Drawing.Point(324, 122);
            this.btnSatışYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(100, 41);
            this.btnSatışYap.TabIndex = 12;
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.UseVisualStyleBackColor = true;
            // 
            // lblSiparisToplami
            // 
            this.lblSiparisToplami.AutoSize = true;
            this.lblSiparisToplami.Location = new System.Drawing.Point(359, 85);
            this.lblSiparisToplami.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiparisToplami.Name = "lblSiparisToplami";
            this.lblSiparisToplami.Size = new System.Drawing.Size(23, 16);
            this.lblSiparisToplami.TabIndex = 14;
            this.lblSiparisToplami.Text = "00";
            // 
            // lblKasaToplami
            // 
            this.lblKasaToplami.AutoSize = true;
            this.lblKasaToplami.Location = new System.Drawing.Point(359, 217);
            this.lblKasaToplami.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKasaToplami.Name = "lblKasaToplami";
            this.lblKasaToplami.Size = new System.Drawing.Size(23, 16);
            this.lblKasaToplami.TabIndex = 15;
            this.lblKasaToplami.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(471, 256);
            this.Controls.Add(this.lblKasaToplami);
            this.Controls.Add(this.lblSiparisToplami);
            this.Controls.Add(this.btnSatışYap);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSu);
            this.Controls.Add(this.cmbÇay);
            this.Controls.Add(this.cmbLimonata);
            this.Controls.Add(this.cmbKola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chcSu);
            this.Controls.Add(this.chcCay);
            this.Controls.Add(this.chcLimonata);
            this.Controls.Add(this.chcKola);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chcKola;
        private System.Windows.Forms.CheckBox chcLimonata;
        private System.Windows.Forms.CheckBox chcCay;
        private System.Windows.Forms.CheckBox chcSu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKola;
        private System.Windows.Forms.ComboBox cmbLimonata;
        private System.Windows.Forms.ComboBox cmbÇay;
        private System.Windows.Forms.ComboBox cmbSu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSatışYap;
        private System.Windows.Forms.Label lblSiparisToplami;
        private System.Windows.Forms.Label lblKasaToplami;
    }
}

