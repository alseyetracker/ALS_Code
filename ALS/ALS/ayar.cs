using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using Newtonsoft.Json;

namespace ALS
{
    public partial class ayar : Form

    {

        IFirebaseConfig ifc = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };

        IFirebaseClient client;

        ana ana_frm=new ana();
        public Process kamera_ayar;
        public string uygulama_yol;
        string cinsiyet_secim, dil_secim;
        public string k_adi = string.Empty;
        
        public ayar()
        {
            InitializeComponent();
        }



        private void ayar_Load(object sender, EventArgs e)
        {
            this.TopMost = true;    
            ana_frm.python_kapat();

            yıldız1.Visible = false;    
            yıldız2.Visible = false;
            yıldız3.Visible = false;
        

            
            string[] data_ = File.ReadAllLines(ana_frm.uygulama_yol + @"\data\ayarlar.txt");
            cinsiyet.Text = data_[0];   
            dil.Text = data_[1];
            kamera.Text = data_[2];
            tel_1.Text = data_[3];
            tel_2.Text = data_[4];
            tel_3.Text = data_[5];
            tel_4.Text = data_[6];
            tel_5.Text = data_[7];
            tel_6.Text = data_[8];
            name_1.Text= data_[9]; 
            name_2.Text= data_[10]; 
            name_3.Text= data_[11]; 
            name_4.Text= data_[12];
            name_5.Text= data_[13];
            name_6.Text= data_[14];
            tv_link.Text = data_[15];    

        }

       

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            if (cinsiyet.Text != string.Empty && dil.Text!=string.Empty && kamera.Text!=string.Empty )

            {
                status_label.Text = "Saving...";

                StreamWriter Yaz = new StreamWriter(ana_frm.uygulama_yol + @"\data\ayarlar.txt");
                Yaz.WriteLine(cinsiyet.SelectedItem);
                Yaz.WriteLine(dil.SelectedItem);
                Yaz.WriteLine(kamera.SelectedItem);
                Yaz.WriteLine(tel_1.Text);
                Yaz.WriteLine(tel_2.Text);
                Yaz.WriteLine(tel_3.Text);
                Yaz.WriteLine(tel_4.Text);
                Yaz.WriteLine(tel_5.Text);
                Yaz.WriteLine(tel_6.Text);
                Yaz.WriteLine(name_1.Text);
                Yaz.WriteLine(name_2.Text);
                Yaz.WriteLine(name_3.Text);
                Yaz.WriteLine(name_4.Text);
                Yaz.WriteLine(name_5.Text);
                Yaz.WriteLine(name_6.Text);
                Yaz.WriteLine(tv_link.Text);
                Yaz.Close();

                progressbar.Value += 10;
                Thread.Sleep(500);

                switch (cinsiyet.SelectedIndex)
                {
                    case 0: cinsiyet_secim = "Male"; break;
                    case 1: cinsiyet_secim = "Female"; break;
                }
    

                switch (dil.SelectedIndex)
                {
                    case 0: dil_secim = "Turkish"; File.Copy(@"data\dil_turkce.txt", @"dil\dil.txt",true); break;
                    case 1: dil_secim = "UKEnglish"; File.Copy(@"data\dil_ingilizce.txt", @"dil\dil.txt",true); break;
                    case 2: dil_secim = "Deutsch"; File.Copy(@"data\dil_almanca.txt", @"dil\dil.txt", true); break;
                    case 3: dil_secim = "French"; File.Copy(@"data\dil_fransizca.txt", @"dil\dil.txt", true); break;
                    case 4: dil_secim = "Italian"; File.Copy(@"data\dil_italyanca.txt", @"dil\dil.txt", true); break;
                }



                progressbar.Value += 20;
                Thread.Sleep(500);


                File.Copy(ana_frm.uygulama_yol + @"\data\seslendirme.py", ana_frm.uygulama_yol + @"\script\seslendirme.py", true);
                string text = File.ReadAllText(ana_frm.uygulama_yol + @"\script\seslendirme.py");
                text = text.Replace("dil_id",dil_secim+cinsiyet_secim);
                File.WriteAllText(ana_frm.uygulama_yol + @"\script\seslendirme.py", text);
                
                progressbar.Value += 20;

                File.Copy(ana_frm.uygulama_yol + @"\data\kamera_ayar.py", ana_frm.uygulama_yol + @"\script\kamera_ayar.py", true);
                string text2 = File.ReadAllText(ana_frm.uygulama_yol + @"\script\kamera_ayar.py");
                text2 = text2.Replace("kamera_id", kamera.SelectedIndex.ToString());
                File.WriteAllText(ana_frm.uygulama_yol + @"\script\kamera_ayar.py", text2);


                File.Copy(ana_frm.uygulama_yol + @"\data\fare_kontrol.py", ana_frm.uygulama_yol + @"\script\fare_kontrol.py", true);
                string text3 = File.ReadAllText(ana_frm.uygulama_yol + @"\script\fare_kontrol.py");
                text3 = text3.Replace("kamera_id",kamera.SelectedIndex.ToString());
                File.WriteAllText(ana_frm.uygulama_yol + @"\script\fare_kontrol.py", text3);

                progressbar.Value += 20;
                Thread.Sleep(500);

                this.Close();
            }

            else
            {
                MessageBox.Show("Gender, language and camera fields cannot be left blank", "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                status_label.Text = "Fill in the marked fields";
                yıldız1.Visible = true;
                yıldız2.Visible = true; 
                yıldız3.Visible = true;

            }      
        }

        

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayac = 0;

            string processName = "python"; // Kapatmak İstediğimiz Program
            Process[] processes = Process.GetProcesses();// Tüm Çalışan Programlar

           
            foreach (Process process in processes)
            {
                if (process.ProcessName == processName)
                {
                    sayac++;     
                }   
            }


            if (sayac > 0)
            {
                Console.WriteLine("var");
                this.TopMost = false;
            }
            else
            {
                Console.WriteLine("yok"); 
                this.TopMost = true;      
            }
        }

       

        private void label13_Click(object sender, EventArgs e)
        {
            try
            {
               
                client = new FirebaseClient(ifc);
                
            

                client.Delete("Kullanicilar/" + k_adi);


                Application.Exit();

            }

            catch
            {
                MessageBox.Show("Database connection problem!", "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }

            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
            timer1.Start();
            ana_frm.wav_Click("kamera_ayar.wav", false);
            this.TopMost = false;


            uygulama_yol = Path.GetDirectoryName(Application.ExecutablePath);
            var python_yol =Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            kamera_ayar = Process.Start(uygulama_yol + @"\script\kamera_ayar.py");
            var psi = new ProcessStartInfo();

            psi.FileName = python_yol+@"\Programs\Python\Python38\python.exe";

            // 2) Provide script and arguments
            var script = uygulama_yol + @"\script\kamera_ayar.py";
            psi.Arguments = script;

            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            // 4) Execute process and get output
            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }
        }

        
    }
}
