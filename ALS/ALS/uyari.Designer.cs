namespace ALS
{
    partial class uyari
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton85 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.bunifuFlatButton85);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 376);
            this.panel1.TabIndex = 71;
            // 
            // bunifuFlatButton85
            // 
            this.bunifuFlatButton85.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton85.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton85.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton85.BorderRadius = 7;
            this.bunifuFlatButton85.ButtonText = "KAPAT";
            this.bunifuFlatButton85.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton85.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton85.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton85.Iconimage = null;
            this.bunifuFlatButton85.Iconimage_right = null;
            this.bunifuFlatButton85.Iconimage_right_Selected = null;
            this.bunifuFlatButton85.Iconimage_Selected = null;
            this.bunifuFlatButton85.IconMarginLeft = 10;
            this.bunifuFlatButton85.IconMarginRight = 0;
            this.bunifuFlatButton85.IconRightVisible = true;
            this.bunifuFlatButton85.IconRightZoom = 0D;
            this.bunifuFlatButton85.IconVisible = true;
            this.bunifuFlatButton85.IconZoom = 90D;
            this.bunifuFlatButton85.IsTab = false;
            this.bunifuFlatButton85.Location = new System.Drawing.Point(545, 256);
            this.bunifuFlatButton85.Name = "bunifuFlatButton85";
            this.bunifuFlatButton85.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton85.OnHovercolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton85.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton85.selected = false;
            this.bunifuFlatButton85.Size = new System.Drawing.Size(402, 99);
            this.bunifuFlatButton85.TabIndex = 74;
            this.bunifuFlatButton85.Text = "KAPAT";
            this.bunifuFlatButton85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton85.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton85.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton85.Click += new System.EventHandler(this.bunifuFlatButton85_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 92);
            this.label1.TabIndex = 73;
            this.label1.Text = "ACİL DURUM\r\nMESAJI GÖNDERİLDİ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ALS.Properties.Resources.uyari;
            this.pictureBox1.Location = new System.Drawing.Point(43, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // uyari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uyari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uyari";
            this.Load += new System.EventHandler(this.uyari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton85;
    }
}