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
    public partial class ToplulukList : Form
    {
        public ToplulukList()
        {
            InitializeComponent();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa asf = new AnaSayfa();
            asf.Show();
            this.Close();
        }
    }
}
