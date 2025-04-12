namespace Otel_Rezervasyon_Sistemi
{
    partial class XtraFormAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormAdminGiris));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditKulllaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.TxtEditSifre = new DevExpress.XtraEditors.TextEdit();
            this.BtnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditKulllaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(194, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(249, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Şifre:";
            // 
            // TxtEditKulllaniciAdi
            // 
            this.TxtEditKulllaniciAdi.Location = new System.Drawing.Point(293, 40);
            this.TxtEditKulllaniciAdi.Name = "TxtEditKulllaniciAdi";
            this.TxtEditKulllaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditKulllaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.TxtEditKulllaniciAdi.Size = new System.Drawing.Size(148, 26);
            this.TxtEditKulllaniciAdi.TabIndex = 2;
            // 
            // TxtEditSifre
            // 
            this.TxtEditSifre.Location = new System.Drawing.Point(293, 72);
            this.TxtEditSifre.Name = "TxtEditSifre";
            this.TxtEditSifre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditSifre.Properties.Appearance.Options.UseFont = true;
            this.TxtEditSifre.Properties.PasswordChar = '*';
            this.TxtEditSifre.Size = new System.Drawing.Size(148, 26);
            this.TxtEditSifre.TabIndex = 3;
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGirisYap.Appearance.Options.UseFont = true;
            this.BtnGirisYap.Location = new System.Drawing.Point(307, 104);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(109, 30);
            this.BtnGirisYap.TabIndex = 4;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // XtraFormAdminGiris
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(693, 453);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtEditKulllaniciAdi);
            this.Controls.Add(this.TxtEditSifre);
            this.Name = "XtraFormAdminGiris";
            this.Text = "Admin Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditKulllaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtEditKulllaniciAdi;
        private DevExpress.XtraEditors.TextEdit TxtEditSifre;
        private DevExpress.XtraEditors.SimpleButton BtnGirisYap;
    }
}