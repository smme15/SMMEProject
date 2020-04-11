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
    public partial class bildirimEkrani : Form
    {
        public bildirimEkrani()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int deger = int.Parse(bildirimSuresi.Text);
            
            if (deger >= 0 && deger <= 59)
            {
                bildirimSuresi.Text = deger.ToString();
                bildirimZamani.Text = "sn. Önce";
            }
            else if (deger >= 60)
            {
                int deger1 = deger / 60;
                bildirimSuresi.Text = deger1.ToString();
                bildirimZamani.Text = "dk. Önce";
            }

            deger++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
