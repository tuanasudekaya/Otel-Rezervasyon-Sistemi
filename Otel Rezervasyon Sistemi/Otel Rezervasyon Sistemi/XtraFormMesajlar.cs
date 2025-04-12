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
    public partial class XtraFormMusteriMesajlar : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormMusteriMesajlar()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelrezervasyon;Uid=root;Pwd=Sude!;");

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into mesaj(mesajad,mesajsoyad,mesajmetni) values (@p1,@p2,@p3) ",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtEditAdı.Text);
            komut.Parameters.AddWithValue("@p2", txtEditSoyad.Text);
            komut.Parameters.AddWithValue("@p3", richEditMesaj.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Mesajınız iletilmiştir,geri bildiriminiz için çok teşekkür ederiz.");
            baglanti.Close();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            XtraFormMusteriAnaSayfa fr = new XtraFormMusteriAnaSayfa();
            fr.Show();
            this.Hide();


        }
    }
}