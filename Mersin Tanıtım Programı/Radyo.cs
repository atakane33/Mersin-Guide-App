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
    public partial class Radyo : Form
    {
        public Radyo()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AnaEkran geri = new AnaEkran();

            girişYapvekayıtOl giris = new girişYapvekayıtOl();

            geri.Show();            

            geri.label8.Text = giris.textBox1.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.125/listen.pls";
        }
    
    
        private void Radyo_Load (object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.125/listen.pls";
        } 
    
    }
}
