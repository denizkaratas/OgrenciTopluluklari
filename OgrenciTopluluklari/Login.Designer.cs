namespace OgrenciTopluluklari
{
    partial class Login
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
            this.kAdi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.buttonKayıtOl = new System.Windows.Forms.Button();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(274, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI GİRİŞİ";
            // 
            // kAdi
            // 
            this.kAdi.Location = new System.Drawing.Point(293, 146);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(181, 20);
            this.kAdi.TabIndex = 1;
            this.kAdi.Text = "Kullanıcı Adınızı Giriniz..";
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(293, 213);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(181, 20);
            this.Sifre.TabIndex = 2;
            this.Sifre.Text = "Şifrenizi Giriniz..";
            // 
            // buttonKayıtOl
            // 
            this.buttonKayıtOl.Location = new System.Drawing.Point(293, 289);
            this.buttonKayıtOl.Name = "buttonKayıtOl";
            this.buttonKayıtOl.Size = new System.Drawing.Size(75, 23);
            this.buttonKayıtOl.TabIndex = 3;
            this.buttonKayıtOl.Text = "KAYIT OL";
            this.buttonKayıtOl.UseVisualStyleBackColor = true;
            this.buttonKayıtOl.Click += new System.EventHandler(this.buttonKayıtOl_Click);
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Location = new System.Drawing.Point(390, 289);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(75, 23);
            this.buttonGirisYap.TabIndex = 4;
            this.buttonGirisYap.Text = "GİRİŞ YAP";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.buttonKayıtOl);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.kAdi);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Button buttonKayıtOl;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.Timer timer1;
    }
}