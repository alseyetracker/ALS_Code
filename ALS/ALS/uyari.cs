using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALS
{
    public partial class uyari : Form
    {
        public string uygulama_yol = Path.GetDirectoryName(Application.ExecutablePath);

        public uyari()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton85_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uyari_Load(object sender, EventArgs e)
        {
            string[] data_ = File.ReadAllLines(uygulama_yol + @"\dil\dil.txt");
            label1.Text = data_[46];
            bunifuFlatButton85.Text = data_[47];
        }
    }
}
