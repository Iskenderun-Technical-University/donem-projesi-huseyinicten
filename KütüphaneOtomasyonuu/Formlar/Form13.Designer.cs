﻿
namespace KütüphaneOtomasyonu
{
    partial class Form13
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KitapISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapDiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBYiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYEviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapKayitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneOtomasyonuDataSet5 = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet5();
            this.kitapTableAdapter = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet5TableAdapters.KitapTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.ceLearningTextbox1 = new KütüphaneOtomasyonu.CeLearningTextbox();
            this.rjButton1 = new KütüphaneOtomasyonu.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.ImageKey = "icons8-back-100.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(16, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 58);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-back-100.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(388, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 89);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kitap Çıkar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapISBN,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.kitapDiliDataGridViewTextBoxColumn,
            this.kitapSSayisiDataGridViewTextBoxColumn,
            this.kitapBYiliDataGridViewTextBoxColumn,
            this.kitapTurDataGridViewTextBoxColumn,
            this.kitapStokDataGridViewTextBoxColumn,
            this.kitapYazarDataGridViewTextBoxColumn,
            this.kitapYEviDataGridViewTextBoxColumn,
            this.kitapKayitTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitapBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(5, 172);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 309);
            this.dataGridView1.TabIndex = 17;
            // 
            // KitapISBN
            // 
            this.KitapISBN.DataPropertyName = "KitapISBN";
            this.KitapISBN.HeaderText = "ISBN";
            this.KitapISBN.MinimumWidth = 6;
            this.KitapISBN.Name = "KitapISBN";
            this.KitapISBN.ReadOnly = true;
            this.KitapISBN.Width = 80;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            this.kitapAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapAdiDataGridViewTextBoxColumn.Width = 130;
            // 
            // kitapDiliDataGridViewTextBoxColumn
            // 
            this.kitapDiliDataGridViewTextBoxColumn.DataPropertyName = "KitapDili";
            this.kitapDiliDataGridViewTextBoxColumn.HeaderText = "Dili";
            this.kitapDiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapDiliDataGridViewTextBoxColumn.Name = "kitapDiliDataGridViewTextBoxColumn";
            this.kitapDiliDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapDiliDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapSSayisiDataGridViewTextBoxColumn
            // 
            this.kitapSSayisiDataGridViewTextBoxColumn.DataPropertyName = "KitapSSayisi";
            this.kitapSSayisiDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayisı";
            this.kitapSSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapSSayisiDataGridViewTextBoxColumn.Name = "kitapSSayisiDataGridViewTextBoxColumn";
            this.kitapSSayisiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapSSayisiDataGridViewTextBoxColumn.Width = 110;
            // 
            // kitapBYiliDataGridViewTextBoxColumn
            // 
            this.kitapBYiliDataGridViewTextBoxColumn.DataPropertyName = "KitapBYili";
            this.kitapBYiliDataGridViewTextBoxColumn.HeaderText = "Basım Yılı";
            this.kitapBYiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapBYiliDataGridViewTextBoxColumn.Name = "kitapBYiliDataGridViewTextBoxColumn";
            this.kitapBYiliDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapBYiliDataGridViewTextBoxColumn.Width = 120;
            // 
            // kitapTurDataGridViewTextBoxColumn
            // 
            this.kitapTurDataGridViewTextBoxColumn.DataPropertyName = "KitapTur";
            this.kitapTurDataGridViewTextBoxColumn.HeaderText = "Türü";
            this.kitapTurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapTurDataGridViewTextBoxColumn.Name = "kitapTurDataGridViewTextBoxColumn";
            this.kitapTurDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapTurDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapStokDataGridViewTextBoxColumn
            // 
            this.kitapStokDataGridViewTextBoxColumn.DataPropertyName = "KitapStok";
            this.kitapStokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.kitapStokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapStokDataGridViewTextBoxColumn.Name = "kitapStokDataGridViewTextBoxColumn";
            this.kitapStokDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapStokDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapYazarDataGridViewTextBoxColumn
            // 
            this.kitapYazarDataGridViewTextBoxColumn.DataPropertyName = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.kitapYazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYazarDataGridViewTextBoxColumn.Name = "kitapYazarDataGridViewTextBoxColumn";
            this.kitapYazarDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapYazarDataGridViewTextBoxColumn.Width = 130;
            // 
            // kitapYEviDataGridViewTextBoxColumn
            // 
            this.kitapYEviDataGridViewTextBoxColumn.DataPropertyName = "KitapYEvi";
            this.kitapYEviDataGridViewTextBoxColumn.HeaderText = "Yayınevi";
            this.kitapYEviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYEviDataGridViewTextBoxColumn.Name = "kitapYEviDataGridViewTextBoxColumn";
            this.kitapYEviDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapYEviDataGridViewTextBoxColumn.Width = 130;
            // 
            // kitapKayitTarihiDataGridViewTextBoxColumn
            // 
            this.kitapKayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "KitapKayitTarihi";
            this.kitapKayitTarihiDataGridViewTextBoxColumn.HeaderText = "Kayıt Tarihi";
            this.kitapKayitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapKayitTarihiDataGridViewTextBoxColumn.Name = "kitapKayitTarihiDataGridViewTextBoxColumn";
            this.kitapKayitTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapKayitTarihiDataGridViewTextBoxColumn.Width = 120;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kutuphaneOtomasyonuDataSet5;
            // 
            // kutuphaneOtomasyonuDataSet5
            // 
            this.kutuphaneOtomasyonuDataSet5.DataSetName = "KutuphaneOtomasyonuDataSet5";
            this.kutuphaneOtomasyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "ISBN ile Arama ";
            // 
            // ceLearningTextbox1
            // 
            this.ceLearningTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.ceLearningTextbox1.Br = System.Drawing.Color.White;
            this.ceLearningTextbox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceLearningTextbox1.ForeColor = System.Drawing.Color.Black;
            this.ceLearningTextbox1.Location = new System.Drawing.Point(235, 119);
            this.ceLearningTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ceLearningTextbox1.Name = "ceLearningTextbox1";
            this.ceLearningTextbox1.Size = new System.Drawing.Size(281, 34);
            this.ceLearningTextbox1.TabIndex = 22;
            this.ceLearningTextbox1.TextChanged += new System.EventHandler(this.ceLearningTextbox1_TextChanged_1);
            this.ceLearningTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ceLearningTextbox1_KeyPress);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.DarkRed;
            this.rjButton1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(919, 112);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(277, 49);
            this.rjButton1.TabIndex = 21;
            this.rjButton1.Text = "Kitabı Çıkar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1212, 513);
            this.Controls.Add(this.ceLearningTextbox1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Çıkar";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KutuphaneOtomasyonuDataSet5 kutuphaneOtomasyonuDataSet5;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KutuphaneOtomasyonuDataSet5TableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.Label label2;
        private RJButton rjButton1;
        private CeLearningTextbox ceLearningTextbox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapDiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapSSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBYiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapStokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYEviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapKayitTarihiDataGridViewTextBoxColumn;
    }
}