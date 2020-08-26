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
    public partial class veritabaniForm : Form
    {
        public veritabaniForm()
        {
            InitializeComponent();
            
        }

        public void veri_getir()
        {
            try
            {
                SqlCommand cmd = SqlBaglantisi.getCommand("select * from PatientInfo");                
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void veritabaniForm_Load(object sender, EventArgs e)
        {
            veri_getir();   //verileri getirir
        }
    }
}
