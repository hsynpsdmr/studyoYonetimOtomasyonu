using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stüdyo_Yönetimi
{
    class FilmStudyo:Studyo
    {
        private int platoSayisi;
        private int yonetmenSayisi;

        public int platoSay
        {
            get
            {
                return platoSayisi;
            }
            set
            {
                platoSayisi = value;
            }
        }

        public int yonetmenSay
        {
            get
            {
                return yonetmenSayisi;
            }
            set
            {
                yonetmenSayisi = value;
            }
        }
    }
}
