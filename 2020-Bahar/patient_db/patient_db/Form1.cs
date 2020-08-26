using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patient_db
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtAdi.Text) || string.IsNullOrEmpty(txtSoyadi.Text) || string.IsNullOrEmpty(txtTCNo.Text))
            {
                MessageBox.Show("Ad, Soyad ve TC girilmesi zorunludur.");
                return;
            }
            try
            {
                SqlCommand cmd = SqlBaglantisi.getCommand("select PatientID,Name,LastName from PatientInfo where TCNo=@no");
                cmd.Parameters.AddWithValue("@no", txtTCNo.Text.Trim());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string name = dr.GetString(1);
                GlobalVariables.TCNo = txtTCNo.Text;
                GlobalVariables.pName = txtAdi.Text;
                GlobalVariables.pLastName = txtSoyadi.Text;
                MessageBox.Show("veri tabanında kayıtlıdır !");
                //PrgClass.Mesajor("Patient is exist in database !.");
                this.Close();

            }
            catch (Exception ex)
            {
                SqlCommand cmd1 = SqlBaglantisi.getCommand("insert into PatientInfo (TCNo,Name,LastName,History,DateOfInspection,GSM,Tel, Adres) values (@TCNo,@Name,@LastName,@History,@DateOfInspection,@GSM,@Tel, @Adres)");
                cmd1.Parameters.AddWithValue("@TCNo", txtTCNo.Text);
                cmd1.Parameters.AddWithValue("@Name", txtAdi.Text);
                cmd1.Parameters.AddWithValue("@LastName", txtSoyadi.Text);
                cmd1.Parameters.AddWithValue("@History", rtbGecmis.Text);
                cmd1.Parameters.AddWithValue("@DateOfInspection", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd1.Parameters.AddWithValue("@GSM", txtGSM.Text);
                cmd1.Parameters.AddWithValue("@Tel", txtTel.Text);
                cmd1.Parameters.AddWithValue("@Adres", rtbAdres.Text);
                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd1.Connection.Close();
                    cmd1.Connection.Dispose();
                    //PrgClass.Mesajor("The Process is completed !.");
                    GlobalVariables.TCNo = txtTCNo.Text;
                    GlobalVariables.pName = txtAdi.Text;
                    GlobalVariables.pLastName = txtSoyadi.Text;
                    //MessageBox.Show("işlem tamam!");
                    veritabaniForm vtf = new patient_db.veritabaniForm();
                    vtf.ShowDialog();
                }
                catch (Exception ex1)
                {
                    throw ex1;                  
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            veritabaniForm vtf = new patient_db.veritabaniForm();
            vtf.ShowDialog();
        }
    }
}
