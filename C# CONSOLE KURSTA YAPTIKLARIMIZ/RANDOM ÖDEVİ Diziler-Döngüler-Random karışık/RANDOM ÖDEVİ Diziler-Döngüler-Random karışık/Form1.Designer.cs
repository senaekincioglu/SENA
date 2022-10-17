namespace RANDOM_ÖDEVİ_Diziler_Döngüler_Random_karışık
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
            this.lstRastgelesayilar = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRastgelesayilar
            // 
            this.lstRastgelesayilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstRastgelesayilar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstRastgelesayilar.FormattingEnabled = true;
            this.lstRastgelesayilar.ItemHeight = 21;
            this.lstRastgelesayilar.Location = new System.Drawing.Point(18, 20);
            this.lstRastgelesayilar.Name = "lstRastgelesayilar";
            this.lstRastgelesayilar.Size = new System.Drawing.Size(147, 235);
            this.lstRastgelesayilar.TabIndex = 0;
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGoster.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoster.Location = new System.Drawing.Point(171, 20);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(184, 43);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(171, 84);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(184, 43);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lstRastgelesayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstRastgelesayilar;
        private Button btnGoster;
        private Button btnSil;
    }
}