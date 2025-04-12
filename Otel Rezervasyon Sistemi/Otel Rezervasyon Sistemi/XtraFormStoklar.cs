using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using MySql.Data.MySqlClient;

namespace Otel_Rezervasyon_Sistemi
{
    public partial class XtraFormStoklar : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormStoklar()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelrezervasyon;Uid=root;Pwd=Sude!;");
        private void veriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from stok", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["stokid"].ToString();
                ekle.SubItems.Add(oku["stokadi"].ToString());
                ekle.SubItems.Add(oku["stokadedi"].ToString());
                
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            veriGoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtEditStokAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtEditAdet.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from stok where stokid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriGoster();
        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtEditStokAdi.Clear();
            TxtEditAdet.Clear();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("update stok set stokadi=@p1,stokadedi=@p2 where stokid=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtEditStokAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtEditAdet.Text);
            komut.Parameters.AddWithValue("@p3", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriGoster();
        }

        private void BtnAramaYap_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select* from stok where stokadi like'%" + TxtEditArama.Text + "%'", baglanti);

            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["stokid"].ToString();
                ekle.SubItems.Add(oku["stokadi"].ToString());
                ekle.SubItems.Add(oku["stokadedi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into stok(stokadi,stokadedi) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtEditStokAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtEditAdet.Text);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
        }
    }
}