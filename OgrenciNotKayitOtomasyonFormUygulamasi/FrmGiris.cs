
namespace OgrenciNotKayitOtomasyonFormUygulamasi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciDetay ogrenciDetay = new OgrenciDetay();
            ogrenciDetay.numara = maskedTextBox1.Text;
            ogrenciDetay.Show();
        }


        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                OgretmenDetay ogretmenDetay = new OgretmenDetay();
                ogretmenDetay.Show();
            }
        }
    }
}