namespace bitkisulamason
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
            this.components = new System.ComponentModel.Container();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtSulamaSikligi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTabloGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sulamaSikligiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sulamaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birSonrakiSulamaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitkilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bitkisistemiDataSet = new bitkisulamason.bitkisistemiDataSet();
            this.bitkilerTableAdapter = new bitkisulamason.bitkisistemiDataSetTableAdapters.BitkilerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblSonrakiSulamaTarihi = new System.Windows.Forms.Label();
            this.btnSulamaYap = new System.Windows.Forms.Button();
            this.txtBitkiId = new System.Windows.Forms.TextBox();
            this.lblBitkiId = new System.Windows.Forms.Label();
            this.sulamaHatirlatmaTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitkilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitkisistemiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(134)))));
            this.txtAd.Location = new System.Drawing.Point(72, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtTur
            // 
            this.txtTur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(134)))));
            this.txtTur.Location = new System.Drawing.Point(208, 18);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(100, 20);
            this.txtTur.TabIndex = 1;
            this.txtTur.TextChanged += new System.EventHandler(this.txtTur_TextChanged);
            // 
            // txtSulamaSikligi
            // 
            this.txtSulamaSikligi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(134)))));
            this.txtSulamaSikligi.Location = new System.Drawing.Point(72, 50);
            this.txtSulamaSikligi.Name = "txtSulamaSikligi";
            this.txtSulamaSikligi.Size = new System.Drawing.Size(100, 20);
            this.txtSulamaSikligi.TabIndex = 2;
            this.txtSulamaSikligi.TextChanged += new System.EventHandler(this.txtSulamaSikligi_TextChanged_1);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(112)))));
            this.btnEkle.Location = new System.Drawing.Point(63, 76);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Bitkiyi Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTabloGuncelle
            // 
            this.btnTabloGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(112)))));
            this.btnTabloGuncelle.Location = new System.Drawing.Point(535, 103);
            this.btnTabloGuncelle.Name = "btnTabloGuncelle";
            this.btnTabloGuncelle.Size = new System.Drawing.Size(115, 23);
            this.btnTabloGuncelle.TabIndex = 4;
            this.btnTabloGuncelle.Text = "Tabloyu Güncelle";
            this.btnTabloGuncelle.UseVisualStyleBackColor = false;
            this.btnTabloGuncelle.Click += new System.EventHandler(this.btnTabloGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(112)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.sulamaSikligiDataGridViewTextBoxColumn,
            this.sulamaTarihiDataGridViewTextBoxColumn,
            this.birSonrakiSulamaTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bitkilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 171);
            this.dataGridView1.TabIndex = 5;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "Tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "Tur";
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            // 
            // sulamaSikligiDataGridViewTextBoxColumn
            // 
            this.sulamaSikligiDataGridViewTextBoxColumn.DataPropertyName = "SulamaSikligi";
            this.sulamaSikligiDataGridViewTextBoxColumn.HeaderText = "SulamaSikligi";
            this.sulamaSikligiDataGridViewTextBoxColumn.Name = "sulamaSikligiDataGridViewTextBoxColumn";
            // 
            // sulamaTarihiDataGridViewTextBoxColumn
            // 
            this.sulamaTarihiDataGridViewTextBoxColumn.DataPropertyName = "SulamaTarihi";
            this.sulamaTarihiDataGridViewTextBoxColumn.HeaderText = "SulamaTarihi";
            this.sulamaTarihiDataGridViewTextBoxColumn.Name = "sulamaTarihiDataGridViewTextBoxColumn";
            // 
            // birSonrakiSulamaTarihiDataGridViewTextBoxColumn
            // 
            this.birSonrakiSulamaTarihiDataGridViewTextBoxColumn.DataPropertyName = "BirSonrakiSulamaTarihi";
            this.birSonrakiSulamaTarihiDataGridViewTextBoxColumn.HeaderText = "BirSonrakiSulamaTarihi";
            this.birSonrakiSulamaTarihiDataGridViewTextBoxColumn.Name = "birSonrakiSulamaTarihiDataGridViewTextBoxColumn";
            // 
            // bitkilerBindingSource
            // 
            this.bitkilerBindingSource.DataMember = "Bitkiler";
            this.bitkilerBindingSource.DataSource = this.bitkisistemiDataSet;
            // 
            // bitkisistemiDataSet
            // 
            this.bitkisistemiDataSet.DataSetName = "bitkisistemiDataSet";
            this.bitkisistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitkilerTableAdapter
            // 
            this.bitkilerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(178, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tür";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(-4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sulama sıklığı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(112)))));
            this.btnSil.Location = new System.Drawing.Point(2, 103);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Seçili Bitkiyi Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(112)))));
            this.btnGuncelle.Location = new System.Drawing.Point(127, 103);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 23);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Seçili Bitkiyi güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblSonrakiSulamaTarihi
            // 
            this.lblSonrakiSulamaTarihi.AutoSize = true;
            this.lblSonrakiSulamaTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblSonrakiSulamaTarihi.Location = new System.Drawing.Point(205, 53);
            this.lblSonrakiSulamaTarihi.Name = "lblSonrakiSulamaTarihi";
            this.lblSonrakiSulamaTarihi.Size = new System.Drawing.Size(70, 13);
            this.lblSonrakiSulamaTarihi.TabIndex = 13;
            this.lblSonrakiSulamaTarihi.Text = "Sulama sıklığı";
            this.lblSonrakiSulamaTarihi.Click += new System.EventHandler(this.lblSonrakiSulamaTarihi_Click);
            // 
            // btnSulamaYap
            // 
            this.btnSulamaYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(112)))));
            this.btnSulamaYap.Location = new System.Drawing.Point(423, 76);
            this.btnSulamaYap.Name = "btnSulamaYap";
            this.btnSulamaYap.Size = new System.Drawing.Size(102, 23);
            this.btnSulamaYap.TabIndex = 14;
            this.btnSulamaYap.Text = "Sulama yap";
            this.btnSulamaYap.UseVisualStyleBackColor = false;
            this.btnSulamaYap.Click += new System.EventHandler(this.btnSulamaYap_Click);
            // 
            // txtBitkiId
            // 
            this.txtBitkiId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(134)))));
            this.txtBitkiId.Location = new System.Drawing.Point(423, 46);
            this.txtBitkiId.Name = "txtBitkiId";
            this.txtBitkiId.Size = new System.Drawing.Size(100, 20);
            this.txtBitkiId.TabIndex = 15;
            // 
            // lblBitkiId
            // 
            this.lblBitkiId.AutoSize = true;
            this.lblBitkiId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblBitkiId.Location = new System.Drawing.Point(403, 25);
            this.lblBitkiId.Name = "lblBitkiId";
            this.lblBitkiId.Size = new System.Drawing.Size(141, 13);
            this.lblBitkiId.TabIndex = 16;
            this.lblBitkiId.Text = "Sulama yapmak istediğiniz id";
            this.lblBitkiId.Click += new System.EventHandler(this.lblBitkiId_Click);
            // 
            // sulamaHatirlatmaTimer
            // 
            this.sulamaHatirlatmaTimer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(654, 303);
            this.Controls.Add(this.lblBitkiId);
            this.Controls.Add(this.txtBitkiId);
            this.Controls.Add(this.btnSulamaYap);
            this.Controls.Add(this.lblSonrakiSulamaTarihi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTabloGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSulamaSikligi);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitkilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitkisistemiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtSulamaSikligi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTabloGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bitkisistemiDataSet bitkisistemiDataSet;
        private System.Windows.Forms.BindingSource bitkilerBindingSource;
        private bitkisistemiDataSetTableAdapters.BitkilerTableAdapter bitkilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sulamaSikligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sulamaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birSonrakiSulamaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblSonrakiSulamaTarihi;
        private System.Windows.Forms.Button btnSulamaYap;
        private System.Windows.Forms.TextBox txtBitkiId;
        private System.Windows.Forms.Label lblBitkiId;
        private System.Windows.Forms.Timer sulamaHatirlatmaTimer;
    }
}

