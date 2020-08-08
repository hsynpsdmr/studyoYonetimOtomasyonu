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
    public partial class filmStudyosu : Form
    {
        public sYonetimi sy;
        DataTable tablo;
        DataSet dset = new DataSet("Oyuncu Listesi");
        public filmStudyosu()
        {
            InitializeComponent();
        }

        private void sGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            sy.std.Show();
        }

        private void oKaydet_Click(object sender, EventArgs e)
        {
            if (oAdi.Text == "" || oSoyadi.Text == "" || oYasi.Text == "" || oDeneyimY.Text == "" || oFilmS.Text == "" || oFilmT.Text == "" || platoSayisi.Text == "" || yonetmenSayisi.Text == "")
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                FilmStudyo filmstd = new FilmStudyo();
                Oyuncu filmStd = new Oyuncu();
                filmStd.ad = (oAdi.Text);
                filmStd.soyad = (oSoyadi.Text);
                filmStd.yas = Int32.Parse(oYasi.Text);
                filmStd.deneyimY = Int32.Parse(oDeneyimY.Text);
                filmStd.filmS = Int32.Parse(oFilmS.Text);
                filmStd.filmT = (oFilmT.Text);
                filmstd.platoSay = Int32.Parse(platoSayisi.Text);
                filmstd.yonetmenSay = Int32.Parse(yonetmenSayisi.Text);
                if (oRdbErkek.Checked == true)
                    filmStd.cinsiyet = "Erkek";
                else
                    filmStd.cinsiyet = "Kadın"; 

                string filmStdBilgi = filmStd.ad + " - " + filmStd.soyad + " - " + filmStd.yas + " - " + filmStd.cinsiyet + " " +
                    filmStd.deneyimY + " - " + filmStd.filmS + " - " + filmStd.filmT + " - " + filmstd.platoSay + " - " + filmstd.yonetmenSay;

                oyuncuListesi.Items.Add(filmStdBilgi);

                MessageBox.Show("Kayıt Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                oRdbErkek.Checked = false;
                oRdbKadin.Checked = false;
                oFilmT.SelectedIndex = 0;

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tbox = (TextBox)item;
                        tbox.Clear();
                    }
                }



                dset.WriteXml("musteriSes.xml", XmlWriteMode.WriteSchema);
                DataRow satir = tablo.NewRow();
                satir["Ad"] = filmStd.ad;
                satir["Soyad"] = filmStd.soyad;
                satir["Yaş"] = filmStd.yas;
                satir["Cinsiyet"] = filmStd.cinsiyet;
                satir["Deneyim"] = filmStd.deneyimY;
                satir["Film Sayısı"] = filmStd.filmS;
                satir["Film Türü"] = filmStd.filmT;
                satir["Plato Sayısı"] = filmstd.platoSay;
                satir["Yönetmen Sayısı"] = filmstd.yonetmenSay;

                tablo.Rows.Add(satir);

                
                dset.WriteXml("musteriFilm.xml");
               

                gridMusterilerFilm.DataSource = dset.Tables[0];
            }
        }
        void yukle()
        {
            XmlDocument i = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"musteriFilm.xml", new XmlReaderSettings());

            ds.ReadXml(xmlFile);
            gridMusterilerFilm.DataSource = ds.Tables[0];
            xmlFile.Close();
        }
        private void filmStudyosu_Load(object sender, EventArgs e)
        {
            yukle();
            oFilmT.Items.Add("Lütfen Seçiniz...");
            oFilmT.Items.Add("Aksiyon");
            oFilmT.Items.Add("Dram");
            oFilmT.Items.Add("Komedi");
            oFilmT.Items.Add("Korku");

            oFilmT.SelectedIndex = 0;
            tablo = new DataTable("Oyunculer");
            dset.Tables.Add(tablo);
            tablo.Columns.Add("Ad");
            tablo.Columns.Add("Soyad");
            tablo.Columns.Add("Yaş");
            tablo.Columns.Add("Cinsiyet");
            tablo.Columns.Add("Deneyim");
            tablo.Columns.Add("Film Sayısı");
            tablo.Columns.Add("Film Türü");
            tablo.Columns.Add("Plato Sayısı");
            tablo.Columns.Add("Yönetmen Sayısı");
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

        private void oList_Click(object sender, EventArgs e)
        {
            yukle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"musteriFilm.xml");
            x.Root.Elements().Where(a => a.Element("Ad").Value == textBox1.Text).Remove();
            x.Root.Elements().Where(a => a.Element("Soyad").Value == textBox2.Text).Remove();
            x.Save(@"musteriFilm.xml");
            yukle();
        }
    }
}
