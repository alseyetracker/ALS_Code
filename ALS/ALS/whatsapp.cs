using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Button = Bunifu.Framework.UI.BunifuFlatButton;
using System.Runtime.InteropServices;
using System.Threading;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using System.Media;

namespace ALS
{
    public partial class whatsapp : Form
    {
       
        IFirebaseConfig fc = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };
        IFirebaseClient client;

        ana ana_frm2 = new ana();
        public string Kullanici_id = string.Empty;
        public string uygulama_yol = Path.GetDirectoryName(Application.ExecutablePath);

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public whatsapp()
        {
            InitializeComponent();
        }


        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();

            }
        }

        private void whatsapp_Arama(string kisi) {

            Cursor.Position = new System.Drawing.Point(100, 85);
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
            SendKeys.Send("^(a)");
            SendKeys.Send(kisi);
            SendKeys.Send("{ENTER}");
        }

        private void whatsapp_Gonder() {

            int x = webControl1.Size.Width;
            int y = webControl1.Size.Height;

            Cursor.Position = new System.Drawing.Point(x / 2 + 30, y - 15);
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
            SendKeys.Send(wp_text.Text);
            SendKeys.Send("{ENTER}");
            wp_text.Text = "";
        }

        private void whatsapp_Load(object sender, EventArgs e)
        {
            string[] data2_ = File.ReadAllLines(uygulama_yol + @"\dil\dil.txt");
            bunifuTileButton2.LabelText = data2_[17];
            send.LabelText= data2_[37];
            bunifuFlatButton38.Text = data2_[19];
            bunifuFlatButton59.Text= data2_[20];    
            zil.Text= data2_[14];   
            acil.Text= data2_[21];

            bunifuFlatButton16.Text = data2_[12];
            bunifuFlatButton25.Text = data2_[13];

            bunifuFlatButton22.Text = data2_[22];
            bunifuFlatButton56.Text = data2_[23];
            bunifuFlatButton57.Text = data2_[24];
            bunifuFlatButton58.Text = data2_[25];
            bunifuFlatButton60.Text = data2_[26];
            bunifuFlatButton15.Text = data2_[27];
            bunifuFlatButton62.Text = data2_[28];
            bunifuFlatButton61.Text = data2_[29];
            bunifuFlatButton66.Text = data2_[30];
            bunifuFlatButton65.Text = data2_[31];
            bunifuFlatButton64.Text = data2_[32];
            bunifuFlatButton68.Text = data2_[33];
            bunifuFlatButton63.Text = data2_[34];
            bunifuFlatButton67.Text = data2_[35];


            try
            {
                client = new FirebaseClient(fc);

                this.TopLevel = true;
                this.TopMost = true;

                string[] data_ = File.ReadAllLines(ana_frm2.uygulama_yol + @"\data\ayarlar.txt");
                kisi1.Text = data_[9];
                kisi2.Text = data_[10];
                kisi3.Text = data_[11];
                kisi4.Text = data_[12];
                kisi5.Text = data_[13];
                kisi6.Text = data_[14];
                wait(10000);
                whatsapp_Arama(kisi1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Database connection problem!", "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }   

        }

        private void bunifuFlatButton25_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void harf_Click(object sender, EventArgs e)
        {
            wp_text.Text  += ((Button)sender).Text.ToLower();
        }

       

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       

        private void bunifuFlatButton59_Click(object sender, EventArgs e)
        {
            wp_text.Text = wp_text.Text + " ";
        }

        private void bunifuFlatButton38_Click(object sender, EventArgs e)
        {
            wp_text.Text = "";
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            if (wp_text.TextLength != 0)
            { wp_text.Text = wp_text.Text.Remove(wp_text.Text.Length - 1, 1); }


        }

        private void zil_Click(object sender, EventArgs e)
        {
            ana_frm2.wav_Click("zil.wav", false);
        }

        private void acil_Click(object sender, EventArgs e)
        {
            ana_frm2.wav_Click("alarm.wav", true);
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

        
        private void send_Click(object sender, EventArgs e)
        {
            whatsapp_Gonder();
        }

        private void kisi_Click(object sender, EventArgs e)
        {
            whatsapp_Arama(((Button)sender).Text);

  
        }

        private void bunifuFlatButton30_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void bunifuFlatButton51_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void bunifuFlatButton50_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void bunifuFlatButton49_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void bunifuFlatButton52_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            wp_text.Text = "";
            wp_text.Text = ((Button)sender).Text.ToLower();
            whatsapp_Gonder();
        }

    
    }
}
