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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string kimmis;
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Zehra ARSLAN/Desktop/HBYS/ders/Database1.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Kullanici where Kullanici_adi='" + textBox1.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while(okuyucu.Read())
            {
                if (textBox2.Text.ToString()==okuyucu["Sifre"].ToString())
                {
                    kimmis = okuyucu["Yetki"].ToString();
                    Form yeniform = new Form1();
                    yeniform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre Yanlıştır.");
                }
            }
        }
    }
}
