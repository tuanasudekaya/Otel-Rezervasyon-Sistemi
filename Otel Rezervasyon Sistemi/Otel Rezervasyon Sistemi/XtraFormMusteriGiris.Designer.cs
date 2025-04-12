namespace Otel_Rezervasyon_Sistemi
{
    partial class XtraFormMusteriGiris
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
            this.BtnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.TxtEditSifre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGirisYap.Appearance.Options.UseFont = true;
            this.BtnGirisYap.Location = new System.Drawing.Point(155, 141);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(148, 30);
            this.BtnGirisYap.TabIndex = 9;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(111, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 21);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Şifre:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 21);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // TxtEditKullaniciAdi
            // 
            this.TxtEditKullaniciAdi.Location = new System.Drawing.Point(155, 42);
            this.TxtEditKullaniciAdi.Name = "TxtEditKullaniciAdi";
            this.TxtEditKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.TxtEditKullaniciAdi.Size = new System.Drawing.Size(148, 26);
            this.TxtEditKullaniciAdi.TabIndex = 7;
            // 
            // TxtEditSifre
            // 
            this.TxtEditSifre.Location = new System.Drawing.Point(155, 89);
            this.TxtEditSifre.Name = "TxtEditSifre";
            this.TxtEditSifre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditSifre.Properties.Appearance.Options.UseFont = true;
            this.TxtEditSifre.Properties.PasswordChar = '*';
            this.TxtEditSifre.Size = new System.Drawing.Size(148, 26);
            this.TxtEditSifre.TabIndex = 8;
            // 
            // XtraFormMusteriGiris
            // 
            this.Appearance.BackColor = System.Drawing.Color.SlateGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 224);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtEditKullaniciAdi);
            this.Controls.Add(this.TxtEditSifre);
            this.Name = "XtraFormMusteriGiris";
            this.Text = "Müşteri Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGirisYap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtEditKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit TxtEditSifre;
    }
}