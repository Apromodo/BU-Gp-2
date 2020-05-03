﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sınav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7ASJLBU;Initial Catalog=sinav;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter adapterr;

        void getir()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7ASJLBU;Initial Catalog=sinav;Integrated Security=True");
            baglanti.Open();
            adapterr = new SqlDataAdapter("SELECT * FROM isci", baglanti);
            DataTable tablo = new DataTable();
            adapterr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
             textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
             textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
             comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
             textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
             textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
             textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM isci WHERE iscino=@iscino";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@iscino", textBox1.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            getir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO isci(isim, meslek, b_tarihi, maas, yas) VALUES (@isim, @meslek, @b_tarihi, @maas, @yas)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@isim", textBox2.Text);
            komut.Parameters.AddWithValue("@meslek", comboBox1.Text);
            komut.Parameters.AddWithValue("@b_tarihi", textBox3.Text);
            komut.Parameters.AddWithValue("@maas", textBox4.Text);
            komut.Parameters.AddWithValue("@yas", textBox5.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            getir();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE isci SET isim=@isim, meslek=@meslek, b_tarihi=@b_tarihi, maas=@maas, yas=@yas WHERE iscino=@iscino";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@iscino", textBox1.Text);
            komut.Parameters.AddWithValue("@isim", textBox2.Text);
            komut.Parameters.AddWithValue("@meslek", comboBox1.Text);
            komut.Parameters.AddWithValue("@b_tarihi", textBox3.Text);
            komut.Parameters.AddWithValue("@maas", textBox4.Text);
            komut.Parameters.AddWithValue("@yas", textBox5.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            getir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int maass=Convert.ToInt32(textBox4.Text);
            int alinacakyüzde = Convert.ToInt32(textBox6.Text);
            int zam = maass * alinacakyüzde / 100;
            int zamli = maass + zam;
            textBox4.Text = Convert.ToString(zamli);

           



        }
    }
}
