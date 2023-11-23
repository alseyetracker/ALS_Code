namespace ALS
{
    partial class ana
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ana));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.zaman = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.batarya_label = new System.Windows.Forms.Label();
            this.batarya_resim = new System.Windows.Forms.PictureBox();
            this.ag_yok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTileButton7 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batarya_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleDescription = "Yardım ve teknik destek mesajı";
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = global::ALS.Properties.Resources.help;
            pictureBox1.Location = new System.Drawing.Point(2229, 750);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(80, 74);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer2
            // 
            this.timer2.Interval = 20000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.zaman);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 1102);
            this.panel1.TabIndex = 0;
            // 
            // zaman
            // 
            this.zaman.Activecolor = System.Drawing.Color.SlateGray;
            this.zaman.BackColor = System.Drawing.Color.Orange;
            this.zaman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zaman.BorderRadius = 0;
            this.zaman.ButtonText = "";
            this.zaman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zaman.DisabledColor = System.Drawing.Color.Gray;
            this.zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zaman.Iconcolor = System.Drawing.Color.Transparent;
            this.zaman.Iconimage = global::ALS.Properties.Resources.icons8_clock_64;
            this.zaman.Iconimage_right = null;
            this.zaman.Iconimage_right_Selected = null;
            this.zaman.Iconimage_Selected = null;
            this.zaman.IconMarginLeft = 0;
            this.zaman.IconMarginRight = 0;
            this.zaman.IconRightVisible = true;
            this.zaman.IconRightZoom = 0D;
            this.zaman.IconVisible = true;
            this.zaman.IconZoom = 120D;
            this.zaman.IsTab = false;
            this.zaman.Location = new System.Drawing.Point(949, 0);
            this.zaman.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.zaman.Name = "zaman";
            this.zaman.Normalcolor = System.Drawing.Color.Orange;
            this.zaman.OnHovercolor = System.Drawing.Color.SlateGray;
            this.zaman.OnHoverTextColor = System.Drawing.Color.White;
            this.zaman.selected = false;
            this.zaman.Size = new System.Drawing.Size(623, 123);
            this.zaman.TabIndex = 100;
            this.zaman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.zaman.Textcolor = System.Drawing.Color.White;
            this.zaman.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zaman.Click += new System.EventHandler(this.zaman_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(pictureBox1);
            this.panel2.Controls.Add(this.batarya_label);
            this.panel2.Controls.Add(this.batarya_resim);
            this.panel2.Controls.Add(this.ag_yok);
            this.panel2.Controls.Add(this.bunifuTileButton7);
            this.panel2.Controls.Add(this.bunifuTileButton4);
            this.panel2.Controls.Add(this.bunifuTileButton6);
            this.panel2.Controls.Add(this.bunifuTileButton2);
            this.panel2.Controls.Add(this.bunifuTileButton1);
            this.panel2.Location = new System.Drawing.Point(125, 455);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2225, 691);
            this.panel2.TabIndex = 0;
            // 
            // batarya_label
            // 
            this.batarya_label.AutoSize = true;
            this.batarya_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.batarya_label.ForeColor = System.Drawing.Color.Red;
            this.batarya_label.Location = new System.Drawing.Point(2068, 693);
            this.batarya_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.batarya_label.Name = "batarya_label";
            this.batarya_label.Size = new System.Drawing.Size(132, 46);
            this.batarya_label.TabIndex = 72;
            this.batarya_label.Text = "label1";
            this.batarya_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batarya_resim
            // 
            this.batarya_resim.Image = global::ALS.Properties.Resources.batarya;
            this.batarya_resim.InitialImage = null;
            this.batarya_resim.Location = new System.Drawing.Point(2064, 730);
            this.batarya_resim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.batarya_resim.Name = "batarya_resim";
            this.batarya_resim.Size = new System.Drawing.Size(127, 106);
            this.batarya_resim.TabIndex = 71;
            this.batarya_resim.TabStop = false;
            // 
            // ag_yok
            // 
            this.ag_yok.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ag_yok.BackColor = System.Drawing.Color.SlateGray;
            this.ag_yok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ag_yok.BorderRadius = 7;
            this.ag_yok.ButtonText = "İNTERNET BAĞLANTISI KESİLDİ...";
            this.ag_yok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ag_yok.DisabledColor = System.Drawing.Color.Gray;
            this.ag_yok.Iconcolor = System.Drawing.Color.Transparent;
            this.ag_yok.Iconimage = global::ALS.Properties.Resources.no_connection;
            this.ag_yok.Iconimage_right = null;
            this.ag_yok.Iconimage_right_Selected = null;
            this.ag_yok.Iconimage_Selected = null;
            this.ag_yok.IconMarginLeft = 0;
            this.ag_yok.IconMarginRight = 0;
            this.ag_yok.IconRightVisible = true;
            this.ag_yok.IconRightZoom = 0D;
            this.ag_yok.IconVisible = true;
            this.ag_yok.IconZoom = 150D;
            this.ag_yok.IsTab = false;
            this.ag_yok.Location = new System.Drawing.Point(592, 730);
            this.ag_yok.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ag_yok.Name = "ag_yok";
            this.ag_yok.Normalcolor = System.Drawing.Color.SlateGray;
            this.ag_yok.OnHovercolor = System.Drawing.Color.Maroon;
            this.ag_yok.OnHoverTextColor = System.Drawing.Color.White;
            this.ag_yok.selected = false;
            this.ag_yok.Size = new System.Drawing.Size(1133, 129);
            this.ag_yok.TabIndex = 70;
            this.ag_yok.Text = "İNTERNET BAĞLANTISI KESİLDİ...";
            this.ag_yok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ag_yok.Textcolor = System.Drawing.Color.White;
            this.ag_yok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // bunifuTileButton7
            // 
            this.bunifuTileButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton7.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton7.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton7.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton7.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton7.Image")));
            this.bunifuTileButton7.ImagePosition = 20;
            this.bunifuTileButton7.ImageZoom = 50;
            this.bunifuTileButton7.LabelPosition = 41;
            this.bunifuTileButton7.LabelText = "";
            this.bunifuTileButton7.Location = new System.Drawing.Point(2307, 730);
            this.bunifuTileButton7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuTileButton7.Name = "bunifuTileButton7";
            this.bunifuTileButton7.Size = new System.Drawing.Size(128, 143);
            this.bunifuTileButton7.TabIndex = 300;
            this.bunifuTileButton7.Click += new System.EventHandler(this.bunifuTileButton7_Click);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.Chocolate;
            this.bunifuTileButton4.color = System.Drawing.Color.Chocolate;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.SlateGray;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 37;
            this.bunifuTileButton4.ImageZoom = 70;
            this.bunifuTileButton4.LabelPosition = 75;
            this.bunifuTileButton4.LabelText = "Ayarlar";
            this.bunifuTileButton4.Location = new System.Drawing.Point(1779, 23);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(493, 554);
            this.bunifuTileButton4.TabIndex = 200;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // bunifuTileButton6
            // 
            this.bunifuTileButton6.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton6.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton6.colorActive = System.Drawing.Color.SlateGray;
            this.bunifuTileButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton6.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuTileButton6.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton6.Image")));
            this.bunifuTileButton6.ImagePosition = 37;
            this.bunifuTileButton6.ImageZoom = 70;
            this.bunifuTileButton6.LabelPosition = 75;
            this.bunifuTileButton6.LabelText = "Whatsapp";
            this.bunifuTileButton6.Location = new System.Drawing.Point(609, 23);
            this.bunifuTileButton6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuTileButton6.Name = "bunifuTileButton6";
            this.bunifuTileButton6.Size = new System.Drawing.Size(493, 554);
            this.bunifuTileButton6.TabIndex = 202;
            this.bunifuTileButton6.Click += new System.EventHandler(this.bunifuTileButton6_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.DarkRed;
            this.bunifuTileButton2.color = System.Drawing.Color.DarkRed;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.SlateGray;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::ALS.Properties.Resources.tv_128;
            this.bunifuTileButton2.ImagePosition = 37;
            this.bunifuTileButton2.ImageZoom = 70;
            this.bunifuTileButton2.LabelPosition = 75;
            this.bunifuTileButton2.LabelText = "TV / Radio";
            this.bunifuTileButton2.Location = new System.Drawing.Point(1193, 23);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(493, 554);
            this.bunifuTileButton2.TabIndex = 201;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.SlateGray;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 37;
            this.bunifuTileButton1.ImageZoom = 70;
            this.bunifuTileButton1.LabelPosition = 75;
            this.bunifuTileButton1.LabelText = "Konuşma";
            this.bunifuTileButton1.Location = new System.Drawing.Point(21, 23);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(493, 554);
            this.bunifuTileButton1.TabIndex = 203;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ana_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batarya_resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton6;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton7;
        private Bunifu.Framework.UI.BunifuFlatButton zaman;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuFlatButton ag_yok;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox batarya_resim;
        private System.Windows.Forms.Label batarya_label;
    }
}

