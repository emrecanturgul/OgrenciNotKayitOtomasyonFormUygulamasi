using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotKayitOtomasyonFormUygulamasi
{
    public  class SqlBaglantisi
    {    
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"burda sql bağlantısı var ");
            baglan.Open();
            return baglan; 
        }
     }
}
