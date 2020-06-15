using Facebook.User;
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
    public partial class facebookLogin : Form
    {
        public facebookLogin()
        {
            InitializeComponent();
            this.txtEmail.Text = "sekoyilmaz14@hotmail.com";
            this.txtPassword.Text = "yilkar1312";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backicon_Click(object sender, EventArgs e)
        {

            girisEkranı grs = new girisEkranı();
            this.Hide();
            grs.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            girisEkranı grs = new girisEkranı();
            this.Hide();
            grs.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setting set = new setting();
            set.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtEmail.Text) || String.IsNullOrEmpty(this.txtPassword.Text))
                {
                    // Dialog 

                    //returnu silme
                    return;
                }


                var user = new UserEndpoint(username: this.txtEmail.Text, password: this.txtPassword.Text);
                facebookManager face = new facebookManager(user);
                this.Hide();
                face.Show();

            }
            catch (Exception ex)
            {
                //Dialog çıkar ve şifre veya username hatalı
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void facebookLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
