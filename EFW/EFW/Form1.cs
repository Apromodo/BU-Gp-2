using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFW
{
    public partial class Form1 : Form
    {

        PatientDBEntities db;

        public void getir()
        {
            db = new PatientDBEntities();
            dataGridView1.DataSource = db.PatientInfoes.ToList();
        }

        public void Save_data()
        {
            PatientInfo info = new EFW.PatientInfo();
            
            info.TCNo = txtTCNo.Text;
            info.Name = txtName.Text;
            info.LastName = txtLName.Text;
            db.PatientInfoes.Add(info);
            db.SaveChanges();
            getir();
        }

        public Form1()
        {
            InitializeComponent();
            getir();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save_data();
        }

        public void update_data()
        {
            string TC = txtTCNo.Text;
            PatientInfo tbl = db.PatientInfoes.First(f => f.TCNo == TC);
            tbl.Name = txtName.Text;
            tbl.LastName = txtLName.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme tamam !");
            getir();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_data();
        }

        public void sil()
        {
            string TC = txtTCNo.Text;
            PatientInfo tbl = db.PatientInfoes.First(f => f.TCNo == TC);
            db.PatientInfoes.Remove(tbl);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi tamam !");
            getir();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            sil();
        }
    }
}
