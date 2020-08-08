using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stüdyo_Yönetimi
{
    class Musteri : Kisi
    {
        private string cekimTuru;
        private string fotoTuru;
        private int fotoAdeti;

        public string cekimT
        {
            get
            {
                return cekimTuru;
            }
            set
            {
                cekimTuru = value;
            }
        }
        public string fotoT
        {
            get
            {
                return fotoTuru;
            }
            set
            {
                fotoTuru = value;
            }
        }
        public int fotoA
        {
            get
            {
                return fotoAdeti;
            }
            set
            {
                fotoAdeti = value;
            }
        }
    } 
}
