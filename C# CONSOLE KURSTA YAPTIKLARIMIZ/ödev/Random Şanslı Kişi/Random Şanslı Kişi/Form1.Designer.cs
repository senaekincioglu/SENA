namespace Random_Şanslı_Kişi
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
            this.btnSanslikisi = new System.Windows.Forms.Button();
            this.btnİkincisayfa = new System.Windows.Forms.Button();
            this.lblGoster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSanslikisi
            // 
            this.btnSanslikisi.BackColor = System.Drawing.Color.Black;
            this.btnSanslikisi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSanslikisi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSanslikisi.Location = new System.Drawing.Point(65, 91);
            this.btnSanslikisi.Name = "btnSanslikisi";
            this.btnSanslikisi.Size = new System.Drawing.Size(144, 39);
            this.btnSanslikisi.TabIndex = 0;
            this.btnSanslikisi.Text = "Şanslı Kişiyi Göster";
            this.btnSanslikisi.UseVisualStyleBackColor = false;
            this.btnSanslikisi.Click += new System.EventHandler(this.btnSanslikisi_Click);
            // 
            // btnİkincisayfa
            // 
            this.btnİkincisayfa.BackColor = System.Drawing.Color.Black;
            this.btnİkincisayfa.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnİkincisayfa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnİkincisayfa.Location = new System.Drawing.Point(238, 179);
            this.btnİkincisayfa.Name = "btnİkincisayfa";
            this.btnİkincisayfa.Size = new System.Drawing.Size(55, 45);
            this.btnİkincisayfa.TabIndex = 1;
            this.btnİkincisayfa.Text = "→";
            this.btnİkincisayfa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnİkincisayfa.UseVisualStyleBackColor = false;
            this.btnİkincisayfa.Click += new System.EventHandler(this.btnİkincisayfa_Click);
            // 
            // lblGoster
            // 
            this.lblGoster.AutoSize = true;
            this.lblGoster.Location = new System.Drawing.Point(123, 60);
            this.lblGoster.Name = "lblGoster";
            this.lblGoster.Size = new System.Drawing.Size(0, 15);
            this.lblGoster.TabIndex = 2;
            this.lblGoster.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGoster.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(292, 224);
            this.Controls.Add(this.btnİkincisayfa);
            this.Controls.Add(this.btnSanslikisi);
            this.Controls.Add(this.lblGoster);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şanslı Kişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSanslikisi;
        private Button btnİkincisayfa;
        private Label lblGoster;
    }
}