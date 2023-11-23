using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace ALS
{
    public partial class tv : Form
    {
        public tv()
        {
            InitializeComponent();
        }


        IFirebaseConfig fc = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };
        IFirebaseClient client;


        ana ana_frm = new ana();
        public string uygulama_yol = Path.GetDirectoryName(Application.ExecutablePath);
        public string Kullanici_id = string.Empty;
        public string tv_link =string.Empty;
        private const uint MOUSEEVENTF_WHEEL = 0x0800;
        const int MOUSEEVENTF_MOVE = 0x0001;
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);


        private void  tv_Load(object sender, EventArgs e)
        {

            string[] data3_ = File.ReadAllLines(uygulama_yol + @"\dil\dil.txt");

            bunifuFlatButton4.Text = data3_[39];
            bunifuFlatButton1.Text = data3_[40];
            bunifuFlatButton2.Text = data3_[40];
            bunifuFlatButton5.Text = data3_[39];
            acil.Text = data3_[41];
           

            try
            {
                client = new FirebaseClient(fc);
                this.TopMost = true;
                string[] data_ = File.ReadAllLines(ana_frm.uygulama_yol + @"\data\ayarlar.txt");
                tv_link = data_[15];
        
                webView1.LoadUrl(tv_link);
            }
            catch (Exception)
            {

                MessageBox.Show("Database connection problem!", "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }

        }

        private void kaydır(int deger)
        {
            bunifuFlatButton1.Visible = false;
            bunifuFlatButton2.Visible = false;
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, deger , 0);
            timer1.Start();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            keybd_event((byte)Keys.VolumeDown, 0, 0, 0);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            keybd_event((byte)Keys.VolumeUp, 0, 0, 0);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            kaydır(-150);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            kaydır(150);
        }

        private void acil_Click(object sender, EventArgs e)
        {
            ana_frm.wav_Click("alarm.wav", true);
            this.TopMost = false;

            client.Set("Kullanicilar/" + Kullanici_id + "/Acil/", 1);

            uyari uyari_frm = new uyari();
            var durum = uyari_frm.ShowDialog();
            if (durum == DialogResult.Cancel)
            {
                this.TopMost = true;
                SoundPlayer player = new SoundPlayer();
                player.Stop();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            // webView21.Dispose();    
            this.Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            webView1.LoadUrl(tv_link);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuFlatButton1.Visible = true;
            bunifuFlatButton2.Visible = true;
            timer1.Stop();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            webView1.LoadUrl(tv_link);

        }

        private void webControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
