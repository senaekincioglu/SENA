namespace Forr_örnek
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
            this.lstGoster = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş";
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(86, 22);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(100, 23);
            this.txtBaslangic.TabIndex = 2;
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(86, 57);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 23);
            this.txtBitis.TabIndex = 3;
            // 
            // lstGoster
            // 
            this.lstGoster.FormattingEnabled = true;
            this.lstGoster.ItemHeight = 15;
            this.lstGoster.Location = new System.Drawing.Point(9, 89);
            this.lstGoster.Name = "lstGoster";
            this.lstGoster.Size = new System.Drawing.Size(177, 109);
            this.lstGoster.TabIndex = 4;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(103, 219);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(83, 31);
            this.btnGoster.TabIndex = 5;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lstGoster);
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
        private ListBox lstGoster;
        private Button btnGoster;
    }
}