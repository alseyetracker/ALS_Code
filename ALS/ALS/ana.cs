using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Globalization;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace ALS
{
    public partial class ana : Form
    {
        internal class BatteryState
        {
            public float Percent { get; set; }
            
        }

        IFirebaseConfig fc = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };
        IFirebaseClient client;


        public Process fare_kontrol;
        public string uygulama_yol = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public string Kullanici_id = string.Empty;
        public string batarya_durum=string.Empty;

        public ana()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
    
        }


        public bool Ag_kontrol()
        {
            bool kontrol = NetworkInterface.GetIsNetworkAvailable();
            return kontrol;
        }


        private void Batarya_kontrol()
        {
            BatteryState batarya = new BatteryState();
            batarya.Percent = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            batarya_label.Text = "%" + batarya.Percent.ToString();
            batarya_durum = batarya.Percent.ToString();
            
            if (batarya.Percent <= 20)
            {
                batarya_label.Visible = true;
                batarya_resim.Visible = true;
            }
            ;
        }



        int sayac = 1;
        private async void Mesaj_oku()
        {
            FirebaseResponse response = await client.GetAsync("Kullanicilar/"+ Kullanici_id);
            Users result = response.ResultAs<Users>();
            string mesaj_oku = result.Tel_mesaj;
  
            if (mesaj_oku != string.Empty & sayac==1)
            {
                sayac++;
                telefon_mesaj tlf_frm = new telefon_mesaj();
                tlf_frm.mesaj_oku = mesaj_oku;
                tlf_frm.Kullanici_id = Kullanici_id;
                this.Hide();
  
                var durum = tlf_frm.ShowDialog();
                if (durum == DialogResult.Cancel)
                {
                    sayac = 1;
                    var setet = client.Set("Kullanicilar/" + Kullanici_id + "/Tel_mesaj/", "");         
                    this.Show();
                }
            } 
        }



        public void wav_Click(string dosya_adi, bool tekrar)
        {
            SoundPlayer player = new SoundPlayer();
            string ses_yol = uygulama_yol + @"\sesler\" + dosya_adi;
            player.SoundLocation = ses_yol;
            if (tekrar)
            {
                player.PlayLooping();
            }
            else
            {
                player.Play();
            }
        }



        public void python_kapat()
        {
            string processName = "python"; // Kapatmak İstediğimiz Program
            Process[] processes = Process.GetProcesses();// Tüm Çalışan Programlar

            foreach (Process process in processes)
            {
                Console.WriteLine(process.ProcessName);

                if (process.ProcessName == processName)
                {
                    process.Kill();
                }

            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data_ = File.ReadAllLines(uygulama_yol + @"\dil\dil.txt");

            bunifuTileButton1.LabelText= data_[6];
            bunifuTileButton6.LabelText = data_[7];
            bunifuTileButton2.LabelText = data_[8];
            bunifuTileButton4.LabelText = data_[9];
            ag_yok.Text= data_[10];



            try
            {
                client = new FirebaseClient(fc);
                client.Set("Kullanicilar/" + Kullanici_id + "/Acil/", 0);

            }
            catch (Exception)
            {
                MessageBox.Show("Database connection problem!", "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }


            ag_yok.Visible = false;
            batarya_label.Visible = false;
            batarya_resim.Visible = false;

            timer1.Start();
            timer2.Start();
            timer3.Start();


            fare_kontrol = Process.Start(uygulama_yol + @"\script\fare_kontrol.py");
            this.TopMost = true;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman.Text = DateTime.Now.ToLongTimeString();    
        }



        private void ana_FormClosed(object sender, FormClosedEventArgs e)
        {
            python_kapat();
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            Batarya_kontrol();

            if (!Ag_kontrol())
            {
                 Form form = Application.OpenForms.Cast<Form>().Where(f => f.GetType() == typeof(konusma)).FirstOrDefault();
                 if (form != null)
                 { form.Close(); }

                 Form form2 = Application.OpenForms.Cast<Form>().Where(f => f.GetType() == typeof(whatsapp)).FirstOrDefault();
                 if (form2 != null)
                 { form2.Close(); }

                 Form form3 = Application.OpenForms.Cast<Form>().Where(f => f.GetType() == typeof(ayar)).FirstOrDefault();
                 if (form3 != null)
                 { form3.Close(); }

                Form form4 = Application.OpenForms.Cast<Form>().Where(f => f.GetType() == typeof(tv)).FirstOrDefault();
                if (form4 != null)
                { form4.Close(); }

                bunifuTileButton1.Enabled = false;  
                bunifuTileButton2.Enabled = false;  
                bunifuTileButton4.Enabled = false;
                bunifuTileButton6.Enabled = false;

                ag_yok.Visible = true;
                //wav_Click("alarm.wav", true);
            }

            else             
            {
                ag_yok.Visible = false;
                bunifuTileButton1.Enabled = true;
                bunifuTileButton2.Enabled = true;
                bunifuTileButton4.Enabled = true;
                bunifuTileButton6.Enabled = true;          
             
                SoundPlayer player = new SoundPlayer();
                player.Stop();

                if (client != null)
                {
                    
                    string zaman = DateTime.Now.ToString();
                    var setet = client.Set("Kullanicilar/" + Kullanici_id + "/Kontrol/", "\"" + zaman + "\"");
                    var setet2 = client.Set("Kullanicilar/" + Kullanici_id + "/Batarya/", "\"" + batarya_durum + "\"");
                }
                Mesaj_oku();
            }       
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }



        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            whatsapp whatsapp_frm = new whatsapp();
            whatsapp_frm.Kullanici_id = Kullanici_id;
            this.Hide();

            var durum = whatsapp_frm.ShowDialog();
            if (durum == DialogResult.Cancel)
            {
                this.Show();
            }
        }



        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            ayar ayar_frm = new ayar();
            ayar_frm.k_adi = Kullanici_id;
            this.Hide();

            var durum = ayar_frm.ShowDialog();
            if (durum == DialogResult.Cancel)
            {
                Application.Restart();
            }

        }



        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            konusma konusma_frm = new konusma();
            konusma_frm.Kullanici_id = Kullanici_id;
            this.Hide();

            var durum = konusma_frm.ShowDialog();
            if (durum == DialogResult.Cancel)
            {
                this.Show();
            }

        }



        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            tv tv_frm = new tv();
            tv_frm.Kullanici_id = Kullanici_id;
            this.Hide();

            var durum = tv_frm.ShowDialog();
            if (durum == DialogResult.Cancel)
            {
                this.Show();
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            help_mail help_frm = new help_mail();
            help_frm.Kullanici_id=Kullanici_id; 
            this.Hide();

            var durum = help_frm.ShowDialog();
            if (durum == DialogResult.Cancel)
            {
                this.Show();
            }

        }


        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zaman_Click(object sender, EventArgs e)
        {

        }
    }
}
