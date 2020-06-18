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

namespace görselFinalKayaUnal

{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=KAYAUNAL7B35;Initial Catalog=covid;Integrated Security=True");
        SqlDataAdapter adaprer;
        SqlCommand command;
        DataSet daset = new DataSet();


        void icerikgoster()
        {
            SqlConnection connection = new SqlConnection("Data Source=KAYAUNAL7B35;Initial Catalog=covid;Integrated Security=True");

            connection.Open();
            adaprer = new SqlDataAdapter("SELECT * FROM vaka", connection);
            DataTable tablo = new DataTable();
            adaprer.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'covidDataSet.vaka' table. You can move, or remove it, as needed.
            this.vakaTableAdapter.Fill(this.covidDataSet.vaka);

        }

        private void vakaEkle_Click(object sender, EventArgs e)
        {
            yeni_vaka getirVaka = new yeni_vaka();
            getirVaka.Show();
        }

        private void genelGter_Click(object sender, EventArgs e)
        {
            genel_ist getir = new genel_ist();
            getir.Show();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Vaka Girişini Silmek İstiyorsunuz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from vaka where il=@il", baglanti);
                komut.Parameters.AddWithValue("@il", dataGridView1.CurrentRow.Cells["il"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("silindii");
                daset.Tables["vaka"].Clear();
                icerikgoster();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void güncel_Click(object sender, EventArgs e)
        {
            //dataGridView1.Refresh();
            //dataGridView1.Update();

            this.dataGridView1.Refresh();
            this.dataGridView1.Parent.Refresh();
        }
    }
}
