using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30mayıs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sayacLabel.Text = "0";
            timer1.Interval = 1000; //tekrar süresi milisaniye cinsinden 1000ms = 1 sn

            progressBar1.Minimum = 0; //for (int i = 0; i <= 60; i++)
            progressBar1.Maximum = 60;
           // progressBar1.Step = 1;
            progressBar1.Value = 0;
        }

        int sayac = 0; // başlangıç değeri
       
        private void timer1_Tick(object sender, EventArgs e) // 60 defa çalışıyor ve 1000 ms de bir ( 1sn )
        {
            sayac++; // sayac = sayac + 1;
            sayacLabel.Text = sayac.ToString();

            if(sayac == 60)
            {
             
                sayac = 0;
                timer1.Stop();
                //MessageBox.Show("1 dk Doldu");
            }

            if (progressBar1.Value < 60)
            {
                progressBar1.Value += 1;
            }
        }

        private void baslaButon_Click(object sender, EventArgs e)
        {
            timer1.Start();
          //  timer1.Enabled = true;
         //  timer1.Enabled = false;
            if(progressBar1.Value == 60)
            {
                progressBar1.Value = 0; //progressBar değerini sıfırlıyoruz
            }
          
        }

        private void durButon_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
            baslaButon.Text = "Devam";
        }
    }
}
