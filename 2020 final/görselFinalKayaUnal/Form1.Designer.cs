namespace görselFinalKayaUnal
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
            this.vakaEkle = new System.Windows.Forms.Button();
            this.genelGter = new System.Windows.Forms.Button();
            this.veriDzn = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vakasayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iyilesensayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yogunbakımDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vakaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.covidDataSet = new görselFinalKayaUnal.covidDataSet();
            this.vakaTableAdapter = new görselFinalKayaUnal.covidDataSetTableAdapters.vakaTableAdapter();
            this.güncel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vakaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vakaEkle
            // 
            this.vakaEkle.Location = new System.Drawing.Point(73, 58);
            this.vakaEkle.Name = "vakaEkle";
            this.vakaEkle.Size = new System.Drawing.Size(550, 136);
            this.vakaEkle.TabIndex = 0;
            this.vakaEkle.Text = "Yeni vaka ekle";
            this.vakaEkle.UseVisualStyleBackColor = true;
            this.vakaEkle.Click += new System.EventHandler(this.vakaEkle_Click);
            // 
            // genelGter
            // 
            this.genelGter.Location = new System.Drawing.Point(73, 256);
            this.genelGter.Name = "genelGter";
            this.genelGter.Size = new System.Drawing.Size(550, 76);
            this.genelGter.TabIndex = 1;
            this.genelGter.Text = "Genel istatistik göster";
            this.genelGter.UseVisualStyleBackColor = true;
            this.genelGter.Click += new System.EventHandler(this.genelGter_Click);
            // 
            // veriDzn
            // 
            this.veriDzn.Location = new System.Drawing.Point(73, 426);
            this.veriDzn.Name = "veriDzn";
            this.veriDzn.Size = new System.Drawing.Size(228, 100);
            this.veriDzn.TabIndex = 2;
            this.veriDzn.Text = "verileri düzenle";
            this.veriDzn.UseVisualStyleBackColor = true;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(395, 426);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(228, 100);
            this.sil.TabIndex = 3;
            this.sil.Text = "sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ilDataGridViewTextBoxColumn,
            this.vakasayısıDataGridViewTextBoxColumn,
            this.iyilesensayısıDataGridViewTextBoxColumn,
            this.yogunbakımDataGridViewTextBoxColumn,
            this.entubeDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vakaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(725, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 740);
            this.dataGridView1.TabIndex = 4;
            // 
            // ilDataGridViewTextBoxColumn
            // 
            this.ilDataGridViewTextBoxColumn.DataPropertyName = "il";
            this.ilDataGridViewTextBoxColumn.HeaderText = "il";
            this.ilDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ilDataGridViewTextBoxColumn.Name = "ilDataGridViewTextBoxColumn";
            this.ilDataGridViewTextBoxColumn.Width = 200;
            // 
            // vakasayısıDataGridViewTextBoxColumn
            // 
            this.vakasayısıDataGridViewTextBoxColumn.DataPropertyName = "vaka_sayısı";
            this.vakasayısıDataGridViewTextBoxColumn.HeaderText = "vaka_sayısı";
            this.vakasayısıDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.vakasayısıDataGridViewTextBoxColumn.Name = "vakasayısıDataGridViewTextBoxColumn";
            this.vakasayısıDataGridViewTextBoxColumn.Width = 200;
            // 
            // iyilesensayısıDataGridViewTextBoxColumn
            // 
            this.iyilesensayısıDataGridViewTextBoxColumn.DataPropertyName = "iyilesen_sayısı";
            this.iyilesensayısıDataGridViewTextBoxColumn.HeaderText = "iyilesen_sayısı";
            this.iyilesensayısıDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iyilesensayısıDataGridViewTextBoxColumn.Name = "iyilesensayısıDataGridViewTextBoxColumn";
            this.iyilesensayısıDataGridViewTextBoxColumn.Width = 200;
            // 
            // yogunbakımDataGridViewTextBoxColumn
            // 
            this.yogunbakımDataGridViewTextBoxColumn.DataPropertyName = "yogun_bakım";
            this.yogunbakımDataGridViewTextBoxColumn.HeaderText = "yogun_bakım";
            this.yogunbakımDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.yogunbakımDataGridViewTextBoxColumn.Name = "yogunbakımDataGridViewTextBoxColumn";
            this.yogunbakımDataGridViewTextBoxColumn.Width = 200;
            // 
            // entubeDataGridViewTextBoxColumn
            // 
            this.entubeDataGridViewTextBoxColumn.DataPropertyName = "entube";
            this.entubeDataGridViewTextBoxColumn.HeaderText = "entube";
            this.entubeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.entubeDataGridViewTextBoxColumn.Name = "entubeDataGridViewTextBoxColumn";
            this.entubeDataGridViewTextBoxColumn.Width = 200;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 200;
            // 
            // vakaBindingSource
            // 
            this.vakaBindingSource.DataMember = "vaka";
            this.vakaBindingSource.DataSource = this.covidDataSet;
            // 
            // covidDataSet
            // 
            this.covidDataSet.DataSetName = "covidDataSet";
            this.covidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vakaTableAdapter
            // 
            this.vakaTableAdapter.ClearBeforeFill = true;
            // 
            // güncel
            // 
            this.güncel.Location = new System.Drawing.Point(395, 701);
            this.güncel.Name = "güncel";
            this.güncel.Size = new System.Drawing.Size(243, 97);
            this.güncel.TabIndex = 5;
            this.güncel.Text = "günelle";
            this.güncel.UseVisualStyleBackColor = true;
            this.güncel.Click += new System.EventHandler(this.güncel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1952, 960);
            this.Controls.Add(this.güncel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.veriDzn);
            this.Controls.Add(this.genelGter);
            this.Controls.Add(this.vakaEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vakaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vakaEkle;
        private System.Windows.Forms.Button genelGter;
        private System.Windows.Forms.Button veriDzn;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private covidDataSet covidDataSet;
        private System.Windows.Forms.BindingSource vakaBindingSource;
        private covidDataSetTableAdapters.vakaTableAdapter vakaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vakasayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iyilesensayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yogunbakımDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button güncel;
    }
}

