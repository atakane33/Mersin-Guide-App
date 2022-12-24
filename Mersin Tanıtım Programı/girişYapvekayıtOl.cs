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
    public partial class girişYapvekayıtOl : Form
    {
        public girişYapvekayıtOl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uygulamaGiriş geri = new uygulamaGiriş();

            geri.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıAdıKayıt = textBox1.Text.ToString();

            string sifreKayıt = textBox2.Text.ToString();

            string kullanıcıAdıGiris = textBox3.Text.ToString();

            string sifreGiris = textBox4.Text.ToString();

            if (textBox2.Text.Length < 6)
            {
                MessageBox.Show("Şifreniz En Az 6 Haneli Olmalıdır ! ");                
            }

            else if (textBox2.Text.Length >= 6)
            {
                button1.Hide();

                textBox1.Hide();

                textBox2.Hide();

                textBox3.Show();

                textBox4.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaEkran ekran = new AnaEkran();

            ekran.label8.BackColor = System.Drawing.Color.Transparent;

            ekran.label9.BackColor = System.Drawing.Color.Transparent;

            string kullanıcıAdıKayıt1 = textBox1.Text.ToString();

            string sifreKayıt1 = textBox2.Text.ToString();

            string kullanıcıAdıGiris1 = textBox3.Text.ToString();

            string sifreGiris1 = textBox4.Text.ToString();
                                  
            if (kullanıcıAdıKayıt1 != kullanıcıAdıGiris1 || sifreKayıt1 != sifreGiris1)
            {
                MessageBox.Show("Kullanıcı Adınız Veya Şifreniz Hatalı ! Lütfen Tekrar Deneyiniz !");

                textBox3.Hide();

                textBox4.Hide();

                textBox3.Show();

                textBox4.Show();
            }

            else if (kullanıcıAdıKayıt1 == kullanıcıAdıGiris1 || sifreKayıt1 == sifreGiris1)
            {
                AnaEkran gidis = new AnaEkran();

                gidis.label1.BackColor = System.Drawing.Color.Transparent;

                gidis.label2.BackColor = System.Drawing.Color.Transparent;

                gidis.label8.Text = kullanıcıAdıGiris1;

                gidis.Show();

                this.Hide();

                gidis.label8.BackColor = System.Drawing.Color.Transparent;

                gidis.label9.BackColor = System.Drawing.Color.Transparent;
            }
            
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
