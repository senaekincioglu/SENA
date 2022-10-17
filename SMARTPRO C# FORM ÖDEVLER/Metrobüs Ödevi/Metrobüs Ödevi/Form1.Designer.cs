namespace Metrobüs_Ödevi
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
            this.lblZaman = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSogutlucesme = new System.Windows.Forms.Label();
            this.lblFikirtepe = new System.Windows.Forms.Label();
            this.lblUzuncayir = new System.Windows.Forms.Label();
            this.lblAcibadem = new System.Windows.Forms.Label();
            this.lblOkişareti = new System.Windows.Forms.Label();
            this.btnBaslatdönüs = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(13, 9);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(40, 13);
            this.lblZaman.TabIndex = 0;
            this.lblZaman.Text = "Zaman";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(4, 125);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblSogutlucesme
            // 
            this.lblSogutlucesme.AutoSize = true;
            this.lblSogutlucesme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSogutlucesme.Location = new System.Drawing.Point(309, 41);
            this.lblSogutlucesme.Name = "lblSogutlucesme";
            this.lblSogutlucesme.Size = new System.Drawing.Size(105, 16);
            this.lblSogutlucesme.TabIndex = 3;
            this.lblSogutlucesme.Text = "Söğütlüçeşme";
            // 
            // lblFikirtepe
            // 
            this.lblFikirtepe.AutoSize = true;
            this.lblFikirtepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFikirtepe.Location = new System.Drawing.Point(495, 41);
            this.lblFikirtepe.Name = "lblFikirtepe";
            this.lblFikirtepe.Size = new System.Drawing.Size(68, 16);
            this.lblFikirtepe.TabIndex = 4;
            this.lblFikirtepe.Text = "Fikirtepe";
            // 
            // lblUzuncayir
            // 
            this.lblUzuncayir.AutoSize = true;
            this.lblUzuncayir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzuncayir.Location = new System.Drawing.Point(673, 41);
            this.lblUzuncayir.Name = "lblUzuncayir";
            this.lblUzuncayir.Size = new System.Drawing.Size(75, 16);
            this.lblUzuncayir.TabIndex = 5;
            this.lblUzuncayir.Text = "Uzunçayır";
            // 
            // lblAcibadem
            // 
            this.lblAcibadem.AutoSize = true;
            this.lblAcibadem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcibadem.Location = new System.Drawing.Point(832, 41);
            this.lblAcibadem.Name = "lblAcibadem";
            this.lblAcibadem.Size = new System.Drawing.Size(77, 16);
            this.lblAcibadem.TabIndex = 6;
            this.lblAcibadem.Text = "Acıbadem";
            // 
            // lblOkişareti
            // 
            this.lblOkişareti.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOkişareti.Location = new System.Drawing.Point(77, 57);
            this.lblOkişareti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOkişareti.Name = "lblOkişareti";
            this.lblOkişareti.Size = new System.Drawing.Size(1077, 33);
            this.lblOkişareti.TabIndex = 18;
            this.lblOkişareti.Text = "→";
            this.lblOkişareti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBaslatdönüs
            // 
            this.btnBaslatdönüs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslatdönüs.Location = new System.Drawing.Point(835, 125);
            this.btnBaslatdönüs.Name = "btnBaslatdönüs";
            this.btnBaslatdönüs.Size = new System.Drawing.Size(75, 23);
            this.btnBaslatdönüs.TabIndex = 19;
            this.btnBaslatdönüs.Text = "Başlat";
            this.btnBaslatdönüs.UseVisualStyleBackColor = true;
            this.btnBaslatdönüs.Click += new System.EventHandler(this.btnBaslatdönüs_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 415);
            this.Controls.Add(this.btnBaslatdönüs);
            this.Controls.Add(this.lblOkişareti);
            this.Controls.Add(this.lblAcibadem);
            this.Controls.Add(this.lblUzuncayir);
            this.Controls.Add(this.lblFikirtepe);
            this.Controls.Add(this.lblSogutlucesme);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblZaman);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metrobüs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSogutlucesme;
        private System.Windows.Forms.Label lblFikirtepe;
        private System.Windows.Forms.Label lblUzuncayir;
        private System.Windows.Forms.Label lblAcibadem;
        private System.Windows.Forms.Label lblOkişareti;
        private System.Windows.Forms.Button btnBaslatdönüs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

