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
    
    public partial class frmaraçlistele : Form
    {
        araçkiralama araçkirala = new araçkiralama();
        public frmaraçlistele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from araç where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";

            SqlCommand komut2 = new SqlCommand();
            araçkirala.ekle_sil_güncelle(komut2,cümle);
            YenileAraçlarListesi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            plakatxt.Text = satır.Cells["plaka"].Value.ToString();
            markacombo.Text = satır.Cells["marka"].Value.ToString();
            sericombo.Text = satır.Cells["seri"].Value.ToString();
            yıltxt.Text = satır.Cells["yıl"].Value.ToString();
            ücrettxt.Text = satır.Cells["ücret"].Value.ToString();

        }

        private void frmaraçlistele_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
            
                comboaraçlar.SelectedIndex = 0;
           



        }

        public void YenileAraçlarListesi()
        {
            string cümle = "select * from araç";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
             dataGridView1.DataSource = araçkirala.listele(adtr2, cümle);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update araç set marka=@marka,seri=@seri,yıl=@yıl,ücret=@ücret,tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@plaka", plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", sericombo.Text);
            komut2.Parameters.AddWithValue("@yıl", yıltxt.Text);
            komut2.Parameters.AddWithValue("@kiraücreti", ücrettxt.Text);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

            araçkirala.ekle_sil_güncelle(komut2, cümle);
            sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        private void markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sericombo.Items.Clear();
                if (markacombo.SelectedIndex == 0)
                {

                    sericombo.Items.Add("320i");
                    sericombo.Items.Add("525d");
                }
                else if (markacombo.SelectedIndex == 1)
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

        private void comboaraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboaraçlar.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                if (comboaraçlar.SelectedIndex == 1)
                {
                    string cümle = "select * from araç where durumu='BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = araçkirala.listele(adtr2, cümle);
                }
                if (comboaraçlar.SelectedIndex == 2)
                {
                    string cümle = "select * from araç where durumu ='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = araçkirala.listele(adtr2, cümle);
                }
            }
            catch
            {

            }
        }
    }
}
