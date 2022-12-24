using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mersin_Tanıtım_Programı
{
    public partial class YöreselŞarkılar : Form
    {
        public YöreselŞarkılar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=VM1N5H5RO8I");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AnaEkran geri = new AnaEkran();

            girişYapvekayıtOl giris = new girişYapvekayıtOl();

            geri.Show();

            this.Close();

            geri.label8.Text = giris.textBox1.Text.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=3muaPrKOFN8&ab_channel=netdm%C3%BCzik");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=6C0o-x4F9dk&ab_channel=MuzikPlay");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Jv0VfxS6Qkc&ab_channel=VolkanKaplanProduction");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=oqzn8DDTgHw&ab_channel=VariousArtists-Topic");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=GlKG_1OCWiU");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=TXGsLduKxiY");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
