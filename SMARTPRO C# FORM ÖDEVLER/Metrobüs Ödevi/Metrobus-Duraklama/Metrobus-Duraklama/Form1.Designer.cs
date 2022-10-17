namespace Metrobus_Duraklama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rdSogutlucesme = new System.Windows.Forms.RadioButton();
            this.rdFikirtepe = new System.Windows.Forms.RadioButton();
            this.rdUzuncayir = new System.Windows.Forms.RadioButton();
            this.rdAcıbadem = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.BackColor = System.Drawing.Color.Black;
            this.BtnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaslat.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBaslat.Location = new System.Drawing.Point(0, 281);
            this.BtnBaslat.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(80, 37);
            this.BtnBaslat.TabIndex = 5;
            this.BtnBaslat.Text = "Başlat";
            this.BtnBaslat.UseVisualStyleBackColor = false;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1239, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1141, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "→";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdSogutlucesme
            // 
            this.rdSogutlucesme.AutoSize = true;
            this.rdSogutlucesme.BackColor = System.Drawing.Color.GreenYellow;
            this.rdSogutlucesme.Location = new System.Drawing.Point(383, 20);
            this.rdSogutlucesme.Name = "rdSogutlucesme";
            this.rdSogutlucesme.Size = new System.Drawing.Size(93, 17);
            this.rdSogutlucesme.TabIndex = 18;
            this.rdSogutlucesme.TabStop = true;
            this.rdSogutlucesme.Text = "SöğütlüCesme";
            this.rdSogutlucesme.UseVisualStyleBackColor = false;
            // 
            // rdFikirtepe
            // 
            this.rdFikirtepe.AutoSize = true;
            this.rdFikirtepe.BackColor = System.Drawing.Color.GreenYellow;
            this.rdFikirtepe.Location = new System.Drawing.Point(622, 25);
            this.rdFikirtepe.Name = "rdFikirtepe";
            this.rdFikirtepe.Size = new System.Drawing.Size(65, 17);
            this.rdFikirtepe.TabIndex = 19;
            this.rdFikirtepe.TabStop = true;
            this.rdFikirtepe.Text = "Fikirtepe";
            this.rdFikirtepe.UseVisualStyleBackColor = false;
            // 
            // rdUzuncayir
            // 
            this.rdUzuncayir.AutoSize = true;
            this.rdUzuncayir.BackColor = System.Drawing.Color.GreenYellow;
            this.rdUzuncayir.Location = new System.Drawing.Point(869, 29);
            this.rdUzuncayir.Name = "rdUzuncayir";
            this.rdUzuncayir.Size = new System.Drawing.Size(72, 17);
            this.rdUzuncayir.TabIndex = 20;
            this.rdUzuncayir.TabStop = true;
            this.rdUzuncayir.Text = "Uzunçayır";
            this.rdUzuncayir.UseVisualStyleBackColor = false;
            // 
            // rdAcıbadem
            // 
            this.rdAcıbadem.AutoSize = true;
            this.rdAcıbadem.BackColor = System.Drawing.Color.GreenYellow;
            this.rdAcıbadem.Location = new System.Drawing.Point(1116, 29);
            this.rdAcıbadem.Name = "rdAcıbadem";
            this.rdAcıbadem.Size = new System.Drawing.Size(72, 17);
            this.rdAcıbadem.TabIndex = 21;
            this.rdAcıbadem.TabStop = true;
            this.rdAcıbadem.Text = "Acıbadem";
            this.rdAcıbadem.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1330, 318);
            this.Controls.Add(this.rdAcıbadem);
            this.Controls.Add(this.rdUzuncayir);
            this.Controls.Add(this.rdFikirtepe);
            this.Controls.Add(this.rdSogutlucesme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBaslat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Metrobüs Otomasyonu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdSogutlucesme;
        private System.Windows.Forms.RadioButton rdFikirtepe;
        private System.Windows.Forms.RadioButton rdUzuncayir;
        private System.Windows.Forms.RadioButton rdAcıbadem;
    }
}

