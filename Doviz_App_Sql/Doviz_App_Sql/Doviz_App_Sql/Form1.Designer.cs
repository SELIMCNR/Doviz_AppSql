
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace Doviz_App_Sql
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_AlışYap = new System.Windows.Forms.Button();
            this.Btn_SatışYap = new System.Windows.Forms.Button();
            this.Txt_AlışTutar = new System.Windows.Forms.TextBox();
            this.Txt_SatışTutar = new System.Windows.Forms.TextBox();
            this.Txt_Miktar = new System.Windows.Forms.TextBox();
            this.Txt_DovizSatış = new System.Windows.Forms.TextBox();
            this.Txt_DovizAlış = new System.Windows.Forms.TextBox();
            this.Txt_Musteri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Data_SatılanDoviz = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Data_AlınanDoviz = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblToplamAl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_ToplamSat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DövizSeçCombo = new System.Windows.Forms.ComboBox();
            this.doviz_appDataSet = new Doviz_App_Sql.doviz_appDataSet();
            this.alınanDovizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alınanDovizTableAdapter = new Doviz_App_Sql.doviz_appDataSetTableAdapters.AlınanDovizTableAdapter();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dovizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doviz_appDataSet1 = new Doviz_App_Sql.doviz_appDataSet1();
            this.satılanDovizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satılanDovizTableAdapter = new Doviz_App_Sql.doviz_appDataSet1TableAdapters.SatılanDovizTableAdapter();
            this.isimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dovizDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOVİZAD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.satıştarih = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_SatılanDoviz)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_AlınanDoviz)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doviz_appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alınanDovizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doviz_appDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satılanDovizBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DOVİZAD);
            this.groupBox1.Controls.Add(this.Btn_AlışYap);
            this.groupBox1.Controls.Add(this.Btn_SatışYap);
            this.groupBox1.Controls.Add(this.Txt_AlışTutar);
            this.groupBox1.Controls.Add(this.Txt_SatışTutar);
            this.groupBox1.Controls.Add(this.Txt_Miktar);
            this.groupBox1.Controls.Add(this.satıştarih);
            this.groupBox1.Controls.Add(this.Txt_DovizSatış);
            this.groupBox1.Controls.Add(this.Txt_DovizAlış);
            this.groupBox1.Controls.Add(this.Txt_Musteri);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Döviz Kayıt";
            // 
            // Btn_AlışYap
            // 
            this.Btn_AlışYap.BackColor = System.Drawing.Color.YellowGreen;
            this.Btn_AlışYap.Location = new System.Drawing.Point(187, 249);
            this.Btn_AlışYap.Name = "Btn_AlışYap";
            this.Btn_AlışYap.Size = new System.Drawing.Size(93, 20);
            this.Btn_AlışYap.TabIndex = 2;
            this.Btn_AlışYap.Text = "Alış Yap";
            this.Btn_AlışYap.UseVisualStyleBackColor = false;
            this.Btn_AlışYap.Click += new System.EventHandler(this.Btn_AlışYap_Click);
            // 
            // Btn_SatışYap
            // 
            this.Btn_SatışYap.BackColor = System.Drawing.Color.Red;
            this.Btn_SatışYap.Location = new System.Drawing.Point(82, 249);
            this.Btn_SatışYap.Name = "Btn_SatışYap";
            this.Btn_SatışYap.Size = new System.Drawing.Size(99, 20);
            this.Btn_SatışYap.TabIndex = 2;
            this.Btn_SatışYap.Text = "Satış Yap";
            this.Btn_SatışYap.UseVisualStyleBackColor = false;
            this.Btn_SatışYap.Click += new System.EventHandler(this.Btn_SatışYap_Click);
            // 
            // Txt_AlışTutar
            // 
            this.Txt_AlışTutar.Location = new System.Drawing.Point(187, 224);
            this.Txt_AlışTutar.Name = "Txt_AlışTutar";
            this.Txt_AlışTutar.Size = new System.Drawing.Size(94, 20);
            this.Txt_AlışTutar.TabIndex = 1;
            // 
            // Txt_SatışTutar
            // 
            this.Txt_SatışTutar.Location = new System.Drawing.Point(82, 224);
            this.Txt_SatışTutar.Name = "Txt_SatışTutar";
            this.Txt_SatışTutar.Size = new System.Drawing.Size(100, 20);
            this.Txt_SatışTutar.TabIndex = 1;
            // 
            // Txt_Miktar
            // 
            this.Txt_Miktar.Location = new System.Drawing.Point(82, 194);
            this.Txt_Miktar.Name = "Txt_Miktar";
            this.Txt_Miktar.Size = new System.Drawing.Size(197, 20);
            this.Txt_Miktar.TabIndex = 1;
            this.Txt_Miktar.TextChanged += new System.EventHandler(this.Txt_Miktar_TextChanged_1);
            // 
            // Txt_DovizSatış
            // 
            this.Txt_DovizSatış.Location = new System.Drawing.Point(82, 134);
            this.Txt_DovizSatış.Name = "Txt_DovizSatış";
            this.Txt_DovizSatış.Size = new System.Drawing.Size(197, 20);
            this.Txt_DovizSatış.TabIndex = 1;
            this.Txt_DovizSatış.TextChanged += new System.EventHandler(this.Txt_DovizSatis_TextChanged);
            // 
            // Txt_DovizAlış
            // 
            this.Txt_DovizAlış.Location = new System.Drawing.Point(84, 97);
            this.Txt_DovizAlış.Name = "Txt_DovizAlış";
            this.Txt_DovizAlış.Size = new System.Drawing.Size(197, 20);
            this.Txt_DovizAlış.TabIndex = 1;
            this.Txt_DovizAlış.TextChanged += new System.EventHandler(this.Txt_DovizAlis_TextChanged);
            // 
            // Txt_Musteri
            // 
            this.Txt_Musteri.Location = new System.Drawing.Point(84, 28);
            this.Txt_Musteri.Name = "Txt_Musteri";
            this.Txt_Musteri.Size = new System.Drawing.Size(197, 20);
            this.Txt_Musteri.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tutar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Miktar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Döviz Satışı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Döviz Alışı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Döviz Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(326, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Döviz Tablo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Data_SatılanDoviz);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(5, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(528, 143);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Satılan Döviz";
            // 
            // Data_SatılanDoviz
            // 
            this.Data_SatılanDoviz.AutoGenerateColumns = false;
            this.Data_SatılanDoviz.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Data_SatılanDoviz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Data_SatılanDoviz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_SatılanDoviz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isimDataGridViewTextBoxColumn1,
            this.dovizDataGridViewTextBoxColumn1,
            this.kurDataGridViewTextBoxColumn1,
            this.miktarDataGridViewTextBoxColumn1,
            this.tarihDataGridViewTextBoxColumn1});
            this.Data_SatılanDoviz.DataSource = this.satılanDovizBindingSource;
            this.Data_SatılanDoviz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_SatılanDoviz.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Data_SatılanDoviz.Location = new System.Drawing.Point(3, 16);
            this.Data_SatılanDoviz.Name = "Data_SatılanDoviz";
            this.Data_SatılanDoviz.Size = new System.Drawing.Size(522, 124);
            this.Data_SatılanDoviz.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Data_AlınanDoviz);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(5, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 115);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alınan Döviz";
            // 
            // Data_AlınanDoviz
            // 
            this.Data_AlınanDoviz.AutoGenerateColumns = false;
            this.Data_AlınanDoviz.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Data_AlınanDoviz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Data_AlınanDoviz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_AlınanDoviz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isimDataGridViewTextBoxColumn,
            this.dovizDataGridViewTextBoxColumn,
            this.kurDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.Data_AlınanDoviz.DataSource = this.alınanDovizBindingSource;
            this.Data_AlınanDoviz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_AlınanDoviz.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Data_AlınanDoviz.Location = new System.Drawing.Point(3, 16);
            this.Data_AlınanDoviz.Name = "Data_AlınanDoviz";
            this.Data_AlınanDoviz.Size = new System.Drawing.Size(522, 96);
            this.Data_AlınanDoviz.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.LblToplamAl);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Lbl_ToplamSat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.DövizSeçCombo);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(6, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(746, 87);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa";
            // 
            // LblToplamAl
            // 
            this.LblToplamAl.AutoSize = true;
            this.LblToplamAl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LblToplamAl.Location = new System.Drawing.Point(519, 53);
            this.LblToplamAl.Name = "LblToplamAl";
            this.LblToplamAl.Size = new System.Drawing.Size(19, 21);
            this.LblToplamAl.TabIndex = 1;
            this.LblToplamAl.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(519, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Toplam Alınan";
            // 
            // Lbl_ToplamSat
            // 
            this.Lbl_ToplamSat.AutoSize = true;
            this.Lbl_ToplamSat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Lbl_ToplamSat.Location = new System.Drawing.Point(224, 55);
            this.Lbl_ToplamSat.Name = "Lbl_ToplamSat";
            this.Lbl_ToplamSat.Size = new System.Drawing.Size(19, 21);
            this.Lbl_ToplamSat.TabIndex = 1;
            this.Lbl_ToplamSat.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(224, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Toplam Satılan";
            // 
            // DövizSeçCombo
            // 
            this.DövizSeçCombo.FormattingEnabled = true;
            this.DövizSeçCombo.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "AUD"});
            this.DövizSeçCombo.Location = new System.Drawing.Point(27, 33);
            this.DövizSeçCombo.Name = "DövizSeçCombo";
            this.DövizSeçCombo.Size = new System.Drawing.Size(104, 21);
            this.DövizSeçCombo.TabIndex = 0;
            this.DövizSeçCombo.SelectedIndexChanged += new System.EventHandler(this.DövizSeçCombo_SelectedIndexChanged);
            // 
            // doviz_appDataSet
            // 
            this.doviz_appDataSet.DataSetName = "doviz_appDataSet";
            this.doviz_appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alınanDovizBindingSource
            // 
            this.alınanDovizBindingSource.DataMember = "AlınanDoviz";
            this.alınanDovizBindingSource.DataSource = this.doviz_appDataSet;
            // 
            // alınanDovizTableAdapter
            // 
            this.alınanDovizTableAdapter.ClearBeforeFill = true;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "İsim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "İsim";
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            // 
            // dovizDataGridViewTextBoxColumn
            // 
            this.dovizDataGridViewTextBoxColumn.DataPropertyName = "Doviz";
            this.dovizDataGridViewTextBoxColumn.HeaderText = "Doviz";
            this.dovizDataGridViewTextBoxColumn.Name = "dovizDataGridViewTextBoxColumn";
            // 
            // kurDataGridViewTextBoxColumn
            // 
            this.kurDataGridViewTextBoxColumn.DataPropertyName = "Kur";
            this.kurDataGridViewTextBoxColumn.HeaderText = "Kur";
            this.kurDataGridViewTextBoxColumn.Name = "kurDataGridViewTextBoxColumn";
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // doviz_appDataSet1
            // 
            this.doviz_appDataSet1.DataSetName = "doviz_appDataSet1";
            this.doviz_appDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satılanDovizBindingSource
            // 
            this.satılanDovizBindingSource.DataMember = "SatılanDoviz";
            this.satılanDovizBindingSource.DataSource = this.doviz_appDataSet1;
            // 
            // satılanDovizTableAdapter
            // 
            this.satılanDovizTableAdapter.ClearBeforeFill = true;
            // 
            // isimDataGridViewTextBoxColumn1
            // 
            this.isimDataGridViewTextBoxColumn1.DataPropertyName = "İsim";
            this.isimDataGridViewTextBoxColumn1.HeaderText = "İsim";
            this.isimDataGridViewTextBoxColumn1.Name = "isimDataGridViewTextBoxColumn1";
            // 
            // dovizDataGridViewTextBoxColumn1
            // 
            this.dovizDataGridViewTextBoxColumn1.DataPropertyName = "Doviz";
            this.dovizDataGridViewTextBoxColumn1.HeaderText = "Doviz";
            this.dovizDataGridViewTextBoxColumn1.Name = "dovizDataGridViewTextBoxColumn1";
            // 
            // kurDataGridViewTextBoxColumn1
            // 
            this.kurDataGridViewTextBoxColumn1.DataPropertyName = "Kur";
            this.kurDataGridViewTextBoxColumn1.HeaderText = "Kur";
            this.kurDataGridViewTextBoxColumn1.Name = "kurDataGridViewTextBoxColumn1";
            // 
            // miktarDataGridViewTextBoxColumn1
            // 
            this.miktarDataGridViewTextBoxColumn1.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn1.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn1.Name = "miktarDataGridViewTextBoxColumn1";
            // 
            // tarihDataGridViewTextBoxColumn1
            // 
            this.tarihDataGridViewTextBoxColumn1.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn1.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn1.Name = "tarihDataGridViewTextBoxColumn1";
            // 
            // DOVİZAD
            // 
            this.DOVİZAD.FormattingEnabled = true;
            this.DOVİZAD.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "AUD",
            "GBP"});
            this.DOVİZAD.Location = new System.Drawing.Point(82, 62);
            this.DOVİZAD.Name = "DOVİZAD";
            this.DOVİZAD.Size = new System.Drawing.Size(197, 21);
            this.DOVİZAD.TabIndex = 3;
            this.DOVİZAD.SelectedIndexChanged += new System.EventHandler(this.DOVİZAD_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tarih";
            // 
            // satıştarih
            // 
            this.satıştarih.Location = new System.Drawing.Point(82, 160);
            this.satıştarih.Name = "satıştarih";
            this.satıştarih.Size = new System.Drawing.Size(197, 20);
            this.satıştarih.TabIndex = 1;
            this.satıştarih.TextChanged += new System.EventHandler(this.Txt_DovizSatis_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doviz_App_Sql.Properties.Resources.gorsel;
            this.ClientSize = new System.Drawing.Size(849, 391);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_SatılanDoviz)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_AlınanDoviz)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doviz_appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alınanDovizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doviz_appDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satılanDovizBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox Txt_Musteri;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Txt_Miktar;
        private TextBox Txt_DovizSatış;
        private TextBox Txt_DovizAlış;
        private TextBox Txt_SatışTutar;
        private TextBox Txt_AlışTutar;
        private Button Btn_AlışYap;
        private Button Btn_SatışYap;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Label LblToplamAl;
        private Label label9;
        private Label Lbl_ToplamSat;
        private Label label7;
        private ComboBox DövizSeçCombo;
        private DataGridView Data_SatılanDoviz;
        private DataGridView Data_AlınanDoviz;
        private doviz_appDataSet doviz_appDataSet;
        private BindingSource alınanDovizBindingSource;
        private doviz_appDataSetTableAdapters.AlınanDovizTableAdapter alınanDovizTableAdapter;
        private DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dovizDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kurDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private doviz_appDataSet1 doviz_appDataSet1;
        private BindingSource satılanDovizBindingSource;
        private doviz_appDataSet1TableAdapters.SatılanDovizTableAdapter satılanDovizTableAdapter;
        private DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dovizDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn kurDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn1;
        private ComboBox DOVİZAD;
        private TextBox satıştarih;
        private Label label8;
    }
}
