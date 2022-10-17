namespace Değer_dmndürmeyen_metotlar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnParametrealmayan = new System.Windows.Forms.Button();
            this.btnParametrealan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnParametrealmayan);
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametre almayan metotlar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMesaj);
            this.groupBox2.Controls.Add(this.txtBaslik);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnParametrealan);
            this.groupBox2.Location = new System.Drawing.Point(236, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametre alan metotlar";
            // 
            // btnParametrealmayan
            // 
            this.btnParametrealmayan.Location = new System.Drawing.Point(38, 66);
            this.btnParametrealmayan.Name = "btnParametrealmayan";
            this.btnParametrealmayan.Size = new System.Drawing.Size(103, 28);
            this.btnParametrealmayan.TabIndex = 0;
            this.btnParametrealmayan.Text = "Ekrana Yazdır";
            this.btnParametrealmayan.UseVisualStyleBackColor = true;
            this.btnParametrealmayan.Click += new System.EventHandler(this.btnParametrealmayan_Click);
            // 
            // btnParametrealan
            // 
            this.btnParametrealan.Location = new System.Drawing.Point(80, 146);
            this.btnParametrealan.Name = "btnParametrealan";
            this.btnParametrealan.Size = new System.Drawing.Size(103, 28);
            this.btnParametrealan.TabIndex = 1;
            this.btnParametrealan.Text = "Ekrana Yazdır";
            this.btnParametrealan.UseVisualStyleBackColor = true;
            this.btnParametrealan.Click += new System.EventHandler(this.btnParametrealan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlık : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mesaj : ";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(66, 32);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(100, 23);
            this.txtBaslik.TabIndex = 4;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(66, 87);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(100, 23);
            this.txtMesaj.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Değer Döndürmeyen Metotlar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnParametrealmayan;
        private GroupBox groupBox2;
        private TextBox txtMesaj;
        private TextBox txtBaslik;
        private Label label2;
        private Label label1;
        private Button btnParametrealan;
    }
}