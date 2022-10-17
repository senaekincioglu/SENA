namespace Random_Şanslı_Kişi
{
    partial class Form4
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
            this.txtPuanver = new System.Windows.Forms.TextBox();
            this.btnPuanla = new System.Windows.Forms.Button();
            this.btnGitucuncusayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puan Ver";
            // 
            // txtPuanver
            // 
            this.txtPuanver.Location = new System.Drawing.Point(12, 48);
            this.txtPuanver.Name = "txtPuanver";
            this.txtPuanver.Size = new System.Drawing.Size(105, 23);
            this.txtPuanver.TabIndex = 1;
            // 
            // btnPuanla
            // 
            this.btnPuanla.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPuanla.Location = new System.Drawing.Point(12, 93);
            this.btnPuanla.Name = "btnPuanla";
            this.btnPuanla.Size = new System.Drawing.Size(105, 31);
            this.btnPuanla.TabIndex = 2;
            this.btnPuanla.Text = "PUANLA";
            this.btnPuanla.UseVisualStyleBackColor = true;
            this.btnPuanla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGitucuncusayfa
            // 
            this.btnGitucuncusayfa.BackColor = System.Drawing.Color.Black;
            this.btnGitucuncusayfa.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGitucuncusayfa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGitucuncusayfa.Location = new System.Drawing.Point(-3, 400);
            this.btnGitucuncusayfa.Name = "btnGitucuncusayfa";
            this.btnGitucuncusayfa.Size = new System.Drawing.Size(63, 52);
            this.btnGitucuncusayfa.TabIndex = 6;
            this.btnGitucuncusayfa.Text = "←";
            this.btnGitucuncusayfa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGitucuncusayfa.UseVisualStyleBackColor = false;
            this.btnGitucuncusayfa.Click += new System.EventHandler(this.btnGitucuncusayfa_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.btnGitucuncusayfa);
            this.Controls.Add(this.btnPuanla);
            this.Controls.Add(this.txtPuanver);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtPuanver;
        private Button btnPuanla;
        private Button btnGitucuncusayfa;
    }
}