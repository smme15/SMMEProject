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
    public partial class girisEkranı : Form
    {
        public girisEkranı()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void twitterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            twitterLogin loginT = new twitterLogin();
            loginT.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settings set1 = new settings();
            set1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            facebookLogin loginF = new facebookLogin();
            this.Hide();
            loginF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            instagramLogin loginI = new instagramLogin();
            this.Hide();
            loginI.Show();
        }
    }
}
