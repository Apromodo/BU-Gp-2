namespace _30mayıs
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
            this.sayacLabel = new System.Windows.Forms.Label();
            this.baslaButon = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.durButon = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // sayacLabel
            // 
            this.sayacLabel.AutoSize = true;
            this.sayacLabel.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayacLabel.Location = new System.Drawing.Point(124, 29);
            this.sayacLabel.Name = "sayacLabel";
            this.sayacLabel.Size = new System.Drawing.Size(0, 29);
            this.sayacLabel.TabIndex = 0;
            // 
            // baslaButon
            // 
            this.baslaButon.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslaButon.Location = new System.Drawing.Point(33, 86);
            this.baslaButon.Name = "baslaButon";
            this.baslaButon.Size = new System.Drawing.Size(92, 46);
            this.baslaButon.TabIndex = 1;
            this.baslaButon.Text = "Başla";
            this.baslaButon.UseVisualStyleBackColor = true;
            this.baslaButon.Click += new System.EventHandler(this.baslaButon_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // durButon
            // 
            this.durButon.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durButon.Location = new System.Drawing.Point(147, 86);
            this.durButon.Name = "durButon";
            this.durButon.Size = new System.Drawing.Size(93, 46);
            this.durButon.TabIndex = 2;
            this.durButon.Text = "Durdur";
            this.durButon.UseVisualStyleBackColor = true;
            this.durButon.Click += new System.EventHandler(this.durButon_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 164);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(206, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 200);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.durButon);
            this.Controls.Add(this.baslaButon);
            this.Controls.Add(this.sayacLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayacLabel;
        private System.Windows.Forms.Button baslaButon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button durButon;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

