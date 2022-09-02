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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace hbys1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection con; 

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Form3.kimmis == "Mühendis") comboBox1.Enabled = false;
            if (Form3.kimmis == "Doktor") comboBox1.Enabled = true;


            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Zehra ARSLAN/Desktop/HBYS/ders/Database1.accdb"); //Veri tabanı bağlantısı
            DataTable dt = new DataTable(); //veri tablosu
            OleDbDataAdapter da = new OleDbDataAdapter("select distinct servis_adi from hasta_detay", con); 
            da.Fill(dt); //fill doldurmak demek . Tabloyu dt'yi doldur
            comboBox1.ValueMember = "hasta_no"; 
            comboBox1.DisplayMember = "servis_adi";
            comboBox1.DataSource = dt; 

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1) 
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from hasta_detay where servis_adi ='"+comboBox1.Text+"'", con);
                
                da.Fill(dt);
                dataGridView1.DataSource = dt;
              
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from hasta_detay ", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                comboBox1.Enabled = false;
            }
            else
            {
                if (comboBox1.SelectedIndex != -1) 
                {
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter("select * from hasta_detay where servis_adi ='" + comboBox1.Text + "'", con);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    comboBox1.Enabled = true;
                }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Zehra ARSLAN/Desktop/HBYS/ders/Database1.accdb");
                con.Open();
                string komut = "select * from hasta_kayit_tablo where hasta_no=" + dataGridView1.SelectedRows[0].Cells[0].Value;
                OleDbCommand dc = new OleDbCommand(komut, con); 
                OleDbDataReader rdr = dc.ExecuteReader();
                while (rdr.Read())
                {
                    textBox5.Text = rdr["hasta_no"].ToString();
                    textBox1.Text = rdr["hasta_adi"].ToString();
                    textBox2.Text = rdr["hasta_soyadi"].ToString();
                    textBox3.Text = rdr["dogum_tarihi"].ToString();
                    textBox4.Text = rdr["tel"].ToString();
                }
            }
            catch { }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream(@"C:/Users/Zehra ARSLAN/Desktop/HBYS/deneme.pdf", FileMode.Create));
            if (document.IsOpen() == false)
            {
                document.Open();
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:/Users/Zehra ARSLAN/Desktop/HBYS/logo.jpg");
                img.ScalePercent(64f);
                document.Add(img);
                document.Add(new Paragraph("Hasta No : " + textBox5.Text));
                document.Add(new Paragraph("Adı : " + textBox1.Text));
                document.Add(new Paragraph("Soyadı : " + textBox2.Text));
                document.Add(new Paragraph("Dogum Tarihi : " + textBox3.Text));
                document.Add(new Paragraph("Telefon Numarasi : " + textBox4.Text));
                document.Close();

                MessageBox.Show("Pdf oluşturulurdu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 raporlama = new Form2();
            raporlama.Show();
            this.Hide();
        }
        int sayac = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            string[] servis = new string[20];
            int[] sayi = new int[20];
         
            do
            {
                comboBox1.SelectedIndex = sayac;
                servis[sayac] = comboBox1.Text;
                sayac++;

            } while (sayac < comboBox1.Items.Count);
            OleDbCommand sor = new OleDbCommand("select * from hasta_detay", con);
            con.Open();
            OleDbDataReader oku = sor.ExecuteReader();
            while (oku.Read())
            {
                for(int i=0; i <5 ; i++)
                {
                    if (servis[i] == oku[1].ToString())
                    {
                        sayi[i]++;
                    }
                }
                
            }
            for (int i = 0; i < 5; i++)
            {
                chart1.Series["Series1"].Points.AddXY(servis[i], sayi[i]);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form yeniform = new Form4();
            yeniform.Show();
            this.Hide();
        }
    }
}
