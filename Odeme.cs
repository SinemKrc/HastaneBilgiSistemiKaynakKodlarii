using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_HastaneDB
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port = 5432; " +
            "Database = HastaneVeritabani; user ID = postgres; password = 3457");

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into odeme (\"OdemeNo\", \"OdemeTarihi\", \"OdemeTuru\", \"ToplamTutar\", \"TCKimlikNo\") values (@p1, @p2, @p3, @p4, @p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_odemeNo.Text);
            komut.Parameters.AddWithValue("@p2", DateTime.Parse(txt_odemeTarihi.Text));
            komut.Parameters.AddWithValue("@p3", cmb_odemeTuru.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@p4", double.Parse(txt_toplamTutar.Text));
            komut.Parameters.AddWithValue("@p5", txt_tc.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ODEME KAYDI BASARILI!", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_listele_Click(object sender, EventArgs e)    
        {
            string sorgu = "select * from odeme";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Odeme_Load(object sender, EventArgs e)
        { 
            cmb_odemeTuru.Items.Add("Nakit");
            cmb_odemeTuru.Items.Add("Kart");     
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from odeme where \"OdemeNo\" = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", txt_odemeNo.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ODEME KAYDI SILINDI!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update odeme set \"ToplamTutar\" = @p1 where \"OdemeNo\" = @p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", double.Parse(txt_toplamTutar.Text));
            komut3.Parameters.AddWithValue("@p2", txt_odemeNo.Text);
            komut3.ExecuteNonQuery();
            MessageBox.Show("ODEME GUNCELLEME BASARILI!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            baglanti.Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("select * from odeme where \"TCKimlikNo\" = @p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", txt_tc.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut3);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
