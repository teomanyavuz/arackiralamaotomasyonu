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
    public partial class araçkayıtsayfası : Form
    {
        araçkiralama araç_kiralama = new araçkiralama();

        public araçkayıtsayfası()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sericombo.Items.Clear();
                if (markacombo.SelectedIndex == 0)
                {

                    sericombo.Items.Add("320i");
                    sericombo.Items.Add("525d");
                }
                else if(markacombo.SelectedIndex==1)
                {
                    sericombo.Items.Add("PANAMERA");
                    sericombo.Items.Add("TAYCAN");
                }
                else if (markacombo.SelectedIndex == 2)
                {
                    sericombo.Items.Add("LAGUNA");
                    sericombo.Items.Add("MEGANE");
                }

            }
            catch
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "Insert into araç(plaka,marka,seri,yıl,kiraücreti,tarih,durumu)  values(@plaka,@marka,@seri,@yıl,@kiraücreti,@tarih,@durumu)";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@plaka",plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", sericombo.Text);
            komut2.Parameters.AddWithValue("@yıl", yıltxt.Text);
            komut2.Parameters.AddWithValue("@kiraücreti", ücrettxt.Text);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");

            araç_kiralama.ekle_sil_güncelle(komut2, cümle);
            sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        private void araçkayıtsayfası_Load(object sender, EventArgs e)
        {

        }
    }
}
