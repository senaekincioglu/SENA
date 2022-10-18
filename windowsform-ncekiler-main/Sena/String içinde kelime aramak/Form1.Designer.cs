namespace String_içinde_kelime_aramak
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.txtAranacakkelime = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.lstBulunankelime = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(6, 16);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(449, 75);
            this.txtMetin.TabIndex = 0;
            // 
            // txtAranacakkelime
            // 
            this.txtAranacakkelime.Location = new System.Drawing.Point(6, 110);
            this.txtAranacakkelime.Multiline = true;
            this.txtAranacakkelime.Name = "txtAranacakkelime";
            this.txtAranacakkelime.Size = new System.Drawing.Size(298, 62);
            this.txtAranacakkelime.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(317, 110);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(137, 61);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // lstBulunankelime
            // 
            this.lstBulunankelime.FormattingEnabled = true;
            this.lstBulunankelime.Location = new System.Drawing.Point(10, 188);
            this.lstBulunankelime.Name = "lstBulunankelime";
            this.lstBulunankelime.Size = new System.Drawing.Size(443, 108);
            this.lstBulunankelime.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(466, 309);
            this.Controls.Add(this.lstBulunankelime);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtAranacakkelime);
            this.Controls.Add(this.txtMetin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String İçinde Kelime Aramak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.TextBox txtAranacakkelime;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.ListBox lstBulunankelime;
    }
}

