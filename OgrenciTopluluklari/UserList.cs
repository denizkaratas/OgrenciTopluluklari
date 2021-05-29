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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }
        private string userLitst2, UserListyetk, userListkadi1;
        private async void UserList_Load(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "swZHTKc94vPvU61ENUWwthu1Bx1iRqqXiUzh3J7U",
                BasePath = "https://ogrenci-topluluklari.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(config);

            var data = await client.GetAsync("USERS");

            Dictionary<string, User> userList = data.ResultAs<Dictionary<string, User>>();

            foreach (var user in userList)
            {
                userDataGridView.Rows.Add(user.Value.KullanıcıAdı, user.Value.YETKİ, user.Value.ETKİNLİKLER, user.Value.DUYURULAR, user.Value.TOPLULUKLAR);
            }
        }

        private void UserList_Load_1(object sender, EventArgs e)
        {
            private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                IFirebaseConfig config = new FirebaseConfig()
                {
                    AuthSecret = "swZHTKc94vPvU61ENUWwthu1Bx1iRqqXiUzh3J7U",
                    BasePath = "https://ogrenci-topluluklari.firebaseio.com/"
                };
                IFirebaseClient client = new FirebaseClient(config);


                yetk = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText.ToString();
                kadi1 = userDataGridView.CurrentRow.Cells[0].Value.ToString();

                FirebaseResponse res = client.Get(@"USERS/" + userListkadi1 + "/" + UserListyetk);
                string data = res.ResultAs<string>();


                if (data == "true")
                {
                    st2 = "false";
                }
                else
                {
                    st2 = "true";
                }

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kişinin Yetkisini Değiştirmek İstiyor Musunuz?", "YETKİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    var set2 = await client.SetAsync(@"USERS/" + userListkadi1 + "/" + UserListyetk, userListst2);

                    userDataGridView.Rows.Clear();
                    UserList_Load(sender, e);

                    MessageBox.Show("Yetki Değiştirildi!!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Yetki Değiştirilmedi!!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonGerii_Click(object sender, EventArgs e)
        {
            AnaSayfa asf = new AnaSayfa();
            asf.Show();
            this.Close();
        }
    }
}
    }
}
