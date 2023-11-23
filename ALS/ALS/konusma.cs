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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = Bunifu.Framework.UI.BunifuFlatButton;

using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace ALS
{
    public partial class konusma : Form
    {
        ana ana_frm2 = new ana();
        public string Kullanici_id = string.Empty;
        public string uygulama_yol = Path.GetDirectoryName(Application.ExecutablePath);

        IFirebaseConfig fc = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };
        IFirebaseClient client;


        public konusma()
        {
            
            InitializeComponent();
            

        }

   
        
        private void seslendir_Click(object sender, EventArgs e)
        {
            if (mesaj.Text != string.Empty)
            {
                var python_yol = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
                var psi = new ProcessStartInfo();
                psi.FileName = python_yol + @"\Programs\Python\Python38\python.exe";

              
                var script = @"script\seslendirme.py";
                var ileti = mesaj.Text;
                psi.Arguments = $"\"{script}\" \"{ileti}\"";

        
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;

       
                var errors = "";
                var results = "";

                using (var process = Process.Start(psi))
                {
                    errors = process.StandardError.ReadToEnd();
                    results = process.StandardOutput.ReadToEnd();
                }
                mesaj.Clear();
            }   
        }

        
        private void bunifuFlatButton58_Click(object sender, EventArgs e)
        {
            mesaj.Text = "Kendimi iyi hissetmiyorum";
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

       

        
       

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();
            this.Close();


        }



        private void temizle_Click(object sender, EventArgs e)
        {
            mesaj.Text = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
           if (mesaj.TextLength!=0)
                { mesaj.Text = mesaj.Text.Remove(mesaj.Text.Length - 1, 1); }
             
            
            //Eğer text box boşsa hata veriyor.
        }

        private void space_Click(object sender, EventArgs e)
        {
            mesaj.Text = mesaj.Text + " ";
        }

       

        private void bunifuFlatButton57_Click(object sender, EventArgs e)
        {
            mesaj.Text = "iyiyim";
        }

        private void bunifuFlatButton60_Click(object sender, EventArgs e)
        {
            mesaj.Text = "bu güzel";
        }

        private void bunifuFlatButton59_Click(object sender, EventArgs e)
        {
            mesaj.Text = "güzel değil";
        }

        

        private void harf_Click(object sender, EventArgs e)
        {
            mesaj.Text += ((Button)sender).Text.ToLower();
        }

        private void zil_Click(object sender, EventArgs e)
        {
            ana_frm2.wav_Click("zil.wav",false);
        }

        private void bunifuFlatButton85_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

        }
        private void tabcumle_Click(object sender, EventArgs e)
        {
            mesaj.Text = ((Button)sender).Text;
            seslendir_Click(sender, e);
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

        private void konusma_Load(object sender, EventArgs e)
        {
            string[] data_ = File.ReadAllLines(uygulama_yol + @"\dil\dil.txt");

            g2.Text = data_[12];
            s2.Text = data_[13];
            zil.Text = data_[14];
            bunifuFlatButton3.Text = data_[15]; 
            bunifuFlatButton4.Text= data_[16];  
            backspace.LabelText = data_[17];
            seslendir.LabelText = data_[18];
            temizle.Text = data_[19];   
            space.Text = data_[20];    
            acil.Text = data_[21];
            bunifuFlatButton27.Text = data_[22];
            bunifuFlatButton56.Text = data_[23];
            bunifuFlatButton57.Text = data_[24];
            bunifuFlatButton58.Text= data_[25]; 
            bunifuFlatButton60.Text= data_[26]; 
            bunifuFlatButton59.Text= data_[27]; 
            bunifuFlatButton62.Text= data_[28];
            bunifuFlatButton61.Text = data_[29];
            bunifuFlatButton66.Text = data_[30];
            bunifuFlatButton65.Text = data_[31];
            bunifuFlatButton64.Text= data_[32];
            bunifuFlatButton68.Text = data_[33];
            bunifuFlatButton63.Text = data_[34];
            bunifuFlatButton67.Text = data_[35];



            try
            {
                client = new FirebaseClient(fc);
            }
            catch (Exception)
            {

                MessageBox.Show("Database connection problem!", "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }
    }
}
