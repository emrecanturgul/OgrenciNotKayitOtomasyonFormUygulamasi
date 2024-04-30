using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciNotKayitOtomasyonFormUygulamasi
{
    public partial class OgrenciDetay : Form
    {
        public OgrenciDetay()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMRE\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void OgrenciDetay_Load(object sender, EventArgs e)
        {

            lblnumara.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_ders where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text = dr[2].ToString();
                lblsoyad.Text = dr[3].ToString();
                lblsinav1.Text = dr[4].ToString();
                lblsinav2.Text = dr[5].ToString();
                lblsinav3.Text = dr[6].ToString();
                lblortalama.Text = dr[7].ToString();
                if (dr[8].ToString() == "True")
                {
                    lbldurum.Text = "geçti"; 
                } 
                else
                {
                    lbldurum.Text = "kaldı"; 
                }

                        
                

            }
            baglanti.Close();
        }
    }
}
