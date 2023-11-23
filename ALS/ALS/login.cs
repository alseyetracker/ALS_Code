using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Threading;
using Button = Bunifu.Framework.UI.BunifuFlatButton;
using System.Diagnostics;
using System.IO;

namespace ALS
{
    public partial class login : Form
    {
       
        IFirebaseConfig ifc = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };

        IFirebaseClient client;


        public string uygulama_yol = Path.GetDirectoryName(Application.ExecutablePath);
        public string user_id;

        public login()
        {
            InitializeComponent();
        }



        public bool Ag_kontrol()
        {
            bool kontrol = NetworkInterface.GetIsNetworkAvailable();
            return kontrol;

        }



        private void login_Load(object sender, EventArgs e)
        {

            string[] data2_ = File.ReadAllLines(uygulama_yol + @"\data\cfg.txt");

            if (Ag_kontrol())
            {
                if (data2_[0] == "0")
                {
                    Process.Start("cmd.exe", "/k" + "pip install -r requirements.txt");
                }

                string[] data_ = File.ReadAllLines(uygulama_yol + @"\dil\dil.txt");
                label5.Text = data_[0];
                label4.Text = data_[1];
                button1.Text = data_[2];
                label6.Text = data_[4];

                label1.Text = data_[0];
                label2.Text = data_[1];
                label3.Text = data_[3];
                bunifuFlatButton85.Text = data_[4];

                try
                {
                    StreamWriter Yaz = new StreamWriter(uygulama_yol + @"\data\cfg.txt");
                    Yaz.WriteLine("1");
                    Yaz.Close();

                    client = new FireSharp.FirebaseClient(ifc);
                    user_name.Select();

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

                catch
                {
                    MessageBox.Show("Database connection problem!", "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("No Internet connection!", "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                Application.Exit(); 
            }
            
                

            
        }


        FirebaseResponse response = null;
        private async void bunifuFlatButton85_Click(object sender, EventArgs e)
        {
            response = await client.GetAsync("Kullanicilar");
            var result = response.Body;

            bool varmi = result.Contains(id.Text);

            if (varmi)
            {
                MessageBox.Show("There is a user with the same name. Please try a new username.", "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);

            }
            else
            {
                Users std = new Users()
                {
                    Id = id.Text,
                    Parola = parola.Text,
                    Eposta = eposta.Text,
                    Kontrol = "",
                    Bil_cevap = "",
                    Tel_mesaj = "",
                    Batarya = "",
                };

                var setter = client.Set("Kullanicilar/" + id.Text, std);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }



        private async void bunifuFlatButton85_Click_1(object sender, EventArgs e)
        {
           

            if (!Ag_kontrol())
            {
                MessageBox.Show("No Internet connection!", "Warning",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }

            else
            {
                if (id.Text == string.Empty || parola.Text == string.Empty || eposta.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the blanks...", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information   );
                }

                else
                {
                    response = await client.GetAsync("Kullanicilar/" + id.Text);
                    var result = response.Body;

                    bool varmi = result.Contains(id.Text);

                    if (varmi)
                    {
                        MessageBox.Show("This username is used!", "Warning",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Users std = new Users()
                        {
                            Id = id.Text,
                            Kontrol = "",
                            Tel_mesaj = "",
                            Bil_cevap = "",
                            Eposta = eposta.Text,
                            Parola = parola.Text,
                        };

                        var setter = client.Set("Kullanicilar/" + id.Text, std);

                        id.Text = "";
                        parola.Text = "";
                        eposta.Text = "";

                        var durum= MessageBox.Show("New user successfully added...", "Welcome...",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        tabControl1.SelectedTab = tabPage1;
                    }
                }
            }

        }


        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (client != null)
            {
                string zaman = DateTime.Now.ToString();
                var setet = client.Set("Kullanicilar/" + user_name.Text + "/Kontrol/", "\"" + zaman + "\"");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
          
            user_id = user_name.Text;

            if (!Ag_kontrol())
            {
                MessageBox.Show("No Internet connection!", "Warning",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

            }
            else
            {
                if (user_name.Text == string.Empty || password.Text == string.Empty)
                {
                    MessageBox.Show("Username and password cannot be left blank.", "Information",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                }
                else
                {

                    response = await client.GetAsync("Kullanicilar/" + user_name.Text);
                    var result = response.Body;

                    bool varmi = result.Contains(user_name.Text);

                    if (varmi == false)
                    {
                        MessageBox.Show("Username or password is incorrect!", "Warning",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning); }
                    else
                    {
                        response = await client.GetAsync("Kullanicilar/" + user_name.Text);
                        Users result2 = response.ResultAs<Users>();

                        if (user_name.Text == result2.Id & password.Text == result2.Parola)
                        {

                            ana ana_frm = new ana();
                            ana_frm.Kullanici_id = user_name.Text;
                            this.Hide();
                            ana_frm.Show();


                        }
                        else
                        {

                            MessageBox.Show("Username or password is incorrect!", "Warning",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        }

                    }

                }

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
