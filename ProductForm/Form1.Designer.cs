namespace ProductForm
{
    partial class Form1
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
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.TxtUretici = new System.Windows.Forms.TextBox();
            this.pnlListe = new System.Windows.Forms.Panel();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÜreticiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spcUrunKayit = new System.Windows.Forms.SplitContainer();
            this.CAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcUrunKayit)).BeginInit();
            this.spcUrunKayit.Panel1.SuspendLayout();
            this.spcUrunKayit.Panel2.SuspendLayout();
            this.spcUrunKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(146, 76);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(213, 20);
            this.TxtFiyat.TabIndex = 1;
            // 
            // TxtUretici
            // 
            this.TxtUretici.Location = new System.Drawing.Point(146, 110);
            this.TxtUretici.Name = "TxtUretici";
            this.TxtUretici.Size = new System.Drawing.Size(213, 20);
            this.TxtUretici.TabIndex = 1;
            // 
            // pnlListe
            // 
            this.pnlListe.BackColor = System.Drawing.Color.DarkGray;
            this.pnlListe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListe.Location = new System.Drawing.Point(0, 0);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(1026, 10);
            this.pnlListe.TabIndex = 1;
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Location = new System.Drawing.Point(146, 42);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(213, 20);
            this.TxtUrunAdi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(10, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Birim Fiyat:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(10, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Üretici Adı:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(897, 9);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(89, 33);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Sayfayı Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.Location = new System.Drawing.Point(204, 9);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(58, 36);
            this.BtnDelete.TabIndex = 24;
            this.BtnDelete.Text = "Kaydı Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(109, 9);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(60, 35);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Ürün Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunAdi,
            this.Fiyat,
            this.ÜreticiAdi,
            this.Kategori,
            this.id});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 10);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1026, 187);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // UrunAdi
            // 
            this.UrunAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAdi.HeaderText = "UrunAdi";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Width = 54;
            // 
            // ÜreticiAdi
            // 
            this.ÜreticiAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ÜreticiAdi.HeaderText = "ÜreticiAdı";
            this.ÜreticiAdi.Name = "ÜreticiAdi";
            // 
            // Kategori
            // 
            this.Kategori.HeaderText = "Kategori";
            this.Kategori.Name = "Kategori";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // spcUrunKayit
            // 
            this.spcUrunKayit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcUrunKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcUrunKayit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcUrunKayit.Location = new System.Drawing.Point(0, 56);
            this.spcUrunKayit.Name = "spcUrunKayit";
            this.spcUrunKayit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcUrunKayit.Panel1
            // 
            this.spcUrunKayit.Panel1.Controls.Add(this.CAdd);
            this.spcUrunKayit.Panel1.Controls.Add(this.comboBox1);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtFiyat);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtUretici);
            this.spcUrunKayit.Panel1.Controls.Add(this.CName);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtUrunAdi);
            this.spcUrunKayit.Panel1.Controls.Add(this.label5);
            this.spcUrunKayit.Panel1.Controls.Add(this.label3);
            this.spcUrunKayit.Panel1.Controls.Add(this.label8);
            this.spcUrunKayit.Panel1.Controls.Add(this.label4);
            this.spcUrunKayit.Panel1.Controls.Add(this.label2);
            // 
            // spcUrunKayit.Panel2
            // 
            this.spcUrunKayit.Panel2.Controls.Add(this.Liste);
            this.spcUrunKayit.Panel2.Controls.Add(this.pnlListe);
            this.spcUrunKayit.Size = new System.Drawing.Size(1030, 462);
            this.spcUrunKayit.SplitterDistance = 257;
            this.spcUrunKayit.TabIndex = 27;
            // 
            // CAdd
            // 
            this.CAdd.Location = new System.Drawing.Point(631, 70);
            this.CAdd.Name = "CAdd";
            this.CAdd.Size = new System.Drawing.Size(110, 23);
            this.CAdd.TabIndex = 3;
            this.CAdd.Text = "Kategori Ekle";
            this.CAdd.UseVisualStyleBackColor = true;
            this.CAdd.Click += new System.EventHandler(this.CAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(758, 40);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(213, 20);
            this.CName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategori:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(628, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kategori Adı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1030, 56);
            this.label1.TabIndex = 21;
            this.label1.Text = "Urun Giris";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(12, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(45, 30);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(15, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 35);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Ürün Ekle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 518);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.spcUrunKayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.spcUrunKayit.Panel1.ResumeLayout(false);
            this.spcUrunKayit.Panel1.PerformLayout();
            this.spcUrunKayit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcUrunKayit)).EndInit();
            this.spcUrunKayit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.TextBox TxtUretici;
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.SplitContainer spcUrunKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CAdd;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÜreticiAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

