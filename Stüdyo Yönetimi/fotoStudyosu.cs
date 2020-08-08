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
    public partial class fotoStudyosu : Form
    {

        public sYonetimi sy;
        DataTable tablo;
        DataSet dset = new DataSet("Model Listesi");
        public fotoStudyosu()
        {
            InitializeComponent();
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

        private void mKaydet_Click_1(object sender, EventArgs e)
        {
            if (mAdi.Text == "" || mSoyadi.Text == "" || mYasi.Text == "" || mFotoT.Text == "" || mFotoA.Text == "" || mcOdaSay.Text == "" || mFotografciSay.Text == "")
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FotoStudyo fotostd = new FotoStudyo();
                Musteri fotoStd = new Musteri();
                fotoStd.ad = mAdi.Text;
                fotoStd.soyad = mSoyadi.Text;
                fotoStd.yas = Int32.Parse(mYasi.Text);
                fotoStd.fotoT = mFotoT.Text;
                fotoStd.fotoA = Int32.Parse(mFotoA.Text);
                fotostd.odaSay = Int32.Parse(mcOdaSay.Text);
                fotostd.fotografciSay = Int32.Parse(mFotografciSay.Text);
                if (mRdbErkek.Checked == true)
                    fotoStd.cinsiyet = "Erkek";
                else
                    fotoStd.cinsiyet = "Kadın";
                if (mRdbIc.Checked == true)
                    fotoStd.cinsiyet = "İç Çekim";
                else
                    fotoStd.cinsiyet = "Dış Çekim";

                string fotoStdBilgi = fotoStd.ad + " - " + fotoStd.soyad + " - " + fotoStd.yas + " - " + fotoStd.cinsiyet + " - " + 
                    fotoStd.cekimT + " - " + fotoStd.fotoT + " - " + fotoStd.fotoA + " - " + fotostd.odaSay + " - " + fotostd.fotografciSay;

                musteriListesi.Items.Add(fotoStdBilgi);

                MessageBox.Show("Kayıt Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mRdbErkek.Checked = false;
                mRdbKadin.Checked = false;
                mRdbIc.Checked = false;
                mRdbDis.Checked = false;
                mFotoT.SelectedIndex = 0;

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tbox = (TextBox)item;
                        tbox.Clear();
                    }
                }

                dset.WriteXml("musteriFoto.xml", XmlWriteMode.WriteSchema);


                DataRow satir = tablo.NewRow();
                satir["Ad"] = fotoStd.ad;
                satir["Soyad"] = fotoStd.soyad;
                satir["Yaş"] = fotoStd.yas;
                satir["Cinsiyet"] = fotoStd.cinsiyet;
                satir["Çekim Türü"] = fotoStd.cekimT;
                satir["Fotoğraf Türü"] = fotoStd.fotoT;
                satir["Fotoğraf Adedi"] = fotoStd.fotoA;
                satir["Çekim Oda Sayısı"] = fotostd.odaSay;
                satir["Fotoğrafçı Sayısı"] = fotostd.fotografciSay;

                tablo.Rows.Add(satir);

                
                dset.WriteXml("musteriFoto.xml");
                

                gridMusterilerFoto.DataSource = dset.Tables[0];
            }
        }
        void yukle()
        {
            XmlDocument i = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"musteriFoto.xml", new XmlReaderSettings());

            ds.ReadXml(xmlFile);
            gridMusterilerFoto.DataSource = ds.Tables[0];
            xmlFile.Close();
        }
        private void fotoStudyosu_Load(object sender, EventArgs e)
        {
            yukle();
            mFotoT.Items.Add("Lütfen Seçiniz...");
            mFotoT.Items.Add("Vesikalık");
            mFotoT.Items.Add("Biometrik");
            mFotoT.Items.Add("Albüm");
            tablo = new DataTable("Modeller");
            mFotoT.SelectedIndex = 0;

            dset.Tables.Add(tablo);
            tablo.Columns.Add("Ad");
            tablo.Columns.Add("Soyad");
            tablo.Columns.Add("Yaş");
            tablo.Columns.Add("Cinsiyet");
            tablo.Columns.Add("Çekim Türü");
            tablo.Columns.Add("Fotoğraf Türü");
            tablo.Columns.Add("Fotoğraf Adedi");
            tablo.Columns.Add("Çekim Oda Sayısı");
            tablo.Columns.Add("Fotoğrafçı Sayısı");
        }

        private void mList_Click(object sender, EventArgs e)
        {
            yukle();
        }

        private void gridMusterilerFoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int index = e.RowIndex;
            DataGridViewRow selectedRow = gridMusterilerFoto.Rows[index];

            mAdi.Text = selectedRow.Cells[0].Value.ToString();
            mSoyadi.Text = selectedRow.Cells[1].Value.ToString();
            mYasi.Text = selectedRow.Cells[2].Value.ToString();
            mFotoT.Text = selectedRow.Cells[3].Value.ToString();
            mFotoA.Text = selectedRow.Cells[4].Value.ToString();
            mcOdaSay.Text = selectedRow.Cells[5].Value.ToString();
            mFotografciSay.Text = selectedRow.Cells[6].Value.ToString();
            //textBox6.Text = selectedRow.Cells[1].Value.ToString();
            //textBox7.Text = selectedRow.Cells[2].Value.ToString();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"musteriFoto.xml");
            x.Root.Elements().Where(a => a.Element("Ad").Value == textBox1.Text).Remove();
            x.Root.Elements().Where(a => a.Element("Soyad").Value == textBox2.Text).Remove();
            x.Save(@"musteriFoto.xml");
            yukle();
        }

       
    }
}
