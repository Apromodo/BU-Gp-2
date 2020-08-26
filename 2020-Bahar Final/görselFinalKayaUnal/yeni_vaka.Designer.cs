namespace görselFinalKayaUnal
{
    partial class yeni_vaka
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
            this.ilSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vakaSay = new System.Windows.Forms.TextBox();
            this.yeniİyles = new System.Windows.Forms.TextBox();
            this.yeniYogunBakım = new System.Windows.Forms.TextBox();
            this.yeniEntb = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ilSec
            // 
            this.ilSec.FormattingEnabled = true;
            this.ilSec.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir"});
            this.ilSec.Location = new System.Drawing.Point(485, 48);
            this.ilSec.Name = "ilSec";
            this.ilSec.Size = new System.Drawing.Size(121, 33);
            this.ilSec.TabIndex = 0;
            this.ilSec.SelectedIndexChanged += new System.EventHandler(this.ilSec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Vaka Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni İyleşen Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yeni Yoğun Bakım Hasta Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yeni Entübe Hasta Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "tarih";
            // 
            // vakaSay
            // 
            this.vakaSay.Location = new System.Drawing.Point(469, 120);
            this.vakaSay.Name = "vakaSay";
            this.vakaSay.Size = new System.Drawing.Size(161, 31);
            this.vakaSay.TabIndex = 6;
            this.vakaSay.TextChanged += new System.EventHandler(this.vakaSay_TextChanged);
            // 
            // yeniİyles
            // 
            this.yeniİyles.Location = new System.Drawing.Point(469, 195);
            this.yeniİyles.Name = "yeniİyles";
            this.yeniİyles.Size = new System.Drawing.Size(161, 31);
            this.yeniİyles.TabIndex = 7;
            this.yeniİyles.TextChanged += new System.EventHandler(this.yeniİyles_TextChanged);
            // 
            // yeniYogunBakım
            // 
            this.yeniYogunBakım.Location = new System.Drawing.Point(469, 279);
            this.yeniYogunBakım.Name = "yeniYogunBakım";
            this.yeniYogunBakım.Size = new System.Drawing.Size(161, 31);
            this.yeniYogunBakım.TabIndex = 8;
            this.yeniYogunBakım.TextChanged += new System.EventHandler(this.yeniYogunBakım_TextChanged);
            // 
            // yeniEntb
            // 
            this.yeniEntb.Location = new System.Drawing.Point(469, 361);
            this.yeniEntb.Name = "yeniEntb";
            this.yeniEntb.Size = new System.Drawing.Size(161, 31);
            this.yeniEntb.TabIndex = 9;
            this.yeniEntb.TextChanged += new System.EventHandler(this.yeniEntb_TextChanged);
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(363, 442);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(386, 31);
            this.tarih.TabIndex = 10;
            this.tarih.ValueChanged += new System.EventHandler(this.tarih_ValueChanged);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(715, 172);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(404, 150);
            this.ekle.TabIndex = 11;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // yeni_vaka
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 672);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.yeniEntb);
            this.Controls.Add(this.yeniYogunBakım);
            this.Controls.Add(this.yeniİyles);
            this.Controls.Add(this.vakaSay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ilSec);
            this.Name = "yeni_vaka";
            this.Text = "yeni_vaka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ilSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vakaSay;
        private System.Windows.Forms.TextBox yeniİyles;
        private System.Windows.Forms.TextBox yeniYogunBakım;
        private System.Windows.Forms.TextBox yeniEntb;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Button ekle;
    }
}