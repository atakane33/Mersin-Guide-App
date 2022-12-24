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
    public partial class OtobüsGüzergahlarıSon : Form
    {

        public OpenFileDialog ofd = new OpenFileDialog();        
        public OtobüsGüzergahlarıSon()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OtobüsGüzergahları geri = new OtobüsGüzergahları();

            geri.Show();

            this.Hide();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OtobüsGüzergahlarıSon_Load(object sender, EventArgs e)
        {

        }
    }
}
