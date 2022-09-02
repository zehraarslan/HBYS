using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;

namespace hbys1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet2.yatan_hasta' table. You can move, or remove it, as needed.
            this.yatan_hastaTableAdapter.Fill(this.Database1DataSet2.yatan_hasta);
            // TODO: This line of code loads data into the 'Database1DataSet.hasta_kayit_tablo' table. You can move, or remove it, as needed.
            this.hasta_kayit_tabloTableAdapter.Fill(this.Database1DataSet.hasta_kayit_tablo);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Zehra ARSLAN/Desktop/HBYS/ders/Database1.accdb"); //Veri tabanı bağlantısı
            con.Open();
            DataTable dt = new DataTable(); //veri tablosu
            OleDbDataAdapter da = new OleDbDataAdapter("select * from yatan_hasta where servis_adi='"+textBox1.Text+"'", con);
            da.Fill(dt); //fill doldurmak demek . Tabloyu dt'yi doldur
            ReportDataSource rds = new ReportDataSource("DataSet1",dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form yeniform = new Form1();
            yeniform.Show();
            this.Hide();
        }
    }
}
