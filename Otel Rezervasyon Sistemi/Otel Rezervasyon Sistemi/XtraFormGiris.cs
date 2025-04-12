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
    public partial class XtraFormGiris : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormGiris()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            XtraFormAdminGiris fr = new XtraFormAdminGiris();
            fr.Show();
            this.Hide();
            

        }

        private void BtnMusteriGiris_Click(object sender, EventArgs e)
        {
            
            XtraFormMusteriAnaSayfa fr=new XtraFormMusteriAnaSayfa();
            fr.Show();
            this.Hide();
            
        }
    }
}