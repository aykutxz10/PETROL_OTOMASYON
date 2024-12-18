using PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet11TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PETROL_OTOMASYON_8_ARALIIK
{
    public partial class Kasa : Form
    {
        public static string genel_bilgi = "";

        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;");
       
        public Kasa()
        {
            InitializeComponent();
        }
       

        private PrintDocument printDocument = new PrintDocument();
        private void Kasa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet13.UrunSatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunSatisTableAdapter.Fill(this.petrol_otomasyonDataSet13.UrunSatis);
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet12.ürün' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünTableAdapter.Fill(this.petrol_otomasyonDataSet12.ürün);
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet11.KASA_SATIS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kASA_SATISTableAdapter.Fill(this.petrol_otomasyonDataSet11.KASA_SATIS);
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet2.Kasa' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kasaTableAdapter.Fill(this.petrol_otomasyonDataSet2.Kasa);


        }
        private void button1_Click(object sender, EventArgs e)
        {
       
        
            try
            {
                // Ürün adı, adeti ve fiyatını al
                string productName = textBox1.Text;
                int quantity = int.Parse(textBox2.Text); // Adet
                decimal price = decimal.Parse(textBox3.Text); // Fiyat

                // Toplam tutarı hesapla
                decimal total = quantity * price;

                // Sonucu textBox veya label'da göster
                textBox4.Text = "Toplam: " + total.ToString("C2");

                // Veritabanına kaydetme butonunu aktif hale getirebiliriz
                button5.Enabled = true; // Kaydetme butonunu aktif yapıyoruz
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli sayısal değerler girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = textBox1.Text;
                int quantity = int.Parse(textBox2.Text);
                decimal price = decimal.Parse(textBox3.Text);
                decimal total = quantity * price;

                // SQL bağlantısı
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;"))
                {
                    connection.Open();

                    // Veri eklemek için SQL sorgusu
                    string query = "INSERT INTO UrunSatis (UrunAdi, Adet, Fiyat, Toplam) VALUES (@UrunAdi, @Adet, @Fiyat, @Toplam)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Parametreler ekleniyor
                        cmd.Parameters.AddWithValue("@UrunAdi", productName);
                        cmd.Parameters.AddWithValue("@Adet", quantity);
                        cmd.Parameters.AddWithValue("@Fiyat", price);
                        cmd.Parameters.AddWithValue("@Toplam", total);

                        // Sorguyu çalıştır
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Veriler başarıyla veritabanına kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Veri kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string urunAdi = textBox1.Text;
            string satilacakMiktar = textBox3.Text;
            string toplamTutar = textBox4.Text;

            MessageBox.Show($"Fiş Yazdırıldı:\n\nÜrün Adı: {urunAdi}\nSatılacak Miktar: {satilacakMiktar}\nToplam Tutar: {toplamTutar}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int SaleID = int.Parse(textBox1.Text); // ID textbox'ından alınan ID

                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;"))
                {
                    connection.Open();

                    string query = "DELETE FROM KASA_SATIS WHERE SaleID = @SaleID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SaleID", SaleID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ürün başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;"))
                {
                    connection.Open();

                    string query = "SELECT UrunAdi, Adet, Fiyat, Toplam FROM UrunSatis";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // DataGridView'i güncelle
                        dataGridView1.DataSource = dataTable;
                    }
                    textBox1.Clear(); // Ürün adı
                    textBox2.Clear(); // Adet
                    textBox3.Clear(); // Fiyat
                    textBox4.Clear(); // Toplam tutar (eğer varsa)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = textBox1.Text;
                int quantity = int.Parse(textBox2.Text);
                decimal price = decimal.Parse(textBox3.Text);
                decimal total = quantity * price;

                // SQL bağlantısı
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;"))
                {
                    connection.Open();

                    // Veri eklemek için SQL sorgusu
                    string query = "INSERT INTO UrunSatis (UrunAdi, Adet, Fiyat, Toplam) VALUES (@UrunAdi, @Adet, @Fiyat, @Toplam)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Parametreler ekleniyor
                        cmd.Parameters.AddWithValue("@UrunAdi", productName);
                        cmd.Parameters.AddWithValue("@Adet", quantity);
                        cmd.Parameters.AddWithValue("@Fiyat", price);
                        cmd.Parameters.AddWithValue("@Toplam", total);

                        // Sorguyu çalıştır
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Veriler başarıyla veritabanına kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("Veri kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    

        
    

}






