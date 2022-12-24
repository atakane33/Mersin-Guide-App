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
    public partial class OtobüsGüzergahları : Form
    {
        public OtobüsGüzergahları()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.OpenFileDialog openFileDialog1;

        public OpenFileDialog ofc = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName; // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\3432331.jpg"

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\3432331.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName; // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\3617730.jpg"

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\3617730.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName; // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\3617743.jpg"

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\3617743.jpg";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName; // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\3432329.jpg"

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\3432329.jpg";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName; // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\3432334.jpg"

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\3432324.jpg";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName; // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\5587350.jpg"

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\5587350.jpg";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName;  // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\3617728.jpg"

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\3617728.jpg";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName; // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\5587352.jpg"

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\5587352.jpg";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName; // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\6008957.jpg"
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName;   // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\3617739.jpg"                                // gecis.pictureBox1.Image = Image.FromFile(@"..\..\Otobüs Durakları\3617739.jpg");

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\3617739.jpg";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName; // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\3432334.jpg"

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\3432334.jpg";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahlarıSon gecis = new OtobüsGüzergahlarıSon();

            gecis.Show();

            this.Hide();

            gecis.pictureBox1.ImageLocation = openFileDialog1.FileName; // @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Otobüs Durakları\5999575.jpg"

            gecis.pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Otobüs Durakları\\5999575.jpg";
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

            this.Hide();

            geri.label8.Text = giris.textBox1.Text.ToString();
        }
    }
}
