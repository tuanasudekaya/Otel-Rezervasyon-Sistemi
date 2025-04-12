namespace Otel_Rezervasyon_Sistemi
{
    partial class XtraFormMusteriAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMesaj = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOdaKayıt = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnCikis
            // 
            this.BtnCikis.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Appearance.Options.UseFont = true;
            this.BtnCikis.Location = new System.Drawing.Point(151, 157);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(134, 73);
            this.BtnCikis.TabIndex = 0;
            this.BtnCikis.Text = "Çıkış Yap";
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnMesaj
            // 
            this.BtnMesaj.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMesaj.Appearance.Options.UseFont = true;
            this.BtnMesaj.Location = new System.Drawing.Point(65, 61);
            this.BtnMesaj.Name = "BtnMesaj";
            this.BtnMesaj.Size = new System.Drawing.Size(134, 73);
            this.BtnMesaj.TabIndex = 1;
            this.BtnMesaj.Text = "Mesaj Geri\r\nBildirim";
            this.BtnMesaj.Click += new System.EventHandler(this.BtnMesaj_Click);
            // 
            // BtnOdaKayıt
            // 
            this.BtnOdaKayıt.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdaKayıt.Appearance.Options.UseFont = true;
            this.BtnOdaKayıt.Location = new System.Drawing.Point(234, 61);
            this.BtnOdaKayıt.Name = "BtnOdaKayıt";
            this.BtnOdaKayıt.Size = new System.Drawing.Size(134, 73);
            this.BtnOdaKayıt.TabIndex = 2;
            this.BtnOdaKayıt.Text = "Oda Kayıt";
            this.BtnOdaKayıt.Click += new System.EventHandler(this.BtnOdaKayıt_Click);
            // 
            // XtraFormMusteriAnaSayfa
            // 
            this.Appearance.BackColor = System.Drawing.Color.Teal;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 261);
            this.Controls.Add(this.BtnOdaKayıt);
            this.Controls.Add(this.BtnMesaj);
            this.Controls.Add(this.BtnCikis);
            this.Name = "XtraFormMusteriAnaSayfa";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnCikis;
        private DevExpress.XtraEditors.SimpleButton BtnMesaj;
        private DevExpress.XtraEditors.SimpleButton BtnOdaKayıt;
    }
}