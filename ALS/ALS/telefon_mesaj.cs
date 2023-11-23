using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using Bunifu.Framework.UI;
using System.IO;

namespace ALS
{
   

    public partial class telefon_mesaj : Form
    {
        IFirebaseConfig ifc = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };

        IFirebaseClient client;

        public string uygulama_yol = Path.GetDirectoryName(Application.ExecutablePath);
        public string mesaj_oku = string.Empty;
        public string Kullanici_id = string.Empty;
        public telefon_mesaj()
        {
            InitializeComponent();
        }




        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void telefon_mesaj_Load(object sender, EventArgs e)
        {
            mesaj_kutusu.Text = mesaj_oku;

            string[] data_ = File.ReadAllLines(uygulama_yol + @"\dil\dil.txt");
            evet_btn.Text = data_[15];
            bunifuFlatButton4.Text = data_[16];    

            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Database connection problem!", "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }

        }


        

        private async void evet_btn_Click(object sender, EventArgs e)
        {
            var setet = client.Set("Kullanicilar/" + Kullanici_id + "/Bil_cevap/", "Evet");
            this.Close();
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            var setet = client.Set("Kullanicilar/" + Kullanici_id + "/Bil_cevap/", "Hayır");
            this.Close();
        }
    }
}
