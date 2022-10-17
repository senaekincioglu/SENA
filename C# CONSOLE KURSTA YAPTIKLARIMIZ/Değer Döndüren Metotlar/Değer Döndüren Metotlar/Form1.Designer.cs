namespace Değer_Döndüren_Metotlar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParametresizMetod = new System.Windows.Forms.Button();
            this.lblMetoduYazdir = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.txtİkincisayi = new System.Windows.Forms.TextBox();
            this.txtBirincisayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnParametresizMetod);
            this.groupBox1.Controls.Add(this.lblMetoduYazdir);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametresiz Metot";
            // 
            // btnParametresizMetod
            // 
            this.btnParametresizMetod.Location = new System.Drawing.Point(26, 81);
            this.btnParametresizMetod.Name = "btnParametresizMetod";
            this.btnParametresizMetod.Size = new System.Drawing.Size(97, 28);
            this.btnParametresizMetod.TabIndex = 1;
            this.btnParametresizMetod.Text = "Metodu Yazdır";
            this.btnParametresizMetod.UseVisualStyleBackColor = true;
            this.btnParametresizMetod.Click += new System.EventHandler(this.btnParametresizMetod_Click);
            // 
            // lblMetoduYazdir
            // 
            this.lblMetoduYazdir.AutoSize = true;
            this.lblMetoduYazdir.Location = new System.Drawing.Point(53, 46);
            this.lblMetoduYazdir.Name = "lblMetoduYazdir";
            this.lblMetoduYazdir.Size = new System.Drawing.Size(38, 15);
            this.lblMetoduYazdir.TabIndex = 0;
            this.lblMetoduYazdir.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSonuc);
            this.groupBox2.Controls.Add(this.btnTopla);
            this.groupBox2.Controls.Add(this.txtİkincisayi);
            this.groupBox2.Controls.Add(this.txtBirincisayi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(254, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametreli Metot";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(52, 143);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(97, 28);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // txtİkincisayi
            // 
            this.txtİkincisayi.Location = new System.Drawing.Point(67, 91);
            this.txtİkincisayi.Name = "txtİkincisayi";
            this.txtİkincisayi.Size = new System.Drawing.Size(100, 23);
            this.txtİkincisayi.TabIndex = 5;
            // 
            // txtBirincisayi
            // 
            this.txtBirincisayi.Location = new System.Drawing.Point(67, 38);
            this.txtBirincisayi.Name = "txtBirincisayi";
            this.txtBirincisayi.Size = new System.Drawing.Size(100, 23);
            this.txtBirincisayi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Sayı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Sayı : ";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(79, 194);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 15);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Değer Döndüren Metotlar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnParametresizMetod;
        private Label lblMetoduYazdir;
        private GroupBox groupBox2;
        private Button btnTopla;
        private TextBox txtİkincisayi;
        private TextBox txtBirincisayi;
        private Label label2;
        private Label label1;
        private Label lblSonuc;
    }
}