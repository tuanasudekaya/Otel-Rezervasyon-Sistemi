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
    public partial class XtraFormGelenMesajlar : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormGelenMesajlar()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelrezervasyon;Uid=root;Pwd=Sude!;");
        private void veriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from mesaj", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mesajid"].ToString();
                ekle.SubItems.Add(oku["mesajad"].ToString());
                ekle.SubItems.Add(oku["mesajsoyad"].ToString());
                ekle.SubItems.Add(oku["mesajmetni"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void BtnMesajGoster_Click(object sender, EventArgs e)
        {
            veriGoster();
        }
        int id = 0;

        private void Temizle_Click(object sender, EventArgs e)
        {
            txtEditAdı.Clear();
            txtEditSoyad.Clear();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtEditAdı.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtEditSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void BtnMesajSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from mesaj where mesajid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriGoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select* from mesaj where mesajad like'%" + txtEditAramaYap.Text + "%'", baglanti);

            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mesajid"].ToString();
                ekle.SubItems.Add(oku["mesajad"].ToString());
                ekle.SubItems.Add(oku["mesajsoyad"].ToString());
                ekle.SubItems.Add(oku["mesajmetni"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}