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
    public partial class XtraFormAnaForm : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormAnaForm()
        {
            InitializeComponent();
        }

       
        private void BtnMusteriGiris_Click(object sender, EventArgs e)
        {
            XtraFormYeniMusteri fr=new XtraFormYeniMusteri();
            fr.Show();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            XtraFormMusteriler fr=new XtraFormMusteriler();
            fr.Show();
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
           XtraFormOdalar fr=new XtraFormOdalar();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            XtraFormStoklar fr=new XtraFormStoklar();
            fr.Show();
        }

        private void BtnMesaj_Click(object sender, EventArgs e)
        {
            XtraFormGelenMesajlar fr=new XtraFormGelenMesajlar();
            fr.Show();
        }
    }
}