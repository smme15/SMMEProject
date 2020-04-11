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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void facebookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            facebookLogin loginF = new facebookLogin();
            loginF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void instagramButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            instagramLogin loginI = new instagramLogin();
            loginI.Show();
        }
    }
}
