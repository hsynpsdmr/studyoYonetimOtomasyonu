namespace Stüdyo_Yönetimi
{
    partial class sYonetimi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sYonetimi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kAdi = new System.Windows.Forms.TextBox();
            this.kSifre = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.sGoster = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // kAdi
            // 
            this.kAdi.Location = new System.Drawing.Point(104, 100);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(100, 20);
            this.kAdi.TabIndex = 2;
            this.kAdi.TextChanged += new System.EventHandler(this.kAdi_TextChanged);
            // 
            // kSifre
            // 
            this.kSifre.Location = new System.Drawing.Point(104, 140);
            this.kSifre.Name = "kSifre";
            this.kSifre.Size = new System.Drawing.Size(100, 20);
            this.kSifre.TabIndex = 3;
            this.kSifre.TextChanged += new System.EventHandler(this.kSifre_TextChanged);
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(104, 206);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(75, 23);
            this.giris.TabIndex = 4;
            this.giris.Text = "GİRİŞ";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // sGoster
            // 
            this.sGoster.AutoSize = true;
            this.sGoster.Location = new System.Drawing.Point(104, 166);
            this.sGoster.Name = "sGoster";
            this.sGoster.Size = new System.Drawing.Size(88, 17);
            this.sGoster.TabIndex = 5;
            this.sGoster.Text = "Şifreyi Göster";
            this.sGoster.UseVisualStyleBackColor = true;
            this.sGoster.CheckedChanged += new System.EventHandler(this.sGoster_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADMİN GİRİŞ PANELİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // sYonetimi
            // 
            this.AcceptButton = this.giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sGoster);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.kSifre);
            this.Controls.Add(this.kAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stüdyo Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.TextBox kSifre;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.CheckBox sGoster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

