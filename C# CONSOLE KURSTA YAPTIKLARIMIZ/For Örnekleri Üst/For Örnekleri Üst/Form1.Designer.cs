namespace For_Örnekleri_Üst
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
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.lstYazdır = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnBaslabitir = new System.Windows.Forms.Button();
            this.lstEkle = new System.Windows.Forms.ListBox();
            this.txtBitir = new System.Windows.Forms.TextBox();
            this.txtBasla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş";
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(80, 36);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(100, 23);
            this.txtBaslangic.TabIndex = 2;
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(80, 74);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 23);
            this.txtBitis.TabIndex = 3;
            // 
            // lstYazdır
            // 
            this.lstYazdır.FormattingEnabled = true;
            this.lstYazdır.ItemHeight = 15;
            this.lstYazdır.Location = new System.Drawing.Point(17, 113);
            this.lstYazdır.Name = "lstYazdır";
            this.lstYazdır.Size = new System.Drawing.Size(163, 94);
            this.lstYazdır.TabIndex = 4;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(50, 222);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 5;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnBaslabitir
            // 
            this.btnBaslabitir.Location = new System.Drawing.Point(235, 222);
            this.btnBaslabitir.Name = "btnBaslabitir";
            this.btnBaslabitir.Size = new System.Drawing.Size(75, 23);
            this.btnBaslabitir.TabIndex = 11;
            this.btnBaslabitir.Text = "Göster";
            this.btnBaslabitir.UseVisualStyleBackColor = true;
            this.btnBaslabitir.Click += new System.EventHandler(this.btnBaslabitir_Click);
            // 
            // lstEkle
            // 
            this.lstEkle.FormattingEnabled = true;
            this.lstEkle.ItemHeight = 15;
            this.lstEkle.Location = new System.Drawing.Point(202, 113);
            this.lstEkle.Name = "lstEkle";
            this.lstEkle.Size = new System.Drawing.Size(163, 94);
            this.lstEkle.TabIndex = 10;
            // 
            // txtBitir
            // 
            this.txtBitir.Location = new System.Drawing.Point(265, 74);
            this.txtBitir.Name = "txtBitir";
            this.txtBitir.Size = new System.Drawing.Size(100, 23);
            this.txtBitir.TabIndex = 9;
            // 
            // txtBasla
            // 
            this.txtBasla.Location = new System.Drawing.Point(265, 36);
            this.txtBasla.Name = "txtBasla";
            this.txtBasla.Size = new System.Drawing.Size(100, 23);
            this.txtBasla.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bitir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Başla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 471);
            this.Controls.Add(this.btnBaslabitir);
            this.Controls.Add(this.lstEkle);
            this.Controls.Add(this.txtBitir);
            this.Controls.Add(this.txtBasla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lstYazdır);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.txtBaslangic);
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
        private TextBox txtBaslangic;
        private TextBox txtBitis;
        private ListBox lstYazdır;
        private Button btnGoster;
        private Button btnBaslabitir;
        private ListBox lstEkle;
        private TextBox txtBitir;
        private TextBox txtBasla;
        private Label label3;
        private Label label4;
    }
}