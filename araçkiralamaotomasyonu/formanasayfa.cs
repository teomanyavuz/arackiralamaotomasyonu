using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araçkiralamaotomasyonu
{
    public partial class formanasayfa : Form
    {
        public formanasayfa()
        {
            InitializeComponent();
        }

        private void formanasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formmüsteriekle ekle = new formmüsteriekle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmmüşterilisteleme listele = new frmmüşterilisteleme();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            araçkayıtsayfası kayıt = new araçkayıtsayfası();
            kayıt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmaraçlistele listele = new frmaraçlistele();
            listele.ShowDialog();
        }
    }
}
