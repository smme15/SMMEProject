using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMME_Deneme1
{
    public partial class twitterLogin : Form
    {
        public twitterLogin()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            girisEkranı grs = new girisEkranı();
            this.Hide();
            grs.Show();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            setting set = new setting();
            set.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            settings set = new settings();
            set.Show();

=======
            Application.Exit();
>>>>>>> master
        }
    }
}
