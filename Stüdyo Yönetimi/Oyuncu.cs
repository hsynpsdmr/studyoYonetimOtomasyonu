using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stüdyo_Yönetimi
{
    class Oyuncu : Kisi
    {
        public int deneyimYili;
        private int filmSayisi;
        private string filmTuru;


        public int deneyimY
        {
            get
            {
                return deneyimYili;
            }
            set
            {
                deneyimYili = value;
            }
        }
        public int filmS
        {
            get
            {
                return filmSayisi;
            }
            set
            {
                filmSayisi = value;
            }
        }
        public string filmT
        {
            get
            {
                return filmTuru;
            }
            set
            {
                filmTuru = value;
            }
        }
    }
}
