namespace Random_Şanslı_Kişi
{
    partial class Form3
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
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnDorduncusayfa = new System.Windows.Forms.Button();
            this.btnGitikincisayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir renk girin : ";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(129, 30);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 23);
            this.txtRenk.TabIndex = 1;
            this.txtRenk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoster.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoster.Location = new System.Drawing.Point(129, 70);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(100, 38);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRenk.Location = new System.Drawing.Point(247, 28);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(119, 80);
            this.btnRenk.TabIndex = 3;
            this.btnRenk.UseVisualStyleBackColor = false;
            // 
            // btnDorduncusayfa
            // 
            this.btnDorduncusayfa.BackColor = System.Drawing.Color.Black;
            this.btnDorduncusayfa.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDorduncusayfa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDorduncusayfa.Location = new System.Drawing.Point(572, 346);
            this.btnDorduncusayfa.Name = "btnDorduncusayfa";
            this.btnDorduncusayfa.Size = new System.Drawing.Size(63, 52);
            this.btnDorduncusayfa.TabIndex = 4;
            this.btnDorduncusayfa.Text = "→";
            this.btnDorduncusayfa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDorduncusayfa.UseVisualStyleBackColor = false;
            this.btnDorduncusayfa.Click += new System.EventHandler(this.btnDorduncusayfa_Click);
            // 
            // btnGitikincisayfa
            // 
            this.btnGitikincisayfa.BackColor = System.Drawing.Color.Black;
            this.btnGitikincisayfa.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGitikincisayfa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGitikincisayfa.Location = new System.Drawing.Point(-1, 346);
            this.btnGitikincisayfa.Name = "btnGitikincisayfa";
            this.btnGitikincisayfa.Size = new System.Drawing.Size(63, 52);
            this.btnGitikincisayfa.TabIndex = 5;
            this.btnGitikincisayfa.Text = "←";
            this.btnGitikincisayfa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGitikincisayfa.UseVisualStyleBackColor = false;
            this.btnGitikincisayfa.Click += new System.EventHandler(this.btnGitikincisayfa_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 397);
            this.Controls.Add(this.btnGitikincisayfa);
            this.Controls.Add(this.btnDorduncusayfa);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "←";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtRenk;
        private Button btnGoster;
        private Button btnRenk;
        private Button btnDorduncusayfa;
        private Button btnİkincisayfa;
        private Button btnGitikincisayfa;
    }
}