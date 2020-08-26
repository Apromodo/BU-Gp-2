using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav2
{
    public partial class Form1 : Form
    {
        double toplam = 0;
        int dogru = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            toplam = toplam + 12.5;
            dogru = dogru + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puan ="+toplam+" Doğru sayınız= "+dogru);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            toplam = toplam + 12.5;
            dogru = dogru + 1;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            toplam = toplam + 12.5;
            dogru = dogru + 1;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            toplam = toplam + 12.5;
            dogru = dogru + 1;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            toplam = toplam + 12.5;
            dogru = dogru + 1;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            toplam = toplam + 12.5;
            dogru = dogru + 1;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            toplam = toplam + 12.5;
            dogru = dogru + 1;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            toplam = toplam + 12.5;
            dogru = dogru + 1;
        }
    }
}
