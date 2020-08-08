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
    public partial class studyolar : Form
    {
        public sYonetimi sy;
        public studyolar()
        {
            InitializeComponent();
        }

        private void fotoStd_Click(object sender, EventArgs e)
        {
            this.Hide();
            sy.fotoStd.Show();
        }

        private void sesStd_Click(object sender, EventArgs e)
        {
            this.Hide();
            sy.sesStd.Show();
        }

        private void filmStd_Click(object sender, EventArgs e)
        {
            this.Hide();
            sy.filmStd.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
