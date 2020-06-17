using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMME_Deneme1
{
    public partial class setting : Form
    {
        bildirimEkrani bld = new bildirimEkrani();
        public setting()
        {
            InitializeComponent();
        }

        public static bool uygulamaSesi = true;

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultColor = SystemColors.ControlLightLight;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultColor = SystemColors.ControlDarkDark;
            Properties.Settings.Default.Save();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sessizButton_Click(object sender, EventArgs e)
        {
            uygulamaSesi = false;            
        }

        private void sesliButton_Click(object sender, EventArgs e)
        {
            uygulamaSesi = true;
        }

        private void bizleAcik_Click(object sender, EventArgs e)
        {
            
        }

    }
}
