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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Otel_Rezervasyon_Sistemi
{
    public partial class XtraFormOdalar : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormOdalar()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelrezervasyon;Uid=root;Pwd=Sude!;");

        private void XtraFormOdalar_Load(object sender, EventArgs e)
        {
            for (int i = 101; i <= 112; i++)
            {
                string buttonName = "Btn" + i.ToString();
                SimpleButton button = Controls.Find(buttonName, true).FirstOrDefault() as SimpleButton;

                if (button != null)
                {
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("select * from MusteriEkle where odano='" + i.ToString() + "'", baglanti);
                    MySqlDataReader oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        button.Text = oku["adi"]?.ToString() + " " + oku["soyadi"]?.ToString();
                        if (button.Text != i.ToString())
                        {
                            button.Appearance.BackColor = Color.IndianRed;
                            
                        }
                    }
                    baglanti.Close();




                }
            }
        }
    }
}