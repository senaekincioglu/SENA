namespace Random_Şanslı_Kişi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeslikSistem = new System.Windows.Forms.TextBox();
            this.btnCevir = new System.Windows.Forms.Button();
            this.btnUcuncusayfa = new System.Windows.Forms.Button();
            this.btnGitbirincisayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(184, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beşlik Sisteme Çevir";
            // 
            // txtBeslikSistem
            // 
            this.txtBeslikSistem.Location = new System.Drawing.Point(184, 79);
            this.txtBeslikSistem.Name = "txtBeslikSistem";
            this.txtBeslikSistem.Size = new System.Drawing.Size(231, 22);
            this.txtBeslikSistem.TabIndex = 1;
            
            // 
            // btnCevir
            // 
            this.btnCevir.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCevir.Location = new System.Drawing.Point(184, 118);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(231, 38);
            this.btnCevir.TabIndex = 2;
            this.btnCevir.Text = "Çevir";
            this.btnCevir.UseVisualStyleBackColor = true;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // btnUcuncusayfa
            // 
            this.btnUcuncusayfa.BackColor = System.Drawing.Color.Black;
            this.btnUcuncusayfa.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUcuncusayfa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUcuncusayfa.Location = new System.Drawing.Point(533, 339);
            this.btnUcuncusayfa.Name = "btnUcuncusayfa";
            this.btnUcuncusayfa.Size = new System.Drawing.Size(63, 52);
            this.btnUcuncusayfa.TabIndex = 3;
            this.btnUcuncusayfa.Text = "→";
            this.btnUcuncusayfa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnUcuncusayfa.UseVisualStyleBackColor = false;
            this.btnUcuncusayfa.Click += new System.EventHandler(this.btnUcuncusayfa_Click);
            // 
            // btnGitbirincisayfa
            // 
            this.btnGitbirincisayfa.BackColor = System.Drawing.Color.Black;
            this.btnGitbirincisayfa.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGitbirincisayfa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGitbirincisayfa.Location = new System.Drawing.Point(-1, 339);
            this.btnGitbirincisayfa.Name = "btnGitbirincisayfa";
            this.btnGitbirincisayfa.Size = new System.Drawing.Size(60, 52);
            this.btnGitbirincisayfa.TabIndex = 4;
            this.btnGitbirincisayfa.Text = "←";
            this.btnGitbirincisayfa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGitbirincisayfa.UseVisualStyleBackColor = false;
            this.btnGitbirincisayfa.Click += new System.EventHandler(this.btnGitbirincisayfa_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(594, 390);
            this.Controls.Add(this.btnGitbirincisayfa);
            this.Controls.Add(this.btnUcuncusayfa);
            this.Controls.Add(this.btnCevir);
            this.Controls.Add(this.txtBeslikSistem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beşlik Sistem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBeslikSistem;
        private Button btnCevir;
        private Button btnUcuncusayfa;
        private Button btnGitbirincisayfa;
    }
}