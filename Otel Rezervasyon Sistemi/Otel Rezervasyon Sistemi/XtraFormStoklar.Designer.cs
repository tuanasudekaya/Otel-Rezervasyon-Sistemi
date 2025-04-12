namespace Otel_Rezervasyon_Sistemi
{
    partial class XtraFormStoklar
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.TxtEditAdet = new DevExpress.XtraEditors.TextEdit();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnVerileriGoster = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtEditArama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAramaYap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditArama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(170, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Adet:";
            // 
            // TxtEditStokAdi
            // 
            this.TxtEditStokAdi.Location = new System.Drawing.Point(81, 9);
            this.TxtEditStokAdi.Name = "TxtEditStokAdi";
            this.TxtEditStokAdi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TxtEditStokAdi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditStokAdi.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtEditStokAdi.Properties.Appearance.Options.UseBackColor = true;
            this.TxtEditStokAdi.Properties.Appearance.Options.UseFont = true;
            this.TxtEditStokAdi.Properties.Appearance.Options.UseForeColor = true;
            this.TxtEditStokAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TxtEditStokAdi.Size = new System.Drawing.Size(67, 24);
            this.TxtEditStokAdi.TabIndex = 32;
            // 
            // TxtEditAdet
            // 
            this.TxtEditAdet.Location = new System.Drawing.Point(214, 7);
            this.TxtEditAdet.Name = "TxtEditAdet";
            this.TxtEditAdet.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TxtEditAdet.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditAdet.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtEditAdet.Properties.Appearance.Options.UseBackColor = true;
            this.TxtEditAdet.Properties.Appearance.Options.UseFont = true;
            this.TxtEditAdet.Properties.Appearance.Options.UseForeColor = true;
            this.TxtEditAdet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TxtEditAdet.Size = new System.Drawing.Size(67, 24);
            this.TxtEditAdet.TabIndex = 33;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader12});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 197);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Adet";
            this.columnHeader12.Width = 72;
            // 
            // BtnVerileriGoster
            // 
            this.BtnVerileriGoster.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVerileriGoster.Appearance.Options.UseFont = true;
            this.BtnVerileriGoster.Location = new System.Drawing.Point(236, 48);
            this.BtnVerileriGoster.Name = "BtnVerileriGoster";
            this.BtnVerileriGoster.Size = new System.Drawing.Size(75, 33);
            this.BtnVerileriGoster.TabIndex = 37;
            this.BtnVerileriGoster.Text = "Verileri\r\nGöster";
            this.BtnVerileriGoster.Click += new System.EventHandler(this.BtnVerileriGoster_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.Location = new System.Drawing.Point(236, 87);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 33);
            this.BtnSil.TabIndex = 38;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.Location = new System.Drawing.Point(236, 126);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(75, 33);
            this.BtnGuncelle.TabIndex = 39;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.Location = new System.Drawing.Point(236, 165);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(75, 33);
            this.BtnTemizle.TabIndex = 40;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // TxtEditArama
            // 
            this.TxtEditArama.Location = new System.Drawing.Point(362, 6);
            this.TxtEditArama.Name = "TxtEditArama";
            this.TxtEditArama.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TxtEditArama.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditArama.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtEditArama.Properties.Appearance.Options.UseBackColor = true;
            this.TxtEditArama.Properties.Appearance.Options.UseFont = true;
            this.TxtEditArama.Properties.Appearance.Options.UseForeColor = true;
            this.TxtEditArama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TxtEditArama.Size = new System.Drawing.Size(67, 24);
            this.TxtEditArama.TabIndex = 41;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(328, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 20);
            this.labelControl3.TabIndex = 42;
            this.labelControl3.Text = "Adı:";
            // 
            // BtnAramaYap
            // 
            this.BtnAramaYap.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAramaYap.Appearance.Options.UseFont = true;
            this.BtnAramaYap.Location = new System.Drawing.Point(362, 36);
            this.BtnAramaYap.Name = "BtnAramaYap";
            this.BtnAramaYap.Size = new System.Drawing.Size(67, 45);
            this.BtnAramaYap.TabIndex = 43;
            this.BtnAramaYap.Text = "Arama\r\nYap";
            this.BtnAramaYap.Click += new System.EventHandler(this.BtnAramaYap_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(317, -2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(4, 240);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.Location = new System.Drawing.Point(236, 204);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 33);
            this.BtnEkle.TabIndex = 45;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // XtraFormStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 243);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.BtnAramaYap);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtEditArama);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnVerileriGoster);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TxtEditAdet);
            this.Controls.Add(this.TxtEditStokAdi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "XtraFormStoklar";
            this.Text = "Stoklar";
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditArama.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtEditStokAdi;
        private DevExpress.XtraEditors.TextEdit TxtEditAdet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private DevExpress.XtraEditors.SimpleButton BtnVerileriGoster;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.TextEdit TxtEditArama;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnAramaYap;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
    }
}