namespace Okul_Kayıt_Formu_2
{
    partial class frmKayit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtOkul = new System.Windows.Forms.TextBox();
            this.dpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lstBilgiler = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Okul Kayıt Formu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mezun Olunan Okul:";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(188, 48);
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(188, 88);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 26);
            this.txtAd.TabIndex = 8;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAd_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(188, 135);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 26);
            this.txtSoyad.TabIndex = 9;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAd_KeyPress);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(188, 243);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(100, 28);
            this.cmbCinsiyet.TabIndex = 10;
            // 
            // txtOkul
            // 
            this.txtOkul.Location = new System.Drawing.Point(188, 292);
            this.txtOkul.Multiline = true;
            this.txtOkul.Name = "txtOkul";
            this.txtOkul.Size = new System.Drawing.Size(100, 26);
            this.txtOkul.TabIndex = 11;
            // 
            // dpDogumTarihi
            // 
            this.dpDogumTarihi.Location = new System.Drawing.Point(188, 187);
            this.dpDogumTarihi.Name = "dpDogumTarihi";
            this.dpDogumTarihi.Size = new System.Drawing.Size(200, 26);
            this.dpDogumTarihi.TabIndex = 12;
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(93, 355);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(201, 41);
            this.btnKayit.TabIndex = 13;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // lstBilgiler
            // 
            this.lstBilgiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstBilgiler.FormattingEnabled = true;
            this.lstBilgiler.ItemHeight = 20;
            this.lstBilgiler.Location = new System.Drawing.Point(470, 41);
            this.lstBilgiler.Name = "lstBilgiler";
            this.lstBilgiler.Size = new System.Drawing.Size(316, 404);
            this.lstBilgiler.TabIndex = 14;
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(813, 517);
            this.Controls.Add(this.lstBilgiler);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.dpDogumTarihi);
            this.Controls.Add(this.txtOkul);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okul Kayıt Formu";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtOkul;
        private System.Windows.Forms.DateTimePicker dpDogumTarihi;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.ListBox lstBilgiler;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

