using System;

namespace GelirGiderTakip
{
    partial class frmGelirGider
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOdemTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipi = new System.Windows.Forms.ComboBox();
            this.lblGiderTipi = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.lbTarih = new System.Windows.Forms.Label();
            this.lbCari = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.radGider = new System.Windows.Forms.RadioButton();
            this.radGelir = new System.Windows.Forms.RadioButton();
            this.lblIslemTipi = new System.Windows.Forms.Label();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtTarih2 = new System.Windows.Forms.DateTimePicker();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.dtTarih1 = new System.Windows.Forms.DateTimePicker();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.cmbOdemeTipiSor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGelirToplam = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblGiderToplamSonuc = new System.Windows.Forms.Label();
            this.lblGelirToplamSonuc = new System.Windows.Forms.Label();
            this.lblGiderToplam = new System.Windows.Forms.Label();
            this.lblToplamSonuc = new System.Windows.Forms.Label();
            this.lblKrediSonuc = new System.Windows.Forms.Label();
            this.lblKredi = new System.Windows.Forms.Label();
            this.lblNakit = new System.Windows.Forms.Label();
            this.lblNakitSonuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbOdemTipi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTipi);
            this.groupBox1.Controls.Add(this.lblGiderTipi);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.btnKapat);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Controls.Add(this.dtTarih);
            this.groupBox1.Controls.Add(this.lbTarih);
            this.groupBox1.Controls.Add(this.lbCari);
            this.groupBox1.Controls.Add(this.lblTutar);
            this.groupBox1.Controls.Add(this.lblAciklama);
            this.groupBox1.Controls.Add(this.radGider);
            this.groupBox1.Controls.Add(this.radGelir);
            this.groupBox1.Controls.Add(this.lblIslemTipi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 621);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Copyright © 2024 Tüm Hakları Saklıdır.";
            // 
            // cmbOdemTipi
            // 
            this.cmbOdemTipi.FormattingEnabled = true;
            this.cmbOdemTipi.Location = new System.Drawing.Point(143, 222);
            this.cmbOdemTipi.Name = "cmbOdemTipi";
            this.cmbOdemTipi.Size = new System.Drawing.Size(148, 23);
            this.cmbOdemTipi.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ödeme Tipi";
            // 
            // cmbTipi
            // 
            this.cmbTipi.FormattingEnabled = true;
            this.cmbTipi.Location = new System.Drawing.Point(143, 139);
            this.cmbTipi.Name = "cmbTipi";
            this.cmbTipi.Size = new System.Drawing.Size(148, 23);
            this.cmbTipi.TabIndex = 17;
            // 
            // lblGiderTipi
            // 
            this.lblGiderTipi.AutoSize = true;
            this.lblGiderTipi.ForeColor = System.Drawing.Color.White;
            this.lblGiderTipi.Location = new System.Drawing.Point(47, 144);
            this.lblGiderTipi.Name = "lblGiderTipi";
            this.lblGiderTipi.Size = new System.Drawing.Size(31, 15);
            this.lblGiderTipi.TabIndex = 16;
            this.lblGiderTipi.Text = "Tipi";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(149, 75);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(143, 21);
            this.txtId.TabIndex = 15;
            this.txtId.Text = "0";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(50, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKapat.Location = new System.Drawing.Point(6, 503);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(312, 79);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Text = "Programı Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKaydet.Location = new System.Drawing.Point(6, 422);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(312, 73);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(143, 195);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(146, 21);
            this.txtTutar.TabIndex = 10;
            this.txtTutar.Text = "0";
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(142, 258);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(150, 64);
            this.txtAciklama.TabIndex = 9;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(143, 168);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(148, 21);
            this.txtCari.TabIndex = 8;
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(143, 112);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(148, 21);
            this.dtTarih.TabIndex = 7;
            // 
            // lbTarih
            // 
            this.lbTarih.AutoSize = true;
            this.lbTarih.ForeColor = System.Drawing.Color.White;
            this.lbTarih.Location = new System.Drawing.Point(44, 115);
            this.lbTarih.Name = "lbTarih";
            this.lbTarih.Size = new System.Drawing.Size(40, 15);
            this.lbTarih.TabIndex = 6;
            this.lbTarih.Text = "Tarih";
            // 
            // lbCari
            // 
            this.lbCari.AutoSize = true;
            this.lbCari.ForeColor = System.Drawing.Color.White;
            this.lbCari.Location = new System.Drawing.Point(47, 171);
            this.lbCari.Name = "lbCari";
            this.lbCari.Size = new System.Drawing.Size(33, 15);
            this.lbCari.TabIndex = 5;
            this.lbCari.Text = "Cari";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.ForeColor = System.Drawing.Color.White;
            this.lblTutar.Location = new System.Drawing.Point(42, 197);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(40, 15);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "Tutar";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.ForeColor = System.Drawing.Color.White;
            this.lblAciklama.Location = new System.Drawing.Point(44, 254);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(65, 15);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama";
            // 
            // radGider
            // 
            this.radGider.AutoSize = true;
            this.radGider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radGider.Location = new System.Drawing.Point(226, 45);
            this.radGider.Name = "radGider";
            this.radGider.Size = new System.Drawing.Size(60, 19);
            this.radGider.TabIndex = 2;
            this.radGider.TabStop = true;
            this.radGider.Text = "Gider";
            this.radGider.UseVisualStyleBackColor = true;
            this.radGider.CheckedChanged += new System.EventHandler(this.radGider_CheckedChanged);
            // 
            // radGelir
            // 
            this.radGelir.AutoSize = true;
            this.radGelir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radGelir.Location = new System.Drawing.Point(147, 45);
            this.radGelir.Name = "radGelir";
            this.radGelir.Size = new System.Drawing.Size(56, 19);
            this.radGelir.TabIndex = 1;
            this.radGelir.TabStop = true;
            this.radGelir.Text = "Gelir";
            this.radGelir.UseVisualStyleBackColor = true;
            this.radGelir.CheckedChanged += new System.EventHandler(this.radGelir_CheckedChanged);
            // 
            // lblIslemTipi
            // 
            this.lblIslemTipi.AutoSize = true;
            this.lblIslemTipi.ForeColor = System.Drawing.Color.White;
            this.lblIslemTipi.Location = new System.Drawing.Point(45, 45);
            this.lblIslemTipi.Name = "lblIslemTipi";
            this.lblIslemTipi.Size = new System.Drawing.Size(74, 15);
            this.lblIslemTipi.TabIndex = 0;
            this.lblIslemTipi.Text = "İşlem Tipi ";
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.Color.Orange;
            this.btnSorgula.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.Location = new System.Drawing.Point(1143, 12);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(116, 30);
            this.btnSorgula.TabIndex = 21;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(918, 505);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtTarih2
            // 
            this.dtTarih2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih2.Location = new System.Drawing.Point(650, 17);
            this.dtTarih2.Name = "dtTarih2";
            this.dtTarih2.Size = new System.Drawing.Size(117, 20);
            this.dtTarih2.TabIndex = 24;
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitisTarihi.ForeColor = System.Drawing.Color.White;
            this.lblBitisTarihi.Location = new System.Drawing.Point(571, 19);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(76, 15);
            this.lblBitisTarihi.TabIndex = 23;
            this.lblBitisTarihi.Text = "Bitiş Tarihi";
            // 
            // dtTarih1
            // 
            this.dtTarih1.CustomFormat = "dd-MM-yyyy";
            this.dtTarih1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih1.Location = new System.Drawing.Point(455, 18);
            this.dtTarih1.Name = "dtTarih1";
            this.dtTarih1.Size = new System.Drawing.Size(110, 20);
            this.dtTarih1.TabIndex = 24;
            this.dtTarih1.Value = DateTime.Now.AddMonths(-1);
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangicTarihi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(341, 20);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(111, 15);
            this.lblBaslangicTarihi.TabIndex = 23;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi";
            // 
            // cmbOdemeTipiSor
            // 
            this.cmbOdemeTipiSor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTipiSor.FormattingEnabled = true;
            this.cmbOdemeTipiSor.Location = new System.Drawing.Point(863, 16);
            this.cmbOdemeTipiSor.Name = "cmbOdemeTipiSor";
            this.cmbOdemeTipiSor.Size = new System.Drawing.Size(109, 21);
            this.cmbOdemeTipiSor.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(773, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ödeme Tipi";
            // 
            // lblGelirToplam
            // 
            this.lblGelirToplam.AutoSize = true;
            this.lblGelirToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelirToplam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGelirToplam.Location = new System.Drawing.Point(346, 566);
            this.lblGelirToplam.Name = "lblGelirToplam";
            this.lblGelirToplam.Size = new System.Drawing.Size(121, 17);
            this.lblGelirToplam.TabIndex = 27;
            this.lblGelirToplam.Text = "Toplam Gelir  : ";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToplam.Location = new System.Drawing.Point(346, 614);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(121, 17);
            this.lblToplam.TabIndex = 28;
            this.lblToplam.Text = "Toplam           :";
            // 
            // lblGiderToplamSonuc
            // 
            this.lblGiderToplamSonuc.AutoSize = true;
            this.lblGiderToplamSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiderToplamSonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGiderToplamSonuc.Location = new System.Drawing.Point(481, 590);
            this.lblGiderToplamSonuc.Name = "lblGiderToplamSonuc";
            this.lblGiderToplamSonuc.Size = new System.Drawing.Size(17, 17);
            this.lblGiderToplamSonuc.TabIndex = 29;
            this.lblGiderToplamSonuc.Text = "0";
            // 
            // lblGelirToplamSonuc
            // 
            this.lblGelirToplamSonuc.AutoSize = true;
            this.lblGelirToplamSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelirToplamSonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGelirToplamSonuc.Location = new System.Drawing.Point(482, 566);
            this.lblGelirToplamSonuc.Name = "lblGelirToplamSonuc";
            this.lblGelirToplamSonuc.Size = new System.Drawing.Size(17, 17);
            this.lblGelirToplamSonuc.TabIndex = 30;
            this.lblGelirToplamSonuc.Text = "0";

            // 
            // lblGiderToplam
            // 
            this.lblGiderToplam.AutoSize = true;
            this.lblGiderToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiderToplam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGiderToplam.Location = new System.Drawing.Point(346, 590);
            this.lblGiderToplam.Name = "lblGiderToplam";
            this.lblGiderToplam.Size = new System.Drawing.Size(116, 17);
            this.lblGiderToplam.TabIndex = 31;
            this.lblGiderToplam.Text = "Toplam Gider :";
            // 
            // lblToplamSonuc
            // 
            this.lblToplamSonuc.AutoSize = true;
            this.lblToplamSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToplamSonuc.Location = new System.Drawing.Point(481, 616);
            this.lblToplamSonuc.Name = "lblToplamSonuc";
            this.lblToplamSonuc.Size = new System.Drawing.Size(17, 17);
            this.lblToplamSonuc.TabIndex = 32;
            this.lblToplamSonuc.Text = "0";
            // 
            // lblKrediSonuc
            // 
            this.lblKrediSonuc.AutoSize = true;
            this.lblKrediSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKrediSonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKrediSonuc.Location = new System.Drawing.Point(716, 594);
            this.lblKrediSonuc.Name = "lblKrediSonuc";
            this.lblKrediSonuc.Size = new System.Drawing.Size(17, 17);
            this.lblKrediSonuc.TabIndex = 33;
            this.lblKrediSonuc.Text = "0";
            // 
            // lblKredi
            // 
            this.lblKredi.AutoSize = true;
            this.lblKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKredi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKredi.Location = new System.Drawing.Point(653, 593);
            this.lblKredi.Name = "lblKredi";
            this.lblKredi.Size = new System.Drawing.Size(61, 17);
            this.lblKredi.TabIndex = 34;
            this.lblKredi.Text = "Kredi  :";
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNakit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNakit.Location = new System.Drawing.Point(653, 566);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(60, 17);
            this.lblNakit.TabIndex = 35;
            this.lblNakit.Text = "Nakit  :";
            // 
            // lblNakitSonuc
            // 
            this.lblNakitSonuc.AutoSize = true;
            this.lblNakitSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNakitSonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNakitSonuc.Location = new System.Drawing.Point(716, 567);
            this.lblNakitSonuc.Name = "lblNakitSonuc";
            this.lblNakitSonuc.Size = new System.Drawing.Size(17, 17);
            this.lblNakitSonuc.TabIndex = 36;
            this.lblNakitSonuc.Text = "0";
            // 
            // frmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(1271, 653);
            this.Controls.Add(this.lblNakitSonuc);
            this.Controls.Add(this.lblNakit);
            this.Controls.Add(this.lblKredi);
            this.Controls.Add(this.lblKrediSonuc);
            this.Controls.Add(this.lblToplamSonuc);
            this.Controls.Add(this.lblGiderToplam);
            this.Controls.Add(this.lblGelirToplamSonuc);
            this.Controls.Add(this.lblGiderToplamSonuc);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblGelirToplam);
            this.Controls.Add(this.cmbOdemeTipiSor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtTarih1);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.lblBaslangicTarihi);
            this.Controls.Add(this.dtTarih2);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmGelirGider";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir Gider Takip Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTarih;
        private System.Windows.Forms.Label lbCari;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.RadioButton radGider;
        private System.Windows.Forms.RadioButton radGelir;
        private System.Windows.Forms.Label lblIslemTipi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbTipi;
        private System.Windows.Forms.Label lblGiderTipi;
        private System.Windows.Forms.ComboBox cmbOdemTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTarih2;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.ComboBox cmbOdemeTipiSor;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtTarih1;
        private System.Windows.Forms.Label lblGelirToplam;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblGiderToplamSonuc;
        private System.Windows.Forms.Label lblGelirToplamSonuc;
        private System.Windows.Forms.Label lblGiderToplam;
        private System.Windows.Forms.Label lblToplamSonuc;
        private System.Windows.Forms.Label lblKrediSonuc;
        private System.Windows.Forms.Label lblKredi;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.Label lblNakitSonuc;
    }
}

