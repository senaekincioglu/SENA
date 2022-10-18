namespace İki_tarih_arası_gün_hesaplama
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
            this.txtGunfarki = new System.Windows.Forms.TextBox();
            this.lblGunfarki = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.dpBitis = new System.Windows.Forms.DateTimePicker();
            this.dpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGunfarki
            // 
            this.txtGunfarki.Location = new System.Drawing.Point(240, 207);
            this.txtGunfarki.Name = "txtGunfarki";
            this.txtGunfarki.Size = new System.Drawing.Size(100, 20);
            this.txtGunfarki.TabIndex = 13;
            // 
            // lblGunfarki
            // 
            this.lblGunfarki.AutoSize = true;
            this.lblGunfarki.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunfarki.Location = new System.Drawing.Point(87, 198);
            this.lblGunfarki.Name = "lblGunfarki";
            this.lblGunfarki.Size = new System.Drawing.Size(147, 29);
            this.lblGunfarki.TabIndex = 12;
            this.lblGunfarki.Text = "Gün Farkı : ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(500, 58);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(104, 33);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // dpBitis
            // 
            this.dpBitis.Location = new System.Drawing.Point(217, 89);
            this.dpBitis.Name = "dpBitis";
            this.dpBitis.Size = new System.Drawing.Size(200, 20);
            this.dpBitis.TabIndex = 10;
            // 
            // dpBaslangic
            // 
            this.dpBaslangic.Location = new System.Drawing.Point(217, 38);
            this.dpBaslangic.Name = "dpBaslangic";
            this.dpBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dpBaslangic.TabIndex = 9;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.Location = new System.Drawing.Point(28, 85);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(125, 24);
            this.lblBitis.TabIndex = 8;
            this.lblBitis.Text = "Bitiş Tarihi : ";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangic.Location = new System.Drawing.Point(28, 36);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(183, 24);
            this.lblBaslangic.TabIndex = 7;
            this.lblBaslangic.Text = "Başlangıç  Tarihi : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGunfarki);
            this.Controls.Add(this.lblGunfarki);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dpBitis);
            this.Controls.Add(this.dpBaslangic);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGunfarki;
        private System.Windows.Forms.Label lblGunfarki;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DateTimePicker dpBitis;
        private System.Windows.Forms.DateTimePicker dpBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangic;
    }
}

