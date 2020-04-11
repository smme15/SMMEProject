using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMME_Deneme1
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.   asdddsdasd
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new girisEkranı());
        }
    }
}
