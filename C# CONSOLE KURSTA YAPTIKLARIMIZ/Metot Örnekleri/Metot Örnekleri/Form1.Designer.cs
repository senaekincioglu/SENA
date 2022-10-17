namespace Metot_Örnekleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBirincisayi = new System.Windows.Forms.TextBox();
            this.txtİkincisayi = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.rdbtnTopla = new System.Windows.Forms.RadioButton();
            this.rdbtnCikar = new System.Windows.Forms.RadioButton();
            this.rdbtnCarp = new System.Windows.Forms.RadioButton();
            this.rdbtnBol = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Sayı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Sayı : ";
            // 
            // txtBirincisayi
            // 
            this.txtBirincisayi.Location = new System.Drawing.Point(79, 21);
            this.txtBirincisayi.Name = "txtBirincisayi";
            this.txtBirincisayi.Size = new System.Drawing.Size(100, 23);
            this.txtBirincisayi.TabIndex = 2;
            // 
            // txtİkincisayi
            // 
            this.txtİkincisayi.Location = new System.Drawing.Point(79, 77);
            this.txtİkincisayi.Name = "txtİkincisayi";
            this.txtİkincisayi.Size = new System.Drawing.Size(100, 23);
            this.txtİkincisayi.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(79, 123);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 26);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // rdbtnTopla
            // 
            this.rdbtnTopla.AutoSize = true;
            this.rdbtnTopla.Location = new System.Drawing.Point(215, 22);
            this.rdbtnTopla.Name = "rdbtnTopla";
            this.rdbtnTopla.Size = new System.Drawing.Size(70, 19);
            this.rdbtnTopla.TabIndex = 5;
            this.rdbtnTopla.TabStop = true;
            this.rdbtnTopla.Text = "Toplama";
            this.rdbtnTopla.UseVisualStyleBackColor = true;
            // 
            // rdbtnCikar
            // 
            this.rdbtnCikar.AutoSize = true;
            this.rdbtnCikar.Location = new System.Drawing.Point(215, 56);
            this.rdbtnCikar.Name = "rdbtnCikar";
            this.rdbtnCikar.Size = new System.Drawing.Size(69, 19);
            this.rdbtnCikar.TabIndex = 6;
            this.rdbtnCikar.TabStop = true;
            this.rdbtnCikar.Text = "Çıkarma";
            this.rdbtnCikar.UseVisualStyleBackColor = true;
            // 
            // rdbtnCarp
            // 
            this.rdbtnCarp.AutoSize = true;
            this.rdbtnCarp.Location = new System.Drawing.Point(215, 91);
            this.rdbtnCarp.Name = "rdbtnCarp";
            this.rdbtnCarp.Size = new System.Drawing.Size(67, 19);
            this.rdbtnCarp.TabIndex = 7;
            this.rdbtnCarp.TabStop = true;
            this.rdbtnCarp.Text = "Çarpma";
            this.rdbtnCarp.UseVisualStyleBackColor = true;
            // 
            // rdbtnBol
            // 
            this.rdbtnBol.AutoSize = true;
            this.rdbtnBol.Location = new System.Drawing.Point(215, 127);
            this.rdbtnBol.Name = "rdbtnBol";
            this.rdbtnBol.Size = new System.Drawing.Size(59, 19);
            this.rdbtnBol.TabIndex = 8;
            this.rdbtnBol.TabStop = true;
            this.rdbtnBol.Text = "Bölme";
            this.rdbtnBol.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sonuç ";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(141, 177);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(19, 15);
            this.lblSonuc.TabIndex = 10;
            this.lblSonuc.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(314, 208);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbtnBol);
            this.Controls.Add(this.rdbtnCarp);
            this.Controls.Add(this.rdbtnCikar);
            this.Controls.Add(this.rdbtnTopla);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtİkincisayi);
            this.Controls.Add(this.txtBirincisayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBirincisayi;
        private TextBox txtİkincisayi;
        private Button btnHesapla;
        private RadioButton rdbtnTopla;
        private RadioButton rdbtnCikar;
        private RadioButton rdbtnCarp;
        private RadioButton rdbtnBol;
        private Label label3;
        private Label lblSonuc;
    }
}