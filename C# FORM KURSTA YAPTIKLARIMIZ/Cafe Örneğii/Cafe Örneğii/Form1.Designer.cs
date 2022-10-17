namespace Cafe_Örneğii
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
            this.chcTall = new System.Windows.Forms.CheckBox();
            this.chcVenti = new System.Windows.Forms.CheckBox();
            this.chcGrande = new System.Windows.Forms.CheckBox();
            this.chcSu = new System.Windows.Forms.CheckBox();
            this.cmbTall = new System.Windows.Forms.ComboBox();
            this.cmbVenti = new System.Windows.Forms.ComboBox();
            this.cmbGrande = new System.Windows.Forms.ComboBox();
            this.cmbSu = new System.Windows.Forms.ComboBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSatisyap = new System.Windows.Forms.Button();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.btnGecis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chcTall
            // 
            this.chcTall.AutoSize = true;
            this.chcTall.Location = new System.Drawing.Point(13, 29);
            this.chcTall.Margin = new System.Windows.Forms.Padding(4);
            this.chcTall.Name = "chcTall";
            this.chcTall.Size = new System.Drawing.Size(69, 20);
            this.chcTall.TabIndex = 0;
            this.chcTall.Text = "Kahve";
            this.chcTall.UseVisualStyleBackColor = true;
            this.chcTall.CheckedChanged += new System.EventHandler(this.chcTall_CheckedChanged);
            // 
            // chcVenti
            // 
            this.chcVenti.AutoSize = true;
            this.chcVenti.Location = new System.Drawing.Point(13, 72);
            this.chcVenti.Margin = new System.Windows.Forms.Padding(4);
            this.chcVenti.Name = "chcVenti";
            this.chcVenti.Size = new System.Drawing.Size(57, 20);
            this.chcVenti.TabIndex = 1;
            this.chcVenti.Text = "Kola";
            this.chcVenti.UseVisualStyleBackColor = true;
            this.chcVenti.CheckedChanged += new System.EventHandler(this.chcVenti_CheckedChanged);
            // 
            // chcGrande
            // 
            this.chcGrande.AutoSize = true;
            this.chcGrande.Location = new System.Drawing.Point(13, 120);
            this.chcGrande.Margin = new System.Windows.Forms.Padding(4);
            this.chcGrande.Name = "chcGrande";
            this.chcGrande.Size = new System.Drawing.Size(110, 20);
            this.chcGrande.TabIndex = 2;
            this.chcGrande.Text = "Meyve Suyu";
            this.chcGrande.UseVisualStyleBackColor = true;
            this.chcGrande.CheckedChanged += new System.EventHandler(this.chcGrande_CheckedChanged);
            // 
            // chcSu
            // 
            this.chcSu.AutoSize = true;
            this.chcSu.Location = new System.Drawing.Point(13, 169);
            this.chcSu.Margin = new System.Windows.Forms.Padding(4);
            this.chcSu.Name = "chcSu";
            this.chcSu.Size = new System.Drawing.Size(44, 20);
            this.chcSu.TabIndex = 3;
            this.chcSu.Text = "Su";
            this.chcSu.UseVisualStyleBackColor = true;
            this.chcSu.CheckedChanged += new System.EventHandler(this.chcSu_CheckedChanged);
            // 
            // cmbTall
            // 
            this.cmbTall.FormattingEnabled = true;
            this.cmbTall.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbTall.Location = new System.Drawing.Point(141, 25);
            this.cmbTall.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTall.Name = "cmbTall";
            this.cmbTall.Size = new System.Drawing.Size(101, 24);
            this.cmbTall.TabIndex = 4;
            // 
            // cmbVenti
            // 
            this.cmbVenti.FormattingEnabled = true;
            this.cmbVenti.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbVenti.Location = new System.Drawing.Point(141, 70);
            this.cmbVenti.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVenti.Name = "cmbVenti";
            this.cmbVenti.Size = new System.Drawing.Size(101, 24);
            this.cmbVenti.TabIndex = 5;
            // 
            // cmbGrande
            // 
            this.cmbGrande.FormattingEnabled = true;
            this.cmbGrande.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbGrande.Location = new System.Drawing.Point(141, 118);
            this.cmbGrande.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrande.Name = "cmbGrande";
            this.cmbGrande.Size = new System.Drawing.Size(101, 24);
            this.cmbGrande.TabIndex = 6;
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
            "6"});
            this.cmbSu.Location = new System.Drawing.Point(141, 165);
            this.cmbSu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSu.Name = "cmbSu";
            this.cmbSu.Size = new System.Drawing.Size(101, 24);
            this.cmbSu.TabIndex = 7;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(13, 197);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(85, 29);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnSatisyap
            // 
            this.btnSatisyap.Location = new System.Drawing.Point(260, 72);
            this.btnSatisyap.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatisyap.Name = "btnSatisyap";
            this.btnSatisyap.Size = new System.Drawing.Size(101, 39);
            this.btnSatisyap.TabIndex = 9;
            this.btnSatisyap.Text = "Satış Yap";
            this.btnSatisyap.UseVisualStyleBackColor = true;
            this.btnSatisyap.Click += new System.EventHandler(this.btnSatisyap_Click);
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(300, 27);
            this.lbl0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(15, 16);
            this.lbl0.TabIndex = 10;
            this.lbl0.Text = "0";
            this.lbl0.Click += new System.EventHandler(this.lbl0_Click);
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Location = new System.Drawing.Point(300, 167);
            this.lbl02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(15, 16);
            this.lbl02.TabIndex = 11;
            this.lbl02.Text = "0";
            // 
            // btnGecis
            // 
            this.btnGecis.Location = new System.Drawing.Point(303, 205);
            this.btnGecis.Name = "btnGecis";
            this.btnGecis.Size = new System.Drawing.Size(59, 21);
            this.btnGecis.TabIndex = 12;
            this.btnGecis.Text = "->";
            this.btnGecis.UseVisualStyleBackColor = true;
            this.btnGecis.Click += new System.EventHandler(this.btnGecis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 233);
            this.Controls.Add(this.btnGecis);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.btnSatisyap);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.cmbSu);
            this.Controls.Add(this.cmbGrande);
            this.Controls.Add(this.cmbVenti);
            this.Controls.Add(this.cmbTall);
            this.Controls.Add(this.chcSu);
            this.Controls.Add(this.chcGrande);
            this.Controls.Add(this.chcVenti);
            this.Controls.Add(this.chcTall);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Örneği";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chcTall;
        private System.Windows.Forms.CheckBox chcVenti;
        private System.Windows.Forms.CheckBox chcGrande;
        private System.Windows.Forms.CheckBox chcSu;
        private System.Windows.Forms.ComboBox cmbTall;
        private System.Windows.Forms.ComboBox cmbVenti;
        private System.Windows.Forms.ComboBox cmbGrande;
        private System.Windows.Forms.ComboBox cmbSu;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSatisyap;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Button btnGecis;
    }
}

