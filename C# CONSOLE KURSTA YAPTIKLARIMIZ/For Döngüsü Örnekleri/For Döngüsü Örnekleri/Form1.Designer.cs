namespace For_Döngüsü_Örnekleri
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
            this.lblTeksayilar = new System.Windows.Forms.Label();
            this.lblCiftSayilar = new System.Windows.Forms.Label();
            this.lblSayilar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(12, 46);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 0;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lblTeksayilar
            // 
            this.lblTeksayilar.AutoSize = true;
            this.lblTeksayilar.Location = new System.Drawing.Point(3, 179);
            this.lblTeksayilar.Name = "lblTeksayilar";
            this.lblTeksayilar.Size = new System.Drawing.Size(64, 15);
            this.lblTeksayilar.TabIndex = 1;
            this.lblTeksayilar.Text = "Tek Sayılar ";
            
            // 
            // lblCiftSayilar
            // 
            this.lblCiftSayilar.AutoSize = true;
            this.lblCiftSayilar.Location = new System.Drawing.Point(4, 247);
            this.lblCiftSayilar.Name = "lblCiftSayilar";
            this.lblCiftSayilar.Size = new System.Drawing.Size(63, 15);
            this.lblCiftSayilar.TabIndex = 2;
            this.lblCiftSayilar.Text = "Çift Sayılar";
            // 
            // lblSayilar
            // 
            this.lblSayilar.AutoSize = true;
            this.lblSayilar.Location = new System.Drawing.Point(5, 111);
            this.lblSayilar.Name = "lblSayilar";
            this.lblSayilar.Size = new System.Drawing.Size(41, 15);
            this.lblSayilar.TabIndex = 3;
            this.lblSayilar.Text = "Sayılar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSayilar);
            this.Controls.Add(this.lblCiftSayilar);
            this.Controls.Add(this.lblTeksayilar);
            this.Controls.Add(this.btnGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGoster;
        private Label lblTeksayilar;
        private Label lblCiftSayilar;
        private Label lblSayilar;
    }
}