using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMME_Deneme1
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }
        public static string Notification = "";
        private bildirimEkrani bde = null;

        private void sendNoti_Click(object sender, EventArgs e)
        {
            Notification = notiText.Text;
            if(bde != null)
            {
                bde.changeNotify();
            }
        }      


        private void button1_Click(object sender, EventArgs e)
        {
            bde = new bildirimEkrani();
            bde.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            girisEkranı grs = new girisEkranı();
            grs.Show();
        }
    }
}
