namespace Stüdyo_Yönetimi
{
    partial class filmStudyosu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.oyuncuListesi = new System.Windows.Forms.ListBox();
            this.oKaydet = new System.Windows.Forms.Button();
            this.oAdi = new System.Windows.Forms.TextBox();
            this.oSoyadi = new System.Windows.Forms.TextBox();
            this.oYasi = new System.Windows.Forms.TextBox();
            this.oDeneyimY = new System.Windows.Forms.TextBox();
            this.oFilmS = new System.Windows.Forms.TextBox();
            this.oRdbErkek = new System.Windows.Forms.RadioButton();
            this.oRdbKadin = new System.Windows.Forms.RadioButton();
            this.oFilmT = new System.Windows.Forms.ComboBox();
            this.platoSayisi = new System.Windows.Forms.TextBox();
            this.yonetmenSayisi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fotoğrafStüdyosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesStüdyosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmStüdyosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oList = new System.Windows.Forms.Button();
            this.gridMusterilerFilm = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusterilerFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // sGeri
            // 
            this.sGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sGeri.Location = new System.Drawing.Point(12, 326);
            this.sGeri.Name = "sGeri";
            this.sGeri.Size = new System.Drawing.Size(36, 23);
            this.sGeri.TabIndex = 0;
            this.sGeri.Text = "Geri";
            this.sGeri.UseVisualStyleBackColor = true;
            this.sGeri.Click += new System.EventHandler(this.sGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deneyim Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Film Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yaşı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Film Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cinsiyeti";
            // 
            // oyuncuListesi
            // 
            this.oyuncuListesi.FormattingEnabled = true;
            this.oyuncuListesi.Location = new System.Drawing.Point(12, 170);
            this.oyuncuListesi.Name = "oyuncuListesi";
            this.oyuncuListesi.Size = new System.Drawing.Size(760, 30);
            this.oyuncuListesi.TabIndex = 9;
            // 
            // oKaydet
            // 
            this.oKaydet.Location = new System.Drawing.Point(360, 141);
            this.oKaydet.Name = "oKaydet";
            this.oKaydet.Size = new System.Drawing.Size(75, 23);
            this.oKaydet.TabIndex = 10;
            this.oKaydet.Text = "KAYDET";
            this.oKaydet.UseVisualStyleBackColor = true;
            this.oKaydet.Click += new System.EventHandler(this.oKaydet_Click);
            // 
            // oAdi
            // 
            this.oAdi.Location = new System.Drawing.Point(82, 32);
            this.oAdi.Name = "oAdi";
            this.oAdi.Size = new System.Drawing.Size(100, 20);
            this.oAdi.TabIndex = 11;
            // 
            // oSoyadi
            // 
            this.oSoyadi.Location = new System.Drawing.Point(82, 66);
            this.oSoyadi.Name = "oSoyadi";
            this.oSoyadi.Size = new System.Drawing.Size(100, 20);
            this.oSoyadi.TabIndex = 12;
            // 
            // oYasi
            // 
            this.oYasi.Location = new System.Drawing.Point(82, 96);
            this.oYasi.Name = "oYasi";
            this.oYasi.Size = new System.Drawing.Size(100, 20);
            this.oYasi.TabIndex = 13;
            // 
            // oDeneyimY
            // 
            this.oDeneyimY.Location = new System.Drawing.Point(344, 32);
            this.oDeneyimY.Name = "oDeneyimY";
            this.oDeneyimY.Size = new System.Drawing.Size(100, 20);
            this.oDeneyimY.TabIndex = 14;
            // 
            // oFilmS
            // 
            this.oFilmS.Location = new System.Drawing.Point(344, 66);
            this.oFilmS.Name = "oFilmS";
            this.oFilmS.Size = new System.Drawing.Size(100, 20);
            this.oFilmS.TabIndex = 15;
            // 
            // oRdbErkek
            // 
            this.oRdbErkek.AutoSize = true;
            this.oRdbErkek.Location = new System.Drawing.Point(82, 130);
            this.oRdbErkek.Name = "oRdbErkek";
            this.oRdbErkek.Size = new System.Drawing.Size(53, 17);
            this.oRdbErkek.TabIndex = 17;
            this.oRdbErkek.TabStop = true;
            this.oRdbErkek.Text = "Erkek";
            this.oRdbErkek.UseVisualStyleBackColor = true;
            // 
            // oRdbKadin
            // 
            this.oRdbKadin.AutoSize = true;
            this.oRdbKadin.Location = new System.Drawing.Point(141, 128);
            this.oRdbKadin.Name = "oRdbKadin";
            this.oRdbKadin.Size = new System.Drawing.Size(52, 17);
            this.oRdbKadin.TabIndex = 18;
            this.oRdbKadin.TabStop = true;
            this.oRdbKadin.Text = "Kadın";
            this.oRdbKadin.UseVisualStyleBackColor = true;
            // 
            // oFilmT
            // 
            this.oFilmT.FormattingEnabled = true;
            this.oFilmT.Location = new System.Drawing.Point(344, 96);
            this.oFilmT.Name = "oFilmT";
            this.oFilmT.Size = new System.Drawing.Size(100, 21);
            this.oFilmT.TabIndex = 19;
            // 
            // platoSayisi
            // 
            this.platoSayisi.Location = new System.Drawing.Point(642, 32);
            this.platoSayisi.Name = "platoSayisi";
            this.platoSayisi.Size = new System.Drawing.Size(100, 20);
            this.platoSayisi.TabIndex = 20;
            // 
            // yonetmenSayisi
            // 
            this.yonetmenSayisi.Location = new System.Drawing.Point(642, 66);
            this.yonetmenSayisi.Name = "yonetmenSayisi";
            this.yonetmenSayisi.Size = new System.Drawing.Size(100, 20);
            this.yonetmenSayisi.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Plato Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Yönetmen Sayısı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fotoğrafStüdyosuToolStripMenuItem,
            this.sesStüdyosuToolStripMenuItem,
            this.filmStüdyosuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fotoğrafStüdyosuToolStripMenuItem
            // 
            this.fotoğrafStüdyosuToolStripMenuItem.Name = "fotoğrafStüdyosuToolStripMenuItem";
            this.fotoğrafStüdyosuToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.fotoğrafStüdyosuToolStripMenuItem.Text = "Fotoğraf Stüdyosu";
            this.fotoğrafStüdyosuToolStripMenuItem.Click += new System.EventHandler(this.fotoğrafStüdyosuToolStripMenuItem_Click);
            // 
            // sesStüdyosuToolStripMenuItem
            // 
            this.sesStüdyosuToolStripMenuItem.Name = "sesStüdyosuToolStripMenuItem";
            this.sesStüdyosuToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.sesStüdyosuToolStripMenuItem.Text = "Ses Stüdyosu";
            this.sesStüdyosuToolStripMenuItem.Click += new System.EventHandler(this.sesStüdyosuToolStripMenuItem_Click);
            // 
            // filmStüdyosuToolStripMenuItem
            // 
            this.filmStüdyosuToolStripMenuItem.Name = "filmStüdyosuToolStripMenuItem";
            this.filmStüdyosuToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.filmStüdyosuToolStripMenuItem.Text = "Film Stüdyosu";
            this.filmStüdyosuToolStripMenuItem.Click += new System.EventHandler(this.filmStüdyosuToolStripMenuItem_Click);
            // 
            // oList
            // 
            this.oList.Location = new System.Drawing.Point(687, 140);
            this.oList.Name = "oList";
            this.oList.Size = new System.Drawing.Size(84, 23);
            this.oList.TabIndex = 25;
            this.oList.Text = "Oyuncu Listesi";
            this.oList.UseVisualStyleBackColor = true;
            this.oList.Click += new System.EventHandler(this.oList_Click);
            // 
            // gridMusterilerFilm
            // 
            this.gridMusterilerFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusterilerFilm.Location = new System.Drawing.Point(13, 216);
            this.gridMusterilerFilm.Name = "gridMusterilerFilm";
            this.gridMusterilerFilm.Size = new System.Drawing.Size(758, 95);
            this.gridMusterilerFilm.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(519, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(519, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 29;
            // 
            // filmStudyosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sGeri;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridMusterilerFilm);
            this.Controls.Add(this.oList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yonetmenSayisi);
            this.Controls.Add(this.platoSayisi);
            this.Controls.Add(this.oFilmT);
            this.Controls.Add(this.oRdbKadin);
            this.Controls.Add(this.oRdbErkek);
            this.Controls.Add(this.oFilmS);
            this.Controls.Add(this.oDeneyimY);
            this.Controls.Add(this.oYasi);
            this.Controls.Add(this.oSoyadi);
            this.Controls.Add(this.oAdi);
            this.Controls.Add(this.oKaydet);
            this.Controls.Add(this.oyuncuListesi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sGeri);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "filmStudyosu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.filmStudyosu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusterilerFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox oyuncuListesi;
        private System.Windows.Forms.Button oKaydet;
        private System.Windows.Forms.TextBox oAdi;
        private System.Windows.Forms.TextBox oSoyadi;
        private System.Windows.Forms.TextBox oYasi;
        private System.Windows.Forms.TextBox oDeneyimY;
        private System.Windows.Forms.TextBox oFilmS;
        private System.Windows.Forms.RadioButton oRdbErkek;
        private System.Windows.Forms.RadioButton oRdbKadin;
        private System.Windows.Forms.ComboBox oFilmT;
        private System.Windows.Forms.TextBox platoSayisi;
        private System.Windows.Forms.TextBox yonetmenSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fotoğrafStüdyosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesStüdyosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmStüdyosuToolStripMenuItem;
        private System.Windows.Forms.Button oList;
        private System.Windows.Forms.DataGridView gridMusterilerFilm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}