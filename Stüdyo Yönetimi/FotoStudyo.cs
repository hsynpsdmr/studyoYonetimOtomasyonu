using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stüdyo_Yönetimi
{
    class FotoStudyo : Studyo
    {
        
        private int cekimOdaSayisi;
        private int fotografciSayisi;

        public int odaSay
        {
            get
            {
                return cekimOdaSayisi;
            }
            set
            {
                cekimOdaSayisi = value;
            }
        }
        
        public int fotografciSay
        {
            get
            {
                return fotografciSayisi;
            }
            set
            {
                fotografciSayisi = value;
            }
        }
    }
}