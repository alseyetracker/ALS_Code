using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALS
{
    public partial class help_mail : Form
    {
        public help_mail()
        {
            InitializeComponent();
        }
        ana ana_frm = new ana();
        public string Kullanici_id = string.Empty;
        public string uygulama_yol = Path.GetDirectoryName(Application.ExecutablePath);
        string dosya_yol;


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Send_mail sm = new Send_mail();
                sm.Microsoft(Kullanici_id, "", "",
                    "", konu.Text, mesaj.Text, dosya_yol);
                mesaj_gönderildi.Visible = true;
                konu.Text = "";
                mesaj.Text = "";
                dosya.Visible = false;  
            }
            catch (Exception)
            {

                MessageBox.Show("Message could not be sent!!!!", "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }

        private void ek_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Title = "Gönderi İçin Ek Dosya Seçebilirsiniz.";
            ofd.ShowDialog();
            dosya_yol = ofd.FileName;
            dosya.Text = "Ek: "+ ofd.SafeFileName; 
            dosya.Visible=true;
        }

        private void help_mail_Load(object sender, EventArgs e)
        {
            string[] data_ = File.ReadAllLines(uygulama_yol + @"\dil\dil.txt");
            label1.Text = data_[49];
            ek.Text = data_[50];
            mesaj_gönderildi.Text = data_[51];  


            this.TopMost = true;
            ana_frm.python_kapat();
            dosya.Visible = false;
            mesaj_gönderildi.Visible = false;

        }

        private void help_mail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.Start(ana_frm.uygulama_yol + @"\script\fare_kontrol.py");
        }
    }
}
