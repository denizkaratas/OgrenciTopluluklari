namespace OgrenciTopluluklari
{
    partial class Register
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
            this.kAdi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kAdi
            // 
            this.kAdi.Location = new System.Drawing.Point(95, 150);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(140, 20);
            this.kAdi.TabIndex = 0;
            this.kAdi.Text = "Kullanıcı Adınızı Giriniz..";
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(95, 213);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(140, 20);
            this.Sifre.TabIndex = 1;
            this.Sifre.Text = "Sifrenizi Giriniz..";
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(43, 46);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(75, 23);
            this.buttonGeri.TabIndex = 2;
            this.buttonGeri.Text = "GERİ";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonKayıt
            // 
            this.buttonKayıt.Location = new System.Drawing.Point(118, 303);
            this.buttonKayıt.Name = "buttonKayıt";
            this.buttonKayıt.Size = new System.Drawing.Size(75, 23);
            this.buttonKayıt.TabIndex = 3;
            this.buttonKayıt.Text = "KAYIT OL";
            this.buttonKayıt.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.buttonKayıt);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.kAdi);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKayıt;
    }
}