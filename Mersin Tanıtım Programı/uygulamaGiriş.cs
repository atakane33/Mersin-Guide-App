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
    public partial class uygulamaGiriş : Form
    {
        public uygulamaGiriş()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hakkında gecis = new Hakkında();

            gecis.Show();

            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            girişYapvekayıtOl gecis = new girişYapvekayıtOl();

            gecis.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            girişYapvekayıtOl gecis1 = new girişYapvekayıtOl();

            gecis1.Show();

            this.Hide();                                        
        }
    }
}
