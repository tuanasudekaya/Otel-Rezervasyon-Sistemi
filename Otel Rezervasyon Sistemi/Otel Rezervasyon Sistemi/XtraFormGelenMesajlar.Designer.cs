namespace Otel_Rezervasyon_Sistemi
{
    partial class XtraFormGelenMesajlar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnMesajGoster = new DevExpress.XtraEditors.SimpleButton();
            this.txtEditSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtEditAdı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnMesajSil = new DevExpress.XtraEditors.SimpleButton();
            this.Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtEditAramaYap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAramaYap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(542, 199);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 27;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mesaj";
            this.columnHeader4.Width = 351;
            // 
            // BtnMesajGoster
            // 
            this.BtnMesajGoster.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMesajGoster.Appearance.Options.UseFont = true;
            this.BtnMesajGoster.Location = new System.Drawing.Point(591, 85);
            this.BtnMesajGoster.Name = "BtnMesajGoster";
            this.BtnMesajGoster.Size = new System.Drawing.Size(103, 38);
            this.BtnMesajGoster.TabIndex = 1;
            this.BtnMesajGoster.Text = "Mesaj Göster";
            this.BtnMesajGoster.Click += new System.EventHandler(this.BtnMesajGoster_Click);
            // 
            // txtEditSoyad
            // 
            this.txtEditSoyad.Location = new System.Drawing.Point(77, 43);
            this.txtEditSoyad.Name = "txtEditSoyad";
            this.txtEditSoyad.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEditSoyad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSoyad.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtEditSoyad.Properties.Appearance.Options.UseBackColor = true;
            this.txtEditSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtEditSoyad.Properties.Appearance.Options.UseForeColor = true;
            this.txtEditSoyad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEditSoyad.Size = new System.Drawing.Size(169, 24);
            this.txtEditSoyad.TabIndex = 37;
            // 
            // txtEditAdı
            // 
            this.txtEditAdı.Location = new System.Drawing.Point(77, 12);
            this.txtEditAdı.Name = "txtEditAdı";
            this.txtEditAdı.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEditAdı.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditAdı.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtEditAdı.Properties.Appearance.Options.UseBackColor = true;
            this.txtEditAdı.Properties.Appearance.Options.UseFont = true;
            this.txtEditAdı.Properties.Appearance.Options.UseForeColor = true;
            this.txtEditAdı.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEditAdı.Size = new System.Drawing.Size(169, 24);
            this.txtEditAdı.TabIndex = 36;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 17);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Soyadı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 17);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Adı:";
            // 
            // BtnMesajSil
            // 
            this.BtnMesajSil.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMesajSil.Appearance.Options.UseFont = true;
            this.BtnMesajSil.Location = new System.Drawing.Point(591, 246);
            this.BtnMesajSil.Name = "BtnMesajSil";
            this.BtnMesajSil.Size = new System.Drawing.Size(103, 38);
            this.BtnMesajSil.TabIndex = 38;
            this.BtnMesajSil.Text = "Sil";
            this.BtnMesajSil.Click += new System.EventHandler(this.BtnMesajSil_Click);
            // 
            // Temizle
            // 
            this.Temizle.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Appearance.Options.UseFont = true;
            this.Temizle.Location = new System.Drawing.Point(591, 168);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(103, 38);
            this.Temizle.TabIndex = 39;
            this.Temizle.Text = "Temizle";
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // txtEditAramaYap
            // 
            this.txtEditAramaYap.Location = new System.Drawing.Point(441, 8);
            this.txtEditAramaYap.Name = "txtEditAramaYap";
            this.txtEditAramaYap.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEditAramaYap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditAramaYap.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtEditAramaYap.Properties.Appearance.Options.UseBackColor = true;
            this.txtEditAramaYap.Properties.Appearance.Options.UseFont = true;
            this.txtEditAramaYap.Properties.Appearance.Options.UseForeColor = true;
            this.txtEditAramaYap.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEditAramaYap.Size = new System.Drawing.Size(101, 24);
            this.txtEditAramaYap.TabIndex = 40;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(410, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 17);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Adı:";
            // 
            // BtnAra
            // 
            this.BtnAra.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Appearance.Options.UseFont = true;
            this.BtnAra.Location = new System.Drawing.Point(591, 3);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(103, 38);
            this.BtnAra.TabIndex = 42;
            this.BtnAra.Text = "Ara";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(400, -40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(4, 119);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // XtraFormGelenMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 288);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtEditAramaYap);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.BtnMesajSil);
            this.Controls.Add(this.txtEditSoyad);
            this.Controls.Add(this.txtEditAdı);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnMesajGoster);
            this.Controls.Add(this.listView1);
            this.Name = "XtraFormGelenMesajlar";
            this.Text = "XtraFormGelenMesajlar";
            ((System.ComponentModel.ISupportInitialize)(this.txtEditSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAramaYap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevExpress.XtraEditors.SimpleButton BtnMesajGoster;
        private DevExpress.XtraEditors.TextEdit txtEditSoyad;
        private DevExpress.XtraEditors.TextEdit txtEditAdı;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnMesajSil;
        private DevExpress.XtraEditors.SimpleButton Temizle;
        private DevExpress.XtraEditors.TextEdit txtEditAramaYap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}