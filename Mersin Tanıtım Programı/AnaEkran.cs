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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            timer1.Start();

            label1.Text = DateTime.Now.ToLongDateString();

            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongDateString();
            
            label2.Text = DateTime.Now.ToLongTimeString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = System.Drawing.Color.Transparent;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.BackColor = System.Drawing.Color.Transparent;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.BackColor = System.Drawing.Color.Transparent;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.BackColor = System.Drawing.Color.Transparent;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.BackColor = System.Drawing.Color.Transparent;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yemekler yemek = new Yemekler();

            yemek.Show();

            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            YöreselŞarkılar gecis = new YöreselŞarkılar();

            gecis.Show();

            this.Hide();

            gecis.label1.Text = "Silifke'nin Yoğurdu";

            gecis.label2.Text = "Ham Çökelek";

            gecis.label3.Text = "Anamur Yolları Kayrak Da Çakıllı";

            gecis.label4.Text = "Çattılar Ocak Taşını";

            gecis.label5.Text = "Yayla Yollarında Göç Kater Kater";

            gecis.label6.Text = "Pınar Başı Ben Olayım";

            gecis.label7.Text = "Açıl Ey Ömrümün Varı";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ŞehirHaritası gecis = new ŞehirHaritası();

            gecis.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahları gecis = new OtobüsGüzergahları();

            gecis.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Turistlik_Yerler gecis = new Turistlik_Yerler();

            gecis.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Radyo gecis = new Radyo();

            gecis.Show();

            this.Hide();
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
