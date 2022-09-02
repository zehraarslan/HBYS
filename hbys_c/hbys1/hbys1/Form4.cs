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

namespace hbys1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Zehra ARSLAN/Desktop/HBYS/ders/Database1.accdb"); //Veri tabanı bağlantısı
            DataTable dt = new DataTable(); //veri tablosu
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Poliklinik", con);
            da.Fill(dt); //fill doldurmak demek . Tabloyu dt'yi doldur
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hastaadi = textBox1.Text;
            string hastasoyadi = textBox2.Text;
            string poliklinikadi = textBox3.Text;
            string doktoradi = textBox4.Text;
            string tarihi = monthCalendar1.SelectionStart.Date.ToString("yyyy/MM/dd").Replace('.', '/');
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Zehra ARSLAN/Desktop/HBYS/ders/Database1.accdb");
            baglanti.Open();
            string randevuekle="insert into Poliklinik(hasta_adi,hasta_soyadi,poliklinik_adi,doktor_adi,tarih) values(@hastaadi,@hastasoyadi,@poliklinikadi,@doktoradi,@tarihi)";
            OleDbCommand ekle = new OleDbCommand(randevuekle, baglanti);
            ekle.Parameters.Add("@hasta_adi", OleDbType.Char, 50).Value = hastaadi;
            ekle.Parameters.Add("@hasta_soyadi", OleDbType.Char, 50).Value = hastasoyadi;
            ekle.Parameters.Add("@poliklinik_adi", OleDbType.Char, 50).Value = poliklinikadi;
            ekle.Parameters.Add("@doktor_adi", OleDbType.Char, 50).Value = doktoradi;
            ekle.Parameters.Add("@tarih", OleDbType.Date).Value = tarihi;
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu kaydedildi.");

            DataTable dt = new DataTable(); //veri tablosu
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Poliklinik", baglanti);
            da.Fill(dt); //fill doldurmak demek . Tabloyu dt'yi doldur
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form yeniform = new Form1();
            yeniform.Show();
            this.Hide();
        
        }
    }
}
