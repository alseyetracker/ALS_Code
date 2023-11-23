namespace ALS
{
    partial class help_mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help_mail));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ek = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mesaj = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.konu = new System.Windows.Forms.TextBox();
            this.dosya = new System.Windows.Forms.Label();
            this.mesaj_gönderildi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // ek
            // 
            this.ek.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ek.BorderRadius = 7;
            this.ek.ButtonText = "Add";
            this.ek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ek.DisabledColor = System.Drawing.Color.Gray;
            this.ek.Iconcolor = System.Drawing.Color.Transparent;
            this.ek.Iconimage = null;
            this.ek.Iconimage_right = null;
            this.ek.Iconimage_right_Selected = null;
            this.ek.Iconimage_Selected = null;
            this.ek.IconMarginLeft = 0;
            this.ek.IconMarginRight = 0;
            this.ek.IconRightVisible = true;
            this.ek.IconRightZoom = 0D;
            this.ek.IconVisible = true;
            this.ek.IconZoom = 90D;
            this.ek.IsTab = false;
            this.ek.Location = new System.Drawing.Point(620, 16);
            this.ek.Name = "ek";
            this.ek.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ek.OnHovercolor = System.Drawing.Color.Maroon;
            this.ek.OnHoverTextColor = System.Drawing.Color.White;
            this.ek.selected = false;
            this.ek.Size = new System.Drawing.Size(166, 49);
            this.ek.TabIndex = 72;
            this.ek.Text = "Add";
            this.ek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ek.Textcolor = System.Drawing.Color.White;
            this.ek.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ek.Click += new System.EventHandler(this.ek_Click_1);
            // 
            // mesaj
            // 
            this.mesaj.BackColor = System.Drawing.Color.Black;
            this.mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaj.ForeColor = System.Drawing.Color.White;
            this.mesaj.Location = new System.Drawing.Point(12, 85);
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(776, 323);
            this.mesaj.TabIndex = 71;
            this.mesaj.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 37);
            this.label1.TabIndex = 70;
            this.label1.Text = "Subject";
            // 
            // konu
            // 
            this.konu.BackColor = System.Drawing.SystemColors.MenuText;
            this.konu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konu.ForeColor = System.Drawing.Color.White;
            this.konu.Location = new System.Drawing.Point(177, 16);
            this.konu.Name = "konu";
            this.konu.Size = new System.Drawing.Size(437, 49);
            this.konu.TabIndex = 69;
            // 
            // dosya
            // 
            this.dosya.AutoSize = true;
            this.dosya.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosya.ForeColor = System.Drawing.Color.Black;
            this.dosya.Location = new System.Drawing.Point(12, 448);
            this.dosya.Name = "dosya";
            this.dosya.Size = new System.Drawing.Size(86, 31);
            this.dosya.TabIndex = 74;
            this.dosya.Text = "label2";
            // 
            // mesaj_gönderildi
            // 
            this.mesaj_gönderildi.AutoSize = true;
            this.mesaj_gönderildi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaj_gönderildi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mesaj_gönderildi.Location = new System.Drawing.Point(614, 448);
            this.mesaj_gönderildi.Name = "mesaj_gönderildi";
            this.mesaj_gönderildi.Size = new System.Drawing.Size(169, 31);
            this.mesaj_gönderildi.TabIndex = 75;
            this.mesaj_gönderildi.Text = "Mesaj sent...";
            // 
            // help_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.mesaj_gönderildi);
            this.Controls.Add(this.dosya);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ek);
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.konu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "help_mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yardım Mesajı Gönder";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.help_mail_FormClosed);
            this.Load += new System.EventHandler(this.help_mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton ek;
        private System.Windows.Forms.RichTextBox mesaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox konu;
        private System.Windows.Forms.Label dosya;
        private System.Windows.Forms.Label mesaj_gönderildi;
    }
}