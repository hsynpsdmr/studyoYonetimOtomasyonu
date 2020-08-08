using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stüdyo_Yönetimi
{
    public class Kisi
    {
        private string kAdi;
        private string kSoyadi;
        private int kYasi;
        private string kCinsiyeti;

        

        public string ad
        {
            get
            {
                return kAdi;
            }
            set
            {
                kAdi = value;
            }
        }
        public string soyad
        {
            get
            {
                return kSoyadi;
            }
            set
            {
                kSoyadi = value;
            }
        }
        public int yas
        {
            get
            {
                return kYasi;
            }
            set
            {
                kYasi = value;
            }
        }
        public string cinsiyet
        {
            get
            {
                return kCinsiyeti;
            }
            set
            {
                kCinsiyeti = value;
            }
        }
    }
}
