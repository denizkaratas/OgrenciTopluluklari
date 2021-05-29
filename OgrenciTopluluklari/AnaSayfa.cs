using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private async void AnaSayfa_Load(object sender, EventArgs e)
        {
            buttonUsers.Visible = false;

            AdminControl();

            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "swZHTKc94vPvU61ENUWwthu1Bx1iRqqXiUzh3J7U",
                BasePath = "https://ogrenci-topluluklari.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(config);

            var data = await client.GetAsync("TOPLULUKLAR");

            Dictionary<string, Topluluk> ToplulukList = data.ResultAs<Dictionary<string, Topluluk>>();

            foreach (var ups in ToplulukList)
            {
                dataGridView1.Rows.Add(ups.Key);
            }
            Dictionary<string, Etkinlik> EtkinlikList = data.ResultAs<Dictionary<string, Topluluk>>();

            foreach (var ups in EtkinlikList)
            {
                dataGridView1.Rows.Add(ups.Key);
            }
            Dictionary<string, Duyuru> DuyuruList = data.ResultAs<Dictionary<string, Topluluk>>();

            foreach (var ups in DuyuruList)
            {
                dataGridView1.Rows.Add(ups.Key);
            }
        }
        public void AdminControl()
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "swZHTKc94vPvU61ENUWwthu1Bx1iRqqXiUzh3J7U",
                BasePath = "https://ogrenci-topluluklari.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(config);

           
        }
        private void button1_Click(object sender, EventArgs e)
        {
                Login l = new Login();
            l.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Data.CurrentTOPLULUKLAR = str;

            ToplulukList f1 = new ToplulukList();
            f1.Show();
            this.Close();
        }
    }
}
