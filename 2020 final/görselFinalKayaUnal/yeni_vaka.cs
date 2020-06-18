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
    public partial class yeni_vaka : Form
    {
        public yeni_vaka()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=KAYAUNAL7B35;Initial Catalog=covid;Integrated Security=True");
        SqlDataAdapter adaprer;
        SqlCommand command;

        void icerikgoster()
        {



        }

        private void ilSec_SelectedIndexChanged(object sender, EventArgs e)
        {
          

                string sorgu = "UPDATE vaka SET il=@il";

        }

        private void vakaSay_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeniİyles_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeniYogunBakım_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeniEntb_TextChanged(object sender, EventArgs e)
        {

        }

        private void tarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            //string sorgu = "UPDATE isci SET il=@il, vaka_sayısı=vaka_sayısı, iyilesen_sayısıi=@iyilesen_sayısı, yogun_bakım=@yogun_bakım, entube=@entube, tarih=@tarih";

            //command.Parameters.AddWithValue("@il", vakaSay.Text);
            //command.Parameters.AddWithValue("@vaka_sayısı", yeniİyles.Text);
            //command.Parameters.AddWithValue("@iyilesen_sayısı", yeniİyles.Text);
            //command.Parameters.AddWithValue("@yogun_bakım", yeniYogunBakım.Text);
            //command.Parameters.AddWithValue("@entube", yeniEntb.Text);
            //command.Parameters.AddWithValue("@tarih", tarih.Text);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO vaka(il,vaka_sayısı,iyilesen_sayısı,yogun_bakım,entube)" + "values (@il,@vaka_sayısı,@iyilesen_sayısı,@yogun_bakım,@entube)", baglanti);
            komut.Parameters.AddWithValue("@il", ilSec.Text);
            komut.Parameters.AddWithValue("@vaka_sayısı", vakaSay.Text);
            komut.Parameters.AddWithValue("@iyilesen_sayısı", yeniİyles.Text);
            komut.Parameters.AddWithValue("@yogun_bakım", yeniYogunBakım.Text);
            komut.Parameters.AddWithValue("@entube", yeniEntb.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            this.Close();

        }
    }
    }

