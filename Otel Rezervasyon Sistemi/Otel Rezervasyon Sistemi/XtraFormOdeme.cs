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
    public partial class XtraFormOdeme : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormOdeme()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelrezervasyon;Uid=root;Pwd=Sude!;");
        private void BtnTamamla_Click(object sender, EventArgs e)
        {
            if (txtEditCvv.Text == null)
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
            }
            else
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into odeme(odemeyontemi,kartno,sonkultarih,cvv,ad,soyad,sehir,fadres,postakod,ulke,telefonno) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
                komut.Parameters.AddWithValue("@p1", cmbEditOdemeYontemi.Text);
                komut.Parameters.AddWithValue("@p2", txtEditKartNo.Text);
                komut.Parameters.AddWithValue("@p3", txtEditSonTar.DateTimeOffset);
                komut.Parameters.AddWithValue("@p4", txtEditCvv.Text);
                komut.Parameters.AddWithValue("@p5", txtEditAd.Text);
                komut.Parameters.AddWithValue("@p6", txtEditSoyad.Text);
                komut.Parameters.AddWithValue("@p7", txtEditSehir.Text);
                komut.Parameters.AddWithValue("@p8", txtEditAdres.Text);
                komut.Parameters.AddWithValue("@p9", txtEditPostaKod.Text);
                komut.Parameters.AddWithValue("@p10", txtEditUlke.Text);
                komut.Parameters.AddWithValue("@p11", txtEditTelNo.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydınız yapılmştır ana sayfaya yönlendiriliyorsunuz...");
                XtraFormMusteriAnaSayfa fr = new XtraFormMusteriAnaSayfa();
                fr.Show();
                this.Hide();
            }
            
        }

        private void XtraFormOdeme_Load(object sender, EventArgs e)
        {
           
        }
    }
}