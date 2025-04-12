using DevExpress.XtraExport.Xls;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Windows.Forms;

namespace Otel_Rezervasyon_Sistemi
{
    public partial class XtraFormMusteriler : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormMusteriler()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelrezervasyon;Uid=root;Pwd=Sude!;");
        private void veriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select* from MusteriEkle", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteriid"].ToString();
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["odaNo"].ToString());
                ekle.SubItems.Add(oku["giristarihi"].ToString());
                ekle.SubItems.Add(oku["cikistarihi"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            veriGoster();
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtEditAdı.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtEditSoyadı.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TxtEditCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtEditTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtEditMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtEditTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtEditOda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DtoGirisTar.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtoCikisTar.Text = listView1.SelectedItems[0].SubItems[9].Text;
            TxtEditUcret.Text = listView1.SelectedItems[0].SubItems[10].Text;
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from MusteriEkle where musteriid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriGoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtEditAdı.Clear();
            TxtEditSoyadı.Clear();
            TxtEditCinsiyet.Clear();
            TxtEditTelefon.Clear();
            TxtEditMail.Clear();
            TxtEditTC.Clear();
            TxtEditOda.Clear();
            DtoGirisTar.Clear();
            DtoCikisTar.Clear();
            TxtEditUcret.Clear();
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("update MusteriEkle set adi=@p1,soyadi=@p2,cinsiyet=@p3,telefon=@p4,mail=@p5,tc=@p6,odano=@p11,giristarihi=@p7,cikistarihi=@p8,ucret=@p9 where musteriid=@p10",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtEditAdı.Text);
            komut.Parameters.AddWithValue("@p2", TxtEditSoyadı.Text);
            komut.Parameters.AddWithValue("@p3",TxtEditCinsiyet.Text);
            komut.Parameters.AddWithValue("@p4", TxtEditTelefon.Text);
            komut.Parameters.AddWithValue("@p5", TxtEditMail.Text);
            komut.Parameters.AddWithValue("@p6", TxtEditTC.Text);
            komut.Parameters.AddWithValue("@p11",TxtEditOda.Text);
            komut.Parameters.AddWithValue("@p7", DtoGirisTar.DateTime);
            komut.Parameters.AddWithValue("@p8", DtoCikisTar.DateTime);
            komut.Parameters.AddWithValue("@p9", TxtEditUcret.Text);
            komut.Parameters.AddWithValue("@p10", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriGoster();
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select* from MusteriEkle where tc like'%"+TxtEditTC.Text+"%'", baglanti);
            
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());

                listView1.Items.Add(ekle);
                
            }
            baglanti.Close();
        }
    }
}