using System;
using System.Data.SqlClient;

namespace BitkiSulamaTakip
{
    public class baglantilar
    {
        // Veritabanına bağlanmak için kullanılan metod
        public SqlConnection baglanti()
        {
            // Veritabanı bağlantı dizesi
            SqlConnection conn = new SqlConnection("Data Source=CAVA;Initial Catalog=bitkisistemi;Integrated Security=True;\r\n");
            try
            {
                conn.Open(); // Veritabanına bağlantıyı açıyoruz
            }
            catch (Exception ex)
            {
                // Eğer bağlantı hatası olursa, hata mesajı gösteriyoruz
                Console.WriteLine("Bağlantı hatası: " + ex.Message);
            }
            return conn;
        }
    }
}
