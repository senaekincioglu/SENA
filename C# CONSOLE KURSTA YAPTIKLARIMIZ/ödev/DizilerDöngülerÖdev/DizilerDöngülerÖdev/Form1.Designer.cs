namespace DizilerDöngülerÖdev
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
            this.btnListele = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.lstListeletopla = new System.Windows.Forms.ListBox();
            this.btnİkincisayfagec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 26);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(117, 25);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(12, 71);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(117, 25);
            this.btnTopla.TabIndex = 1;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // lstListeletopla
            // 
            this.lstListeletopla.FormattingEnabled = true;
            this.lstListeletopla.ItemHeight = 15;
            this.lstListeletopla.Location = new System.Drawing.Point(135, 26);
            this.lstListeletopla.Name = "lstListeletopla";
            this.lstListeletopla.Size = new System.Drawing.Size(154, 334);
            this.lstListeletopla.TabIndex = 2;
            // 
            // btnİkincisayfagec
            // 
            this.btnİkincisayfagec.Location = new System.Drawing.Point(316, 380);
            this.btnİkincisayfagec.Name = "btnİkincisayfagec";
            this.btnİkincisayfagec.Size = new System.Drawing.Size(53, 23);
            this.btnİkincisayfagec.TabIndex = 3;
            this.btnİkincisayfagec.Text = "→";
            this.btnİkincisayfagec.UseVisualStyleBackColor = true;
            this.btnİkincisayfagec.Click += new System.EventHandler(this.txtİkincisayfagec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 403);
            this.Controls.Add(this.btnİkincisayfagec);
            this.Controls.Add(this.lstListeletopla);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnListele);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnListele;
        private Button btnTopla;
        private ListBox lstListeletopla;
        private Button btnİkincisayfagec;
    }
}