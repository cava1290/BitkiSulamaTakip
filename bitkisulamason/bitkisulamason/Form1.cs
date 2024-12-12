using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitkiSulamaTakip; // baglantilar sınıfının bulunduğu namespace



namespace bitkisulamason
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bitkisistemiDataSet.Bitkiler' table. You can move, or remove it, as needed.
            this.bitkilerTableAdapter.Fill(this.bitkisistemiDataSet.Bitkiler);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new baglantilar().baglanti(); // Bağlantıyı kuruyoruz
            try
            {
                // Kullanıcıdan alınan değerler
                string ad = txtAd.Text.Trim();
                string tur = txtTur.Text.Trim();
                int sulamaSikligi;

                // Sulama sıklığının sayısal bir değer olduğunu kontrol et
                if (!int.TryParse(txtSulamaSikligi.Text.Trim(), out sulamaSikligi))
                {
                    MessageBox.Show("Lütfen sulama sıklığını sayı olarak girin!");
                    return;
                }

                // Bugünün tarihi ve sonraki sulama tarihi
                DateTime bugun = DateTime.Now;
                DateTime BirSonrakiSulamaTarihi = bugun.AddDays(sulamaSikligi); // Sulama sıklığına göre tarih hesaplanır

                // SQL Sorgusu (Sütun adını doğru yazdığınızdan emin olun)
                string query = "INSERT INTO Bitkiler (Ad, Tur, SulamaSikligi, BirSonrakiSulamaTarihi) VALUES (@ad, @tur, @sulamaSikligi, @BirSonrakiSulamaTarihi)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Parametreler
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Tur", tur);
                cmd.Parameters.AddWithValue("@SulamaSikligi", sulamaSikligi);
                cmd.Parameters.AddWithValue("@BirSonrakiSulamaTarihi", BirSonrakiSulamaTarihi); // Sulama tarihi parametresi

                // Komutu çalıştır
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bitki başarıyla eklendi!");

                // TextBox'ları temizle
                txtAd.Clear();
                txtTur.Clear();
                txtSulamaSikligi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTabloGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new baglantilar().baglanti(); // Bağlantıyı kuruyoruz
            try
            {
                // SQL sorgusu
                string sorgu = "SELECT Id, Ad, Tur, SulamaSikligi, SulamaTarihi, BirSonrakiSulamaTarihi FROM Bitkiler";

                // Veritabanından verileri çekmek için SqlDataAdapter kullanacağız
                SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
                DataTable dt = new DataTable(); // DataTable nesnesi oluşturuluyor
                da.Fill(dt); // Veritabanından gelen veriler DataTable'a yükleniyor

                // DataGridView'e bağlama
                dataGridView1.DataSource = dt;

                // Başarılı mesajı (isteğe bağlı)
                MessageBox.Show("Tablo başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Bağlantıyı kapatıyoruz
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçilen satırdaki Id'yi alıyoruz
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index; // Seçili satırın index'i
                int bitkiId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value); // Id değerini alıyoruz

                SqlConnection conn = new baglantilar().baglanti(); // Bağlantıyı kuruyoruz
                try
                {
                    // SQL Sorgusu: Seçilen Id'ye sahip bitkini silme
                    string query = "DELETE FROM Bitkiler WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Parametre
                    cmd.Parameters.AddWithValue("@id", bitkiId);

                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();

                    // Başarılı mesajı
                    MessageBox.Show("Bitki başarıyla silindi!");

                    // Tabloyu güncelle
                    btnTabloGuncelle_Click(sender, e);
                }
                catch (Exception ex)
                {
                    // Hata mesajı
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); // Bağlantıyı kapatıyoruz
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bitkiyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // TextBox'lardan alınan yeni değerler
            string yeniAd = txtAd.Text.Trim();
            string yeniTur = txtTur.Text.Trim();
            int yeniSulamaSikligi;

            // Sulama sıklığı kontrolü
            if (!int.TryParse(txtSulamaSikligi.Text.Trim(), out yeniSulamaSikligi))
            {
                MessageBox.Show("Lütfen geçerli bir sulama sıklığı girin!");
                return;
            }

            // DataGridView'den seçilen satırdaki Id'yi alıyoruz
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index; // Seçili satırın index'i
                int bitkiId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value); // Id değerini alıyoruz

                SqlConnection conn = new baglantilar().baglanti(); // Bağlantıyı kuruyoruz
                try
                {
                    // SQL Sorgusu: Seçilen Id'ye sahip bitkinin bilgilerini güncelleme
                    string query = "UPDATE Bitkiler SET Ad = @ad, Tur = @tur, SulamaSikligi = @sulamaSikligi WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Parametreler
                    cmd.Parameters.AddWithValue("@ad", yeniAd);
                    cmd.Parameters.AddWithValue("@tur", yeniTur);
                    cmd.Parameters.AddWithValue("@sulamaSikligi", yeniSulamaSikligi);
                    cmd.Parameters.AddWithValue("@id", bitkiId);

                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();

                    // Başarılı mesajı
                    MessageBox.Show("Bitki başarıyla güncellendi!");

                    // Tabloyu güncelle
                    btnTabloGuncelle_Click(sender, e);
                }
                catch (Exception ex)
                {
                    // Hata mesajı
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); // Bağlantıyı kapatıyoruz
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bitkiyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki Id'yi alıyoruz
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                txtAd.Text = dataGridView1.Rows[selectedRowIndex].Cells["Ad"].Value.ToString();
                txtTur.Text = dataGridView1.Rows[selectedRowIndex].Cells["Tur"].Value.ToString();
                txtSulamaSikligi.Text = dataGridView1.Rows[selectedRowIndex].Cells["SulamaSikligi"].Value.ToString();
            }
        }
        private void txtSulamaSikligi_TextChanged(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan sulama sıklığı
            int sulamaSikligi;

            // Eğer kullanıcı bir sayı girmemişse çık
            if (!int.TryParse(txtSulamaSikligi.Text.Trim(), out sulamaSikligi))
            {
                lblSonrakiSulamaTarihi.Text = "Geçersiz sulama sıklığı!";
                return;
            }

            // Bugünün tarihi
            DateTime bugun = DateTime.Now;

            // Sonraki sulama tarihini hesapla
            DateTime sonrakiSulamaTarihi = bugun.AddDays(sulamaSikligi);

            // Hesaplanan tarihi Label üzerinde göster
            lblSonrakiSulamaTarihi.Text = "Sonraki Sulama Tarihi: " + sonrakiSulamaTarihi.ToString("dd/MM/yyyy");
        }

        private void btnSulamaYap_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği ID'yi alıyoruz
            int bitkiId;
            if (int.TryParse(txtBitkiId.Text, out bitkiId)) // TextBox'tan gelen ID'yi alıyoruz
            {
                DateTime bugun = DateTime.Now; // Bugünün tarihi
                SqlConnection conn = new baglantilar().baglanti(); // Bağlantıyı kuruyoruz
                try
                {
                    // DataGridView'den bitkinin sulama sıklığını alıyoruz
                    // ID ile ilişkili bitkinin sulama sıklığını alıyoruz
                    string selectQuery = "SELECT SulamaSikligi FROM Bitkiler WHERE Id = @Id";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                    selectCmd.Parameters.AddWithValue("@Id", bitkiId);

                    SqlDataReader reader = selectCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int sulamaSikligi = reader.GetInt32(0); // Sulama sıklığını alıyoruz
                        reader.Close();

                        // SQL Sorgusu: Sulama tarihini ve bir sonraki sulama tarihini güncelleme
                        string updateQuery = "UPDATE Bitkiler SET SulamaTarihi = @SulamaTarihi, BirSonrakiSulamaTarihi = @BirSonrakiSulamaTarihi WHERE Id = @Id";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);

                        // Parametreler
                        updateCmd.Parameters.AddWithValue("@SulamaTarihi", bugun); // Bugünün tarihi sulama tarihi olarak kaydedilecek
                        DateTime sonrakiSulamaTarihi = bugun.AddDays(sulamaSikligi); // Bir sonraki sulama tarihi
                        updateCmd.Parameters.AddWithValue("@BirSonrakiSulamaTarihi", sonrakiSulamaTarihi); // Sonraki sulama tarihi
                        updateCmd.Parameters.AddWithValue("@Id", bitkiId); // Bitkinin ID'si

                        // Komutu çalıştır
                        updateCmd.ExecuteNonQuery();

                        // Başarılı mesajı
                        MessageBox.Show("Bitki sulandı ve sonraki sulama tarihi güncellendi!");

                        // Tabloyu güncelle
                        btnTabloGuncelle_Click(sender, e); // Tabloyu tekrar güncelliyoruz
                    }
                    else
                    {
                        MessageBox.Show("Bu ID ile ilgili bitki bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Hata mesajı
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); // Bağlantıyı kapatıyoruz
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir Bitki ID'si girin.", "Geçersiz ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblSonrakiSulamaTarihi_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblBitkiId_Click(object sender, EventArgs e)
        {

        }

        private void txtSulamaSikligi_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtTur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
