using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMME_Deneme1
{
    public partial class girisEkranı : Form
    {
        ses ses1 = new ses();
        
        
        
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
            if (setting.uygulamaSesi == true)
            {
                ses.sesKoy();
            }
            else 
            {
                
            }
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
            setting set1 = new setting();
            set1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (setting.uygulamaSesi == true)
            {
                ses.sesKoy();
            }
            else
            {

            }
            facebookLogin loginF = new facebookLogin();
            this.Hide();
            loginF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (setting.uygulamaSesi == true)
            {
                ses.sesKoy();
            }
            else
            {

            }
            Panel loginI = new Panel();
            this.Hide();
            loginI.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
