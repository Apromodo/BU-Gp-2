using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace görsel_programlama_soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=KAYAUNAL7B35;Initial Catalog=soru11;Integrated Security=True");
        SqlDataAdapter adaprer;
        SqlCommand command;

        void icerikgoster()
        {
            SqlConnection connection = new SqlConnection("Data Source=KAYAUNAL7B35;Initial Catalog=soru11;Integrated Security=True");

            connection.Open();
            adaprer = new SqlDataAdapter("SELECT * FROM isci", connection);
            DataTable tablo = new DataTable();
            adaprer.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            icerikgoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO isci(isim, meslek, b_tarihi, maas, yas) VALUES (@isim, @meslek, @b_tarihi, @maas, @yas)";
            command = new SqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@isim", textBox2.Text);
            command.Parameters.AddWithValue("@meslek", comboBox1.Text);
            command.Parameters.AddWithValue("@b_tarihi", textBox3.Text);
            command.Parameters.AddWithValue("@maas", textBox4.Text);
            command.Parameters.AddWithValue("@yas", textBox5.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            icerikgoster();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            string sorgu = "UPDATE isci SET isim=@isim, meslek=@meslek, b_tarihi=@b_tarihi, maas=@maas, yas=@yas WHERE iscino=@iscino";
            command = new SqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@iscino", textBox1.Text);
            command.Parameters.AddWithValue("@isim", textBox2.Text);
            command.Parameters.AddWithValue("@meslek", comboBox1.Text);
            command.Parameters.AddWithValue("@b_tarihi", textBox3.Text);
            command.Parameters.AddWithValue("@maas", textBox4.Text);
            command.Parameters.AddWithValue("@yas", textBox5.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            icerikgoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string sorgu = "DELETE FROM isci WHERE iscino=@iscino";

            command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@iscino", textBox1.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            icerikgoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int yüzde = Convert.ToInt16(textBox6.Text);
            int maas = Convert.ToInt16(textBox4.Text);


            int zam = maas * yüzde / 100;
            int zamyeni = maas + zam;

            textBox4.Text = Convert.ToString(zamyeni);
        }
    }
}
