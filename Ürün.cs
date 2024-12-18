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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PETROL_OTOMASYON_8_ARALIIK
{
    public partial class Ürün : Form
    {
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;");
        private DataTable ÜrünTable;
        public Ürün()
        {
            InitializeComponent();
            // Personel tablosu ve DataGridView'e veri kaynağını bağlamak
            ÜrünTable = new DataTable();

            // DataTable'a sütunları ekliyoruz
            ÜrünTable.Columns.Add("ürünAdi", typeof(string));
            ÜrünTable.Columns.Add("ürünMarka", typeof(string));
            ÜrünTable.Columns.Add("ürünFiyati", typeof(string));
            ÜrünTable.Columns.Add("ürünTipi", typeof(string));
            ÜrünTable.Columns.Add("stokMiktari", typeof(string));


            // DataGridView'e veri kaynağını bağlıyoruz
            dataGridView1.DataSource = ÜrünTable;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ürün_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet9.ürün' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünTableAdapter1.Fill(this.petrol_otomasyonDataSet9.ürün);
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet3.ürün' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünTableAdapter.Fill(this.petrol_otomasyonDataSet3.ürün);

        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            // TextBox'lardan verileri alıyoruz
            string ürünAdi = textBox1.Text;
            string ürünMarka = textBox2.Text;
            string ürünFiyati = textBox3.Text;
            string ürünTipi = textBox4.Text;
            string stokMiktari = textBox5.Text;

            // SQL bağlantı dizesi (veritabanınızın doğru bağlantı bilgileriyle değiştirilmelidir)
            string connectionString = @"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;";

            // Veritabanı bağlantısı kurma
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    // Veritabanı bağlantısını açıyoruz
                    baglanti.Open();

                    // SQL sorgusu: Ürünü eklemek için INSERT komutu
                    string sorgu = "INSERT INTO ürün (ÜrünAdi, ÜrünMarka, ÜrünFiyati, ÜrünTipi, StokMiktari) " +
                                   "VALUES (@ÜrünAdi, @ÜrünMarka, @ÜrünFiyati, @ÜrünTipi, @StokMiktari)";

                    // SQL komutunu oluşturuyoruz
                    using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                    {
                        // Parametreleri komuta ekliyoruz
                        cmd.Parameters.AddWithValue("@ÜrünAdi", ürünAdi);
                        cmd.Parameters.AddWithValue("@ÜrünMarka", ürünMarka);
                        cmd.Parameters.AddWithValue("@ÜrünFiyati", ürünFiyati);
                        cmd.Parameters.AddWithValue("@ÜrünTipi", ürünTipi);
                        cmd.Parameters.AddWithValue("@StokMiktari", stokMiktari);

                        // Komutu çalıştırıyoruz
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Eğer herhangi bir satır etkilendiyse, ürün başarıyla eklendi
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ürün başarıyla eklendi!");
                        }
                        else
                        {
                            MessageBox.Show("Ürün eklenirken bir hata oluştu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata oluşursa, hata mesajını gösteriyoruz
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    // TextBox'ları temizliyoruz
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }
        }




        private void button5_Click(object sender, EventArgs e)
        {
            string searchText = textBox6.Text; // TextBox9'dan alınan arama metni
            AramaYap(searchText);
        }
        private void AramaYap(string searchText)
        {
            string isim = textBox6.Text;

            try
            {
                // SQL sorgusunu oluşturuyoruz
                string sorgu = "SELECT * FROM ürün WHERE ürünAdi LIKE @ürünAdi";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@ürünAdi", "%" + searchText + "%"); // LIKE operatörü ile esnek arama

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); // Veritabanından alınan veriyi tutacak DataTable
                dataAdapter.Fill(dt); // DataTable'a veriyi yüklüyoruz

                // DataGridView'e sonuçları bağlıyoruz
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message); // Hata mesajı gösteriyoruz
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Giriş Girişform = new Giriş();
            Girişform.Show();  // Giriş formunu göster
            this.Hide();        // Ana sayfayı gizle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ÜrünID'yi TextBox'dan alıyoruz (silinecek ürünün ID'si)
            int ürün_id = Convert.ToInt32(textBox1.Text);  // ÜrünID'yi uygun bir TextBox'dan alabilirsiniz

            // SQL bağlantı dizesi
            string connectionString = @"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;";

            // Veritabanı bağlantısı kurma
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    // Veritabanı bağlantısını açıyoruz
                    baglanti.Open();

                    // SQL sorgusu: Ürünü silmek için DELETE komutu
                    string sorgu = "DELETE FROM ürün WHERE ürün_id = @ürün_id";

                    // SQL komutunu oluşturuyoruz
                    using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                    {
                        // Parametreyi komuta ekliyoruz
                        cmd.Parameters.AddWithValue("@ürün_id", ürün_id);

                        // Komutu çalıştırıyoruz
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Eğer herhangi bir satır etkilendiyse, ürün başarıyla silindi
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ürün başarıyla silindi!");
                        }
                        else
                        {
                            MessageBox.Show("Silinecek ürün bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata oluşursa, hata mesajını gösteriyoruz
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ürünAdi = textBox1.Text;
            string ürünMarka = textBox2.Text;
            string ürünTipi = textBox4.Text;
            string stokMiktari = textBox5.Text;  // Stok miktarı sayısal olmalı

            int ürün_id;
            if (!int.TryParse(textBox1.Text, out ürün_id))  // Ürün ID'si doğru TextBox'tan alınmalı
            {
                MessageBox.Show("Ürün ID'si geçerli bir sayı olmalıdır.");
                return;
            }

            decimal ürünFiyatiDecimal;
            if (!decimal.TryParse(textBox3.Text, out ürünFiyatiDecimal))  // Fiyatı decimal olarak almak
            {
                MessageBox.Show("Geçerli bir ürün fiyatı girin.");
                return;
            }

            int stokMiktariInt;
            if (!int.TryParse(stokMiktari, out stokMiktariInt))  // Stok miktarı sayısal olmalı
            {
                MessageBox.Show("Geçerli bir stok miktarı girin.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "UPDATE ürün SET ÜrünAdi = @ÜrünAdi, ÜrünMarka = @ÜrünMarka, ÜrünFiyati = @ÜrünFiyati, " +
                                   "ÜrünTipi = @ÜrünTipi, StokMiktari = @StokMiktari WHERE ürün_id = @ürün_id";

                    using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@ÜrünAdi", ürünAdi);
                        cmd.Parameters.AddWithValue("@ÜrünMarka", ürünMarka);
                        cmd.Parameters.AddWithValue("@ÜrünFiyati", ürünFiyatiDecimal);
                        cmd.Parameters.AddWithValue("@ÜrünTipi", ürünTipi);
                        cmd.Parameters.AddWithValue("@StokMiktari", stokMiktariInt);
                        cmd.Parameters.AddWithValue("@ürün_id", ürün_id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ürün başarıyla güncellendi!");
                        }
                        else
                        {
                            MessageBox.Show("Güncellenen ürün bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }

        }
    }

}


    

