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
    public partial class ŞehirHaritası : Form
    {
        public ŞehirHaritası()
        {
            InitializeComponent();
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
