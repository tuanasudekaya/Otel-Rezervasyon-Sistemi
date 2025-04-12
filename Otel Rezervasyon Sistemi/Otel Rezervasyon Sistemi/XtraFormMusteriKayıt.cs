using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
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


namespace Otel_Rezervasyon_Sistemi
{
    public partial class XtraFormMusteriKayıt : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormMusteriKayıt()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelrezervasyon;Uid=root;Pwd=Sude!;");
        #region butonlar
        private void Btn101_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "101";
        }

        private void Btn102_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "102";
        }

        private void Btn103_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "103";
        }

        private void Btn104_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "104";
        }

        private void Btn105_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "105";
        }

        private void Btn106_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "106";
        }

        private void Btn107_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "107";
        }

        private void Btn108_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "108";
        }

        private void Btn109_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "109";
        }

        private void Btn110_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "110";
        }

        private void Btn111_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "111";
        }

        private void Btn112_Click(object sender, EventArgs e)
        {
            TxtEditOda.Text = "112";
        }
        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları temsil eder.");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları temsil eder.");
        }
        #endregion

        private void DtoCikisTar_EditValueChanged_1(object sender, EventArgs e)
        {
            int Ucret;
            DateTime GirisTarih = Convert.ToDateTime(DtoGirisTar.Text);
            DateTime CikisTarih = Convert.ToDateTime(DtoCikisTar.Text);

            TimeSpan Sonuc = CikisTarih - GirisTarih;

            string Gun = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(Gun) * 50;
            TxtEditUcret.Text = Ucret.ToString();

        }
        private void XtraFormMusteriKayıt_Load(object sender, EventArgs e)
        {
            for (int i = 101; i <= 112; i++)
            {
                string buttonName = "Btn" + i.ToString();
                SimpleButton button = Controls.Find(buttonName, true).FirstOrDefault() as SimpleButton;

                if (button != null)
                {
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("select * from musteriekle where odano='" + i.ToString() + "'", baglanti);
                    MySqlDataReader oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        button.Text = oku["adi"]?.ToString() + " " + oku["soyadi"]?.ToString();
                        if (button.Text != i.ToString())
                        {
                            button.Appearance.BackColor = Color.IndianRed;
                            button.Enabled = false;
                        }
                    }
                    baglanti.Close();




                }
            }
        }

        private void BtnOdemeYap_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into musteriekle(adi,soyadi,cinsiyet,telefon,mail,Tc,odaNo,giristarihi,cikistarihi,ucret) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtEditAdı.Text);
            komut.Parameters.AddWithValue("@p2", TxtEditSoyadı.Text);
            komut.Parameters.AddWithValue("@p3", TxtEditCinsiyet.Text);
            komut.Parameters.AddWithValue("@p4", TxtEditTelefon.Text);
            komut.Parameters.AddWithValue("@p5", TxtEditMail.Text);
            komut.Parameters.AddWithValue("@p6", TxtEditTC.Text);
            komut.Parameters.AddWithValue("@p7", TxtEditOda.Text);
            komut.Parameters.AddWithValue("@p8", DtoGirisTar.DateTimeOffset);
            komut.Parameters.AddWithValue("@p9", DtoCikisTar.DateTimeOffset);
            komut.Parameters.AddWithValue("@p10", TxtEditUcret.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            XtraFormOdeme fr = new XtraFormOdeme();
            fr.Show();
            this.Hide();
        }

       
    }
}