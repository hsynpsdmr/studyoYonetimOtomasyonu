using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Stüdyo_Yönetimi
{
    public partial class sesStudyosu : Form
    {
        public sYonetimi sy;
        DataTable tablo;
        DataSet dset = new DataSet("Sanatçı Listesi");
        public sesStudyosu()
        {
            InitializeComponent();
        }
       
        private void sesStudyosu_Load(object sender, EventArgs e)
        {
            yukle();
            sSarkiT.Items.Add("Lütfen Seçiniz...");
            sSarkiT.Items.Add("Rock");
            sSarkiT.Items.Add("Pop");
            sSarkiT.Items.Add("Rap");
            sSarkiT.Items.Add("Caz");
            sSarkiT.Items.Add("R&B");
            tablo = new DataTable("Sanatçılar");
            
            dset.Tables.Add(tablo);
            tablo.Columns.Add("Ad");
            tablo.Columns.Add("Soyad");
            tablo.Columns.Add("Yaş");
            tablo.Columns.Add("Cinsiyet");
            tablo.Columns.Add("Albüm Sayısı");
            tablo.Columns.Add("Şarkı Türü");
            tablo.Columns.Add("Kişi Sayısı");
            tablo.Columns.Add("Kayıt Oda Sayısı");
            tablo.Columns.Add("DJ Sayısı");
        }

        private void sGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            sy.std.Show();
        }

        private void fotoğrafStüdyosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            sy.fotoStd.Show();
        }

        private void sesStüdyosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            sy.sesStd.Show();
        }

        private void filmStüdyosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            sy.filmStd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sAdi.Text==""||sSoyadi.Text==""||sYasi.Text==""||sAlbumS.Text==""||sSarkiT.Text==""||sKisiS.Text==""||skOdaSay.Text==""||sDjSay.Text=="")
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MuzikStudyo muzikstd = new MuzikStudyo();
                Sanatci muzikStd = new Sanatci();
                muzikStd.ad = sAdi.Text;
                muzikStd.soyad = sSoyadi.Text;
                muzikStd.yas = Int32.Parse(sYasi.Text);
                muzikStd.albumS = Int32.Parse(sAlbumS.Text);
                muzikStd.sarkiT = sSarkiT.Text;
                muzikStd.kisiS = Int32.Parse(sKisiS.Text);
                muzikstd.kOdaSay = Int32.Parse(skOdaSay.Text);
                muzikstd.djSay = Int32.Parse(sDjSay.Text);
                if (sRdbErkek.Checked == true)
                    muzikStd.cinsiyet = "Erkek";
                else
                    muzikStd.cinsiyet = "Kadın";

                string muzikStdBilgi = muzikStd.ad + " - " + muzikStd.soyad + " - " + muzikStd.yas + " - " + muzikStd.cinsiyet + " - " +
                    muzikStd.albumS + " - " + muzikStd.sarkiT + " - " + muzikStd.kisiS + " - " + muzikstd.kOdaSay + " - " + muzikstd.djSay;

                sanatciListesi.Items.Add(muzikStdBilgi);

                MessageBox.Show("Kayıt Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sRdbErkek.Checked = false;
                sRdbKadin.Checked = false;
                sSarkiT.SelectedIndex = 0;

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tbox = (TextBox)item;
                        tbox.Clear();
                    }
                }
                //XML
              
                dset.WriteXml("musteriSes.xml", XmlWriteMode.WriteSchema);

                DataRow satir = tablo.NewRow();
                satir["Ad"] = muzikStd.ad;
                satir["Soyad"] = muzikStd.soyad;
                satir["Yaş"] = muzikStd.yas;
                satir["Cinsiyet"] = muzikStd.cinsiyet;
                satir["Albüm Sayısı"] = muzikStd.albumS;
                satir["Şarkı Türü"] = muzikStd.sarkiT;
                satir["Kişi Sayısı"] = muzikStd.kisiS;
                satir["Kayıt Oda Sayısı"] = muzikstd.kOdaSay;
                satir["DJ Sayısı"] = muzikstd.djSay;

                tablo.Rows.Add(satir);

                
                dset.WriteXml("musteriSes.xml");
                

                gridMusterilerSes.DataSource = dset.Tables[0];
                
            }
        }
        
        private void sList_Click(object sender, EventArgs e)
        {
            yukle();
        }

        private void sanatciListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sAdi_TextChanged(object sender, EventArgs e)
        {

        }
       void yukle()
        {
            XmlDocument i = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"musteriSes.xml", new XmlReaderSettings());
            
            ds.ReadXml(xmlFile);
            gridMusterilerSes.DataSource = ds.Tables[0];
            xmlFile.Close();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"musteriSes.xml");
            x.Root.Elements().Where(a => a.Element("Ad").Value == textBox1.Text).Remove();
            x.Root.Elements().Where(a => a.Element("Soyad").Value == textBox2.Text).Remove();
            x.Save(@"musteriSes.xml");
            yukle();
            
        }
    }
}
