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

namespace Otel_Rezervasyon_Sistemi
{
    public partial class XtraFormMusteriAnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormMusteriAnaSayfa()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOdaKayıt_Click(object sender, EventArgs e)
        {
            XtraFormMusteriKayıt fr=new XtraFormMusteriKayıt();
            fr.Show();

        }

        private void BtnMesaj_Click(object sender, EventArgs e)
        {
            XtraFormMusteriMesajlar fr=new XtraFormMusteriMesajlar();
            fr.Show();
            this.Hide();
        }
    }
}