namespace Otel_Rezervasyon_Sistemi
{
    partial class XtraFormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormGiris));
            this.BtnMusteriGiris = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdminGiris = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnMusteriGiris
            // 
            this.BtnMusteriGiris.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMusteriGiris.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriGiris.Appearance.Options.UseBackColor = true;
            this.BtnMusteriGiris.Appearance.Options.UseFont = true;
            this.BtnMusteriGiris.Location = new System.Drawing.Point(12, 190);
            this.BtnMusteriGiris.Name = "BtnMusteriGiris";
            this.BtnMusteriGiris.Size = new System.Drawing.Size(105, 42);
            this.BtnMusteriGiris.TabIndex = 0;
            this.BtnMusteriGiris.Text = "Müşteri Giriş";
            this.BtnMusteriGiris.Click += new System.EventHandler(this.BtnMusteriGiris_Click);
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnAdminGiris.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdminGiris.Appearance.Options.UseBackColor = true;
            this.BtnAdminGiris.Appearance.Options.UseFont = true;
            this.BtnAdminGiris.Location = new System.Drawing.Point(285, 190);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(105, 42);
            this.BtnAdminGiris.TabIndex = 1;
            this.BtnAdminGiris.Text = "Personel Giriş";
            this.BtnAdminGiris.Click += new System.EventHandler(this.BtnAdminGiris_Click);
            // 
            // XtraFormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(402, 244);
            this.Controls.Add(this.BtnAdminGiris);
            this.Controls.Add(this.BtnMusteriGiris);
            this.Name = "XtraFormGiris";
            this.Text = "Giriş Sayfası";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnMusteriGiris;
        private DevExpress.XtraEditors.SimpleButton BtnAdminGiris;
    }
}