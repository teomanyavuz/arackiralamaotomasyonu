using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araçkiralamaotomasyonu
{
    public partial class formmüsteriekle : Form
    {
        araçkiralama arac_kiralama = new araçkiralama();
        public formmüsteriekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cümle = "Insert into Müşteri(ad, soyad, no) Values(@ad, @soyad, @no)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ad", txtad.Text);
            komut2.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@no", txtno.Text);
            arac_kiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
