using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stüdyo_Yönetimi
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new sYonetimi());

            Kisi ks = new Kisi();
            Sanatci sn = new Sanatci();
            Oyuncu oy = new Oyuncu();
            Musteri ms = new Musteri();
        }
    }
}
