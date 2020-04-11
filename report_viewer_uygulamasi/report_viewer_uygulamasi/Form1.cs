using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace report_viewer_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LH_ERPDataSet.Tbl_Musteri_Siparis' table. You can move, or remove it, as needed.
            this.Tbl_Musteri_SiparisTableAdapter.Fill(this.LH_ERPDataSet.Tbl_Musteri_Siparis);

            this.reportViewer1.RefreshReport();
        }
    }
}
