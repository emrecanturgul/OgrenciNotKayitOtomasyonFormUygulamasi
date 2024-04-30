using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace OgrenciNotKayitOtomasyonFormUygulamasi
{
    public partial class OgretmenDetay : Form
    {
        public OgretmenDetay()
        {
            InitializeComponent();
        }


        private void OgretmenDetay_Load(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_ders", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("insert into tbl_ders (OGRNUMARA,OGRAD,OGRSOYAD) values (@P1,@P2,@P3)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@P1", msknumara.Text);
            cmd.Parameters.AddWithValue("@P2", mskad.Text);
            cmd.Parameters.AddWithValue("@P3", msksoyad.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ÖĞRENCİ SİSTEME EKLENDİ");
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_ders", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            msknumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msksoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msksinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            msksinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            msksinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            string durum;
            double ortalama; 
            double s1 = string.IsNullOrEmpty(msksinav1.Text) ? 0 : Convert.ToDouble(msksinav1.Text);
            double s2 = string.IsNullOrEmpty(msksinav2.Text) ? 0 : Convert.ToDouble(msksinav2.Text);
            double s3 = string.IsNullOrEmpty(msksinav3.Text) ? 0 : Convert.ToDouble(msksinav3.Text);
            
           
            
            ortalama = (s1 + s2 + s3) / 3.0;
            lblortalama.Text = ortalama.ToString(); 
            if (ortalama >= 50) 
            {
                durum = "true";
            }
            else
            {
                durum = "false";
            }
            lblortalama.Text = ortalama.ToString();
            SqlCommand cmd = new SqlCommand("update tbl_ders set OGRS1=@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA = @P4,DURUM = @P5 WHERE OGRNUMARA = @P6", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", msksinav1.Text);
            cmd.Parameters.AddWithValue("@p2", msksinav2.Text);
            cmd.Parameters.AddWithValue("@p3", msksinav3.Text);
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(lblortalama.Text));
            cmd.Parameters.AddWithValue("@p5", durum);
            cmd.Parameters.AddWithValue("@p6", msknumara.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("öğrenci notları güncellendi");
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_ders", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }
    }
}

