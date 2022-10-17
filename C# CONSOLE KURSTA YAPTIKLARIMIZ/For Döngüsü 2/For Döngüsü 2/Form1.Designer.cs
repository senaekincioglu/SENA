namespace For_Döngüsü_2
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
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lstbaslangicbitis = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç: ";
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(84, 34);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(100, 23);
            this.txtBaslangic.TabIndex = 1;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(84, 134);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(102, 31);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lstbaslangicbitis
            // 
            this.lstbaslangicbitis.FormattingEnabled = true;
            this.lstbaslangicbitis.ItemHeight = 15;
            this.lstbaslangicbitis.Location = new System.Drawing.Point(210, 37);
            this.lstbaslangicbitis.Name = "lstbaslangicbitis";
            this.lstbaslangicbitis.Size = new System.Drawing.Size(120, 94);
            this.lstbaslangicbitis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş:";
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(84, 86);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 23);
            this.txtBitis.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 466);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstbaslangicbitis);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.txtBaslangic);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBaslangic;
        private Button btnGoster;
        private ListBox lstbaslangicbitis;
        private Label label2;
        private TextBox txtBitis;
    }
}