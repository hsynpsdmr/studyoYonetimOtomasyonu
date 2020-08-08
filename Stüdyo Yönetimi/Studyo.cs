using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stüdyo_Yönetimi
{
    class Studyo
    {
        private string sAdi;
        private int sTelefon;
        private string sAdres;



        public string ad
        {
            get
            {
                return sAdi;
            }
            set
            {
                sAdi = value;
            }
        }
        
        public int telefon
        {
            get
            {
                return sTelefon;
            }
            set
            {
                sTelefon = value;
            }
        }
        public string adres
        {
            get
            {
                return sAdres;
            }
            set
            {
                sAdres = value;
            }
        }
    }
}

