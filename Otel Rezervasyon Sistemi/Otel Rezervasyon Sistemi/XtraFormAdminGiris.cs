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
    public partial class XtraFormAdminGiris : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormAdminGiris()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelrezervasyon;Uid=root;Pwd=Sude!;");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "select * from admingiris where kullaniciadi=@p1 AND sifre=@p2";
            MySqlCommand cmd= new MySqlCommand(sql,baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtEditKulllaniciAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtEditSifre.Text);
            
            DataTable dt = new DataTable();
            MySqlDataAdapter da= new MySqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                XtraFormAnaForm fr=new XtraFormAnaForm();
                fr.Show();
                this.Hide();
                
            }
            else { MessageBox.Show("Hatalı kullanıcı adı veya şifre!"); baglanti.Close(); }
        }
    }
}