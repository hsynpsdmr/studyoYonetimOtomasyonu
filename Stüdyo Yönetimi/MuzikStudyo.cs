using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stüdyo_Yönetimi
{
    class MuzikStudyo: Studyo
    {
        private int kayitOdaSayisi;
        private int djSayisi;

        public int kOdaSay
        {
            get
            {
                return kayitOdaSayisi;
            }
            set
            {
                kayitOdaSayisi = value;
            }
        }

        public int djSay
        {
            get
            {
                return djSayisi;
            }
            set
            {
                djSayisi = value;
            }
        }
    }
}
