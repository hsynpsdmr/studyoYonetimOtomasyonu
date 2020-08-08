namespace Stüdyo_Yönetimi
{
    partial class sesStudyosu
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
            this.button1 = new System.Windows.Forms.Button();
            this.sanatciListesi = new System.Windows.Forms.ListBox();
            this.sAdi = new System.Windows.Forms.TextBox();
            this.sSoyadi = new System.Windows.Forms.TextBox();
            this.sYasi = new System.Windows.Forms.TextBox();
            this.sAlbumS = new System.Windows.Forms.TextBox();
            this.sKisiS = new System.Windows.Forms.TextBox();
            this.sRdbErkek = new System.Windows.Forms.RadioButton();
            this.sRdbKadin = new System.Windows.Forms.RadioButton();
            this.sSarkiT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.skOdaSay = new System.Windows.Forms.TextBox();
            this.sDjSay = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fotoğrafStüdyosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesStüdyosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmStüdyosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sList = new System.Windows.Forms.Button();
            this.gridMusterilerSes = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusterilerSes)).BeginInit();
            this.SuspendLayout();
            // 
            // sGeri
            // 
            this.sGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sGeri.Location = new System.Drawing.Point(12, 326);
            this.sGeri.Name = "sGeri";
            this.sGeri.Size = new System.Drawing.Size(34, 23);
            this.sGeri.TabIndex = 0;
            this.sGeri.Text = "Geri";
            this.sGeri.UseVisualStyleBackColor = true;
            this.sGeri.Click += new System.EventHandler(this.sGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Albüm Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şarkı Türü";
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
            this.label6.Location = new System.Drawing.Point(253, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kişi Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cinsiyeti";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sanatciListesi
            // 
            this.sanatciListesi.FormattingEnabled = true;
            this.sanatciListesi.Location = new System.Drawing.Point(12, 171);
            this.sanatciListesi.Name = "sanatciListesi";
            this.sanatciListesi.Size = new System.Drawing.Size(760, 30);
            this.sanatciListesi.TabIndex = 10;
            this.sanatciListesi.SelectedIndexChanged += new System.EventHandler(this.sanatciListesi_SelectedIndexChanged);
            // 
            // sAdi
            // 
            this.sAdi.Location = new System.Drawing.Point(72, 30);
            this.sAdi.Name = "sAdi";
            this.sAdi.Size = new System.Drawing.Size(100, 20);
            this.sAdi.TabIndex = 11;
            this.sAdi.TextChanged += new System.EventHandler(this.sAdi_TextChanged);
            // 
            // sSoyadi
            // 
            this.sSoyadi.Location = new System.Drawing.Point(72, 61);
            this.sSoyadi.Name = "sSoyadi";
            this.sSoyadi.Size = new System.Drawing.Size(100, 20);
            this.sSoyadi.TabIndex = 12;
            // 
            // sYasi
            // 
            this.sYasi.Location = new System.Drawing.Point(72, 96);
            this.sYasi.Name = "sYasi";
            this.sYasi.Size = new System.Drawing.Size(100, 20);
            this.sYasi.TabIndex = 13;
            // 
            // sAlbumS
            // 
            this.sAlbumS.Location = new System.Drawing.Point(336, 30);
            this.sAlbumS.Name = "sAlbumS";
            this.sAlbumS.Size = new System.Drawing.Size(100, 20);
            this.sAlbumS.TabIndex = 14;
            // 
            // sKisiS
            // 
            this.sKisiS.Location = new System.Drawing.Point(336, 96);
            this.sKisiS.Name = "sKisiS";
            this.sKisiS.Size = new System.Drawing.Size(100, 20);
            this.sKisiS.TabIndex = 16;
            // 
            // sRdbErkek
            // 
            this.sRdbErkek.AutoSize = true;
            this.sRdbErkek.Location = new System.Drawing.Point(72, 129);
            this.sRdbErkek.Name = "sRdbErkek";
            this.sRdbErkek.Size = new System.Drawing.Size(53, 17);
            this.sRdbErkek.TabIndex = 17;
            this.sRdbErkek.TabStop = true;
            this.sRdbErkek.Text = "Erkek";
            this.sRdbErkek.UseVisualStyleBackColor = true;
            // 
            // sRdbKadin
            // 
            this.sRdbKadin.AutoSize = true;
            this.sRdbKadin.Location = new System.Drawing.Point(131, 129);
            this.sRdbKadin.Name = "sRdbKadin";
            this.sRdbKadin.Size = new System.Drawing.Size(52, 17);
            this.sRdbKadin.TabIndex = 18;
            this.sRdbKadin.TabStop = true;
            this.sRdbKadin.Text = "Kadın";
            this.sRdbKadin.UseVisualStyleBackColor = true;
            // 
            // sSarkiT
            // 
            this.sSarkiT.FormattingEnabled = true;
            this.sSarkiT.Location = new System.Drawing.Point(336, 61);
            this.sSarkiT.Name = "sSarkiT";
            this.sSarkiT.Size = new System.Drawing.Size(100, 21);
            this.sSarkiT.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kayıt Oda Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dj Sayısı";
            // 
            // skOdaSay
            // 
            this.skOdaSay.Location = new System.Drawing.Point(652, 30);
            this.skOdaSay.Name = "skOdaSay";
            this.skOdaSay.Size = new System.Drawing.Size(100, 20);
            this.skOdaSay.TabIndex = 22;
            // 
            // sDjSay
            // 
            this.sDjSay.Location = new System.Drawing.Point(652, 61);
            this.sDjSay.Name = "sDjSay";
            this.sDjSay.Size = new System.Drawing.Size(100, 20);
            this.sDjSay.TabIndex = 23;
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
            // sList
            // 
            this.sList.Location = new System.Drawing.Point(686, 142);
            this.sList.Name = "sList";
            this.sList.Size = new System.Drawing.Size(85, 23);
            this.sList.TabIndex = 25;
            this.sList.Text = "Sanatçı Listesi";
            this.sList.UseVisualStyleBackColor = true;
            this.sList.Click += new System.EventHandler(this.sList_Click);
            // 
            // gridMusterilerSes
            // 
            this.gridMusterilerSes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusterilerSes.Location = new System.Drawing.Point(14, 212);
            this.gridMusterilerSes.Name = "gridMusterilerSes";
            this.gridMusterilerSes.Size = new System.Drawing.Size(756, 99);
            this.gridMusterilerSes.TabIndex = 26;
            //this.gridMusterilerSes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMusteriler_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(617, 113);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(511, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(511, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 29;
            // 
            // sesStudyosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.sGeri;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.gridMusterilerSes);
            this.Controls.Add(this.sList);
            this.Controls.Add(this.sDjSay);
            this.Controls.Add(this.skOdaSay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sSarkiT);
            this.Controls.Add(this.sRdbKadin);
            this.Controls.Add(this.sRdbErkek);
            this.Controls.Add(this.sKisiS);
            this.Controls.Add(this.sAlbumS);
            this.Controls.Add(this.sYasi);
            this.Controls.Add(this.sSoyadi);
            this.Controls.Add(this.sAdi);
            this.Controls.Add(this.sanatciListesi);
            this.Controls.Add(this.button1);
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
            this.Name = "sesStudyosu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ses Stüdyosu";
            this.Load += new System.EventHandler(this.sesStudyosu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusterilerSes)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox sanatciListesi;
        private System.Windows.Forms.TextBox sAdi;
        private System.Windows.Forms.TextBox sSoyadi;
        private System.Windows.Forms.TextBox sYasi;
        private System.Windows.Forms.TextBox sAlbumS;
        private System.Windows.Forms.TextBox sKisiS;
        private System.Windows.Forms.RadioButton sRdbErkek;
        private System.Windows.Forms.RadioButton sRdbKadin;
        private System.Windows.Forms.ComboBox sSarkiT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox skOdaSay;
        private System.Windows.Forms.TextBox sDjSay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fotoğrafStüdyosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesStüdyosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmStüdyosuToolStripMenuItem;
        private System.Windows.Forms.Button sList;
        private System.Windows.Forms.DataGridView gridMusterilerSes;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}