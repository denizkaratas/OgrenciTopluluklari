using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTopluluklari
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonKayıtOl_Click(object sender, EventArgs e)
        {
            Register rgt = new Register();
            rgt.Show();
            this.Hide();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            Data.CurrentUser = kAdi.Text;


            if (kAdi.Text == "" || Sifre.Text == "" || kAdi.Text == "Kullanıcı Adınızı Giriniz..." || Sifre.Text == "Şifrenizi Giriniz...")
            {
                MessageBox.Show("Hatalı İşlem! Kullanıcı Adınızı veya Şifrenizi Boş Bırakamazsınız!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IFirebaseConfig config = new FirebaseConfig()
                {
                    AuthSecret = "Um2q5EJk0TzKlL8BJIEI8XfHrylv0Nx5JpewBOiN",
                    BasePath = "https://ogrenci-topluluklari.firebaseio.com/"
                };
                IFirebaseClient client = new FirebaseClient(config);


                FirebaseResponse res = client.Get(@"USERS/" + kAdi.Text + "/KullanıcıAdı");
                string data = res.ResultAs<string>();
                FirebaseResponse res2 = client.Get(@"USERS/" + kAdi.Text + "/Şifre");
                string data2 = res.ResultAs<string>();

                if (data == kAdi.Text && data2 == Sifre.Text)
                {
                    MessageBox.Show("Giriş Başarılı", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                   
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Giriş Başarız! Kullanıcı Adınızı veya Şifrenizi Yanlış Girdiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kAdi.Text != "Kullanıcı Adınızı Giriniz...")
            {
                Sifre.PasswordChar = '*';
            }
        }
    }
}
