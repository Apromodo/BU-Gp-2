using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // eklememiz gerekiyor

namespace _10nisan
{
    public partial class Form1 : Form
    {       //oleDbConnection,, odc, baglan
        //access veritabanı bağlantısı yapmak için kullanılır.
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=gorsel.accdb");//constructor
        //Baglan değişkeni DB bağlantısını tutar.
        private void  listele()
        {
            // OleDBCommand veritabanı sorgu yap ve DB bağlantısını kur
            OleDbCommand cmd = new OleDbCommand("SELECT id,numara,ad,soyad,tc FROM ogrenciler", baglan);
            DataTable tablo = new DataTable();
            OleDbDataAdapter adaptor = new OleDbDataAdapter(cmd);//ara katman
            adaptor.Fill(tablo);

            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
        }
        public Form1()
        {
            InitializeComponent();

            listele();
         
        }

        private void ekleButon_Click(object sender, EventArgs e)
        {
            try
            {
                   
                    baglan.Open(); // Bağlantıyı açıyoruz
                //OleDbCommand -> sorgu                 //insert into ogrenciler values ...  // values = değerler
                    OleDbCommand cmd = new OleDbCommand("insert into ogrenciler(numara,ad,soyad,tc) VALUES (@ogr_numara, @ogr_ad, @ogr_soyad, @ogr_tc)", baglan);
                   
                    cmd.Parameters.AddWithValue("@ogr_numara", Convert.ToInt32(noText.Text)); 
                    cmd.Parameters.AddWithValue("@ogr_ad", isimText.Text); 
                    cmd.Parameters.AddWithValue("@ogr_soyad", soyText.Text); 
                    cmd.Parameters.AddWithValue("@ogr_tc", Convert.ToInt32(tcText.Text));                                                    
                    cmd.ExecuteNonQuery();
                    baglan.Close();

                    listele();

                    MessageBox.Show("Öğrenci Başarıyla Kayıt Edildi");
     
            }
            catch (Exception hata)
            {   
              MessageBox.Show("Numara ve TC alanları aynı olan birden fazla kayıt olamaz!\n" +
                  "Numara ve TC alanları Integer türünde olmalıdır!");
       
                baglan.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            noText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            isimText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            soyText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tcText.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();         
        }
        private void guncelButon_Click(object sender, EventArgs e)
        {
            try
            {              
                baglan.Open();          
                
                OleDbCommand cmd = new OleDbCommand("update ogrenciler set numara= @ogr_numara, ad=@ogr_ad, soyad=@ogr_soyad, tc=@ogr_tc where id =@ogr_id", baglan);
                cmd.Parameters.AddWithValue("@ogr_numara", Convert.ToInt32(noText.Text));
                cmd.Parameters.AddWithValue("@ogr_ad", isimText.Text); 
                cmd.Parameters.AddWithValue("@ogr_soyad", soyText.Text); 
                cmd.Parameters.AddWithValue("@ogr_tc", Convert.ToInt32(tcText.Text));
                cmd.Parameters.AddWithValue("@ogr_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                
                cmd.ExecuteNonQuery();
                dataGridView1.Update();
                baglan.Close();
                
                listele();
                MessageBox.Show("Öğrenciye Ait Bilgiler Güncellendi.");
            }
            catch (Exception hata) {               
                   
                MessageBox.Show("Numara ve TC alanları aynı olan birden fazla kayıt olamaz!\n" +
                "Numara ve TC alanları Integer türünde olmalıdır!");
                
                baglan.Close();
            } 

        }

        private void silButon_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                
                OleDbCommand cmd = new OleDbCommand("DELETE FROM ogrenciler WHERE id = @ogr_id", baglan);
                
                cmd.Parameters.AddWithValue("@ogr_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                cmd.ExecuteNonQuery();
                baglan.Close();
                listele();
                MessageBox.Show("Öğrenci Başarıyla Silindi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}

