using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stüdyo_Yönetimi
{
    class Sanatci : Kisi
    {
        private int albumSayisi;
        private string sarkiTuru;
        private int kisiSayisi;

        public static string dosyaOyuncu = "musteriSes.xml";

        public DataSet dsOyuncu = new DataSet("Musteri Listesi");
        public DataTable tablo = new DataTable("Musteriler");
        private void DataSetOlustur()
        {
            /*if (System.IO.File.Exists(dosyaOyuncu))
            {
                dsOyuncu.ReadXml(dosyaOyuncu);
                tablo = dsOyuncu.Tables[0];
            }
            else //Dosya yoksa ilk defa kayıt için DataTable oluştur:
            {*/
                tablo.Columns.Add("Ad");
                tablo.Columns.Add("Soyad");
                tablo.Columns.Add("Yaş");
                tablo.Columns.Add("Cinsiyet");
                tablo.Columns.Add("Albüm Sayısı");
                tablo.Columns.Add("Şarkı Türü");
                tablo.Columns.Add("Kişi Sayısı");
                tablo.Columns.Add("Kayıt Oda Sayısı");
                tablo.Columns.Add("DJ Sayısı");

                dsOyuncu.Tables.Add(tablo);

                dsOyuncu.WriteXml(dosyaOyuncu, XmlWriteMode.WriteSchema);
            

        }
        public Sanatci()
        {
            DataSetOlustur();
        }
        public DataTable oyuncuListesi()
        {
            return tablo;
        }
        public int albumS
        {
            get
            {
                return albumSayisi;
            }
            set
            {
                albumSayisi = value;
            }
        }
        public string sarkiT
        {
            get
            {
                return sarkiTuru;
            }
            set
            {
                sarkiTuru = value;
            }
        }
        public int kisiS
        {
            get
            {
                return kisiSayisi;
            }
            set
            {
                kisiSayisi = value;
            }
        }
    }
}
 