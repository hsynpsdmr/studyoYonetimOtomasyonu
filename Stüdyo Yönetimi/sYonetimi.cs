using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stüdyo_Yönetimi
{
    
    public partial class sYonetimi : Form
    {
        
        public studyolar std;
        public fotoStudyosu fotoStd;
        public sesStudyosu sesStd;
        public filmStudyosu filmStd;

        public sYonetimi()
        {
            InitializeComponent();
            std = new studyolar();
            fotoStd = new fotoStudyosu();
            sesStd = new sesStudyosu();
            filmStd = new filmStudyosu();


            std.sy = this;
            fotoStd.sy = this;
            sesStd.sy = this;
            filmStd.sy = this;


        }

        private void giris_Click(object sender, EventArgs e)
        {
            string akAdi,akSifre;
            akAdi = kAdi.Text;
            akSifre = kSifre.Text;
            if (akAdi == "" && akSifre == "")
            {
                //MessageBox.Show("Giriş Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                std.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sGoster_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (sGoster.Checked)
            {
                //karakteri göster.
                kSifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                kSifre.PasswordChar = '*';
            }
        }

        private void kSifre_TextChanged(object sender, EventArgs e)
        {
            kSifre.PasswordChar = '*';
        }

        private void kAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
