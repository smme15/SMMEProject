using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SMME_Deneme1
{
    class ses
    {
        public static Assembly a = Assembly.GetExecutingAssembly();
        public static Stream s = a.GetManifestResourceStream("SMME_Deneme1.Sounds.butonsesi.wav");
        public static System.Media.SoundPlayer sp = new System.Media.SoundPlayer(s);
        public ses() 
        {
        
        }
        public static void sesKoy() 
        {
            sp.Play();
        }

        [DllImport("winmm.dll")]
        private static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public static void SesAyarla(int volume)
        {
            int NewVolume = ((ushort.MaxValue / 10) * volume);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        internal void sesAyarla(int v)
        {
            throw new NotImplementedException();
        }
    }
}
