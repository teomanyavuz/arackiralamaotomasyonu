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
    public partial class frmmüşterilisteleme : Form
    {

        araçkiralama araçkirala = new araçkiralama();

        public frmmüşterilisteleme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmmüşterilisteleme_Load(object sender, EventArgs e)
        {
            yenilelistele();
        }
        
        
        public void yenilelistele(){
            string cümle = "select * from Müşteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = araçkirala.listele(adtr2, cümle);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from Müşteri where no like '%"+textBox1.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
           

            dataGridView1.DataSource = araçkirala.listele(adtr2, cümle);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;

            string cümle = "Delete from dbo.Müşteri where no'"+satır.Cells["no"].Value.ToString()+"'";
            SqlCommand komut2 = new SqlCommand();

            araçkirala.ekle_sil_güncelle(komut2, cümle);
            //foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenilelistele();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update Müşteri set ad=@ad,soyad=@soyad where no=@no";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@no", txtno.Text);
            komut2.Parameters.AddWithValue("@ad", txtad.Text);
            komut2.Parameters.AddWithValue("@soyad", txtsoyad.Text);
           
            araçkirala.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenilelistele();
        }

        private void btnİPTAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtno.Text = satır.Cells[0].Value.ToString();
            txtad.Text = satır.Cells[1].Value.ToString();
            txtsoyad.Text = satır.Cells[2].Value.ToString();
           


        }
    }
}
