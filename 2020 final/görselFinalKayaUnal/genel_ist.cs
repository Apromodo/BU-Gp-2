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
    public partial class genel_ist : Form
    {
        public genel_ist()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=KAYAUNAL7B35;Initial Catalog=covid;Integrated Security=True");
        SqlDataAdapter adaprer;
        SqlCommand command;




        private void Tamam1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genel_ist_Load(object sender, EventArgs e)
        {
            string vakas = "select sum(vaka_sayısı) as toplam from vaka";
            baglanti.Open();
            SqlCommand vakas1 = new SqlCommand(vakas, baglanti);
            label123.Text = vakas1.ExecuteScalar().ToString();
            vakas1.ExecuteNonQuery();
            baglanti.Close();

            string iylesens = "select sum(iyilesen_sayısı) as toplam from vaka";
            baglanti.Open();
            SqlCommand iylesens1 = new SqlCommand(iylesens, baglanti);
            label6.Text = iylesens1.ExecuteScalar().ToString();
            iylesens1.ExecuteNonQuery();
            baglanti.Close();

            string yogunb = "select sum(yogun_bakım) as toplam from vaka";
            baglanti.Open();
            SqlCommand yogunb1 = new SqlCommand(yogunb, baglanti);
            label7.Text = yogunb1.ExecuteScalar().ToString();
            yogunb1.ExecuteNonQuery();
            baglanti.Close();

            string entube = "select sum(entube) as toplam from vaka";
            baglanti.Open();
            SqlCommand entube1 = new SqlCommand(entube, baglanti);
            label8.Text = entube1.ExecuteScalar().ToString();
            entube1.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
