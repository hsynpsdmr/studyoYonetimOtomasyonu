namespace Stüdyo_Yönetimi
{
    partial class studyolar
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
            this.filmStd = new System.Windows.Forms.Button();
            this.sesStd = new System.Windows.Forms.Button();
            this.fotoStd = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fotoğrafStüdyosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesStüdyosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmStüdyosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filmStd
            // 
            this.filmStd.Location = new System.Drawing.Point(55, 158);
            this.filmStd.Name = "filmStd";
            this.filmStd.Size = new System.Drawing.Size(102, 23);
            this.filmStd.TabIndex = 2;
            this.filmStd.Text = "Film Stüdyosu";
            this.filmStd.UseVisualStyleBackColor = true;
            this.filmStd.Click += new System.EventHandler(this.filmStd_Click);
            // 
            // sesStd
            // 
            this.sesStd.Location = new System.Drawing.Point(55, 99);
            this.sesStd.Name = "sesStd";
            this.sesStd.Size = new System.Drawing.Size(102, 23);
            this.sesStd.TabIndex = 1;
            this.sesStd.Text = "Ses Stüdyosu";
            this.sesStd.UseVisualStyleBackColor = true;
            this.sesStd.Click += new System.EventHandler(this.sesStd_Click);
            // 
            // fotoStd
            // 
            this.fotoStd.Location = new System.Drawing.Point(55, 41);
            this.fotoStd.Name = "fotoStd";
            this.fotoStd.Size = new System.Drawing.Size(102, 23);
            this.fotoStd.TabIndex = 0;
            this.fotoStd.Text = "Fotoğraf Stüdyosu";
            this.fotoStd.UseVisualStyleBackColor = true;
            this.fotoStd.Click += new System.EventHandler(this.fotoStd_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(198, 226);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(37, 23);
            this.cikis.TabIndex = 3;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(309, 24);
            this.menuStrip1.TabIndex = 4;
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
            // studyolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 311);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.fotoStd);
            this.Controls.Add(this.sesStd);
            this.Controls.Add(this.filmStd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "studyolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stüdyolar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filmStd;
        private System.Windows.Forms.Button sesStd;
        private System.Windows.Forms.Button fotoStd;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fotoğrafStüdyosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesStüdyosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmStüdyosuToolStripMenuItem;
    }
}