namespace görselFinalKayaUnal
{
    partial class genel_ist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tamam1 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new görselFinalKayaUnal.covidDataSetTableAdapters.TableAdapterManager();
            this.label123 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam vaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam iyleşen hasta sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam yoğun bakım hasta sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam entübe hasta sayısı";
            // 
            // Tamam1
            // 
            this.Tamam1.Location = new System.Drawing.Point(191, 376);
            this.Tamam1.Name = "Tamam1";
            this.Tamam1.Size = new System.Drawing.Size(277, 99);
            this.Tamam1.TabIndex = 4;
            this.Tamam1.Text = "Tamam";
            this.Tamam1.UseVisualStyleBackColor = true;
            this.Tamam1.Click += new System.EventHandler(this.Tamam1_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = görselFinalKayaUnal.covidDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.vakaTableAdapter = null;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(473, 76);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(82, 25);
            this.label123.TabIndex = 5;
            this.label123.Text = "label55";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Veri Yok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Veri Yok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Veri Yok";
            // 
            // genel_ist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 524);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.Tamam1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "genel_ist";
            this.Text = "genel_ist";
            this.Load += new System.EventHandler(this.genel_ist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Tamam1;
        private covidDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}