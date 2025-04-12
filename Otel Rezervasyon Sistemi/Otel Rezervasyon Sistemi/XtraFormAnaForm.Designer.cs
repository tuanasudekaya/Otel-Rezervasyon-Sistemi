namespace Otel_Rezervasyon_Sistemi
{
    partial class XtraFormAnaForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnMusteriGiris = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOdalar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMusteriler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnStok = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMesaj = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(172, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 37);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "HOŞ GELDİNİZ";
            // 
            // BtnMusteriGiris
            // 
            this.BtnMusteriGiris.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriGiris.Appearance.Options.UseFont = true;
            this.BtnMusteriGiris.Location = new System.Drawing.Point(66, 134);
            this.BtnMusteriGiris.Name = "BtnMusteriGiris";
            this.BtnMusteriGiris.Size = new System.Drawing.Size(103, 62);
            this.BtnMusteriGiris.TabIndex = 1;
            this.BtnMusteriGiris.Text = "Müşteri Ekle";
            this.BtnMusteriGiris.Click += new System.EventHandler(this.BtnMusteriGiris_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Appearance.Options.UseFont = true;
            this.BtnCikis.Location = new System.Drawing.Point(217, 195);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(103, 62);
            this.BtnCikis.TabIndex = 2;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnOdalar
            // 
            this.BtnOdalar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdalar.Appearance.Options.UseFont = true;
            this.BtnOdalar.Location = new System.Drawing.Point(364, 134);
            this.BtnOdalar.Name = "BtnOdalar";
            this.BtnOdalar.Size = new System.Drawing.Size(103, 62);
            this.BtnOdalar.TabIndex = 3;
            this.BtnOdalar.Text = "Odalar";
            this.BtnOdalar.Click += new System.EventHandler(this.BtnOdalar_Click);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriler.Appearance.Options.UseFont = true;
            this.BtnMusteriler.Location = new System.Drawing.Point(217, 76);
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.Size = new System.Drawing.Size(103, 62);
            this.BtnMusteriler.TabIndex = 4;
            this.BtnMusteriler.Text = "Müşteriler";
            this.BtnMusteriler.Click += new System.EventHandler(this.BtnMusteriler_Click);
            // 
            // BtnStok
            // 
            this.BtnStok.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStok.Appearance.Options.UseFont = true;
            this.BtnStok.Location = new System.Drawing.Point(97, 268);
            this.BtnStok.Name = "BtnStok";
            this.BtnStok.Size = new System.Drawing.Size(103, 62);
            this.BtnStok.TabIndex = 5;
            this.BtnStok.Text = "Stoklar";
            this.BtnStok.Click += new System.EventHandler(this.BtnStok_Click);
            // 
            // BtnMesaj
            // 
            this.BtnMesaj.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMesaj.Appearance.Options.UseFont = true;
            this.BtnMesaj.Location = new System.Drawing.Point(335, 268);
            this.BtnMesaj.Name = "BtnMesaj";
            this.BtnMesaj.Size = new System.Drawing.Size(103, 62);
            this.BtnMesaj.TabIndex = 6;
            this.BtnMesaj.Text = "Müşteri\r\nMesajları";
            this.BtnMesaj.Click += new System.EventHandler(this.BtnMesaj_Click);
            // 
            // XtraFormAnaForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(521, 410);
            this.Controls.Add(this.BtnMesaj);
            this.Controls.Add(this.BtnStok);
            this.Controls.Add(this.BtnMusteriler);
            this.Controls.Add(this.BtnOdalar);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnMusteriGiris);
            this.Controls.Add(this.labelControl1);
            this.MinimizeBox = false;
            this.Name = "XtraFormAnaForm";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnMusteriGiris;
        private DevExpress.XtraEditors.SimpleButton BtnCikis;
        private DevExpress.XtraEditors.SimpleButton BtnOdalar;
        private DevExpress.XtraEditors.SimpleButton BtnMusteriler;
        private DevExpress.XtraEditors.SimpleButton BtnStok;
        private DevExpress.XtraEditors.SimpleButton BtnMesaj;
    }
}